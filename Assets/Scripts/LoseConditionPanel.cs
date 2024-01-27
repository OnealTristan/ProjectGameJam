using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LoseConditionPanel : MonoBehaviour
{
    [SerializeField] private GameObject checkpoint;
    [SerializeField] private Transform playerSpawnPoint;
    [SerializeField] private Transform enemySpawnPoint;
    [SerializeField] private GameObject tembok;
    [SerializeField] private PlayerMovement player;
    [SerializeField] private NavMeshAgent enemy;
    [SerializeField] private GameObject losePanel;

    public void OnRealRestartButtonClick()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        player.playerCanMove = true;
        enemy.isStopped = false;
        checkpoint.SetActive(true);
        losePanel.SetActive(false);
        tembok.SetActive(false);
        player.transform.position = playerSpawnPoint.transform.position;
        enemy.transform.position = enemySpawnPoint.transform.position;
    }
}
