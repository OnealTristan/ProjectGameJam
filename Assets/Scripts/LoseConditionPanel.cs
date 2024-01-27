using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class LoseConditionPanel : MonoBehaviour
{
    [SerializeField] private RectTransform fakeButton;
    [SerializeField] private GameObject checkpoint;
    [SerializeField] private Transform playerSpawnPoint;
    [SerializeField] private Transform enemySpawnPoint;
    [SerializeField] private GameObject tembok;
    [SerializeField] private PlayerMovement player;
    [SerializeField] private NavMeshAgent enemy;
    [SerializeField] private GameObject losePanel;

    public void OnRealRestartButtonClick()
    {
        SceneManager.LoadScene("SampleScene");
        /*Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        player.playerCanMove = true;
        enemy.isStopped = false;
        checkpoint.SetActive(true);
        losePanel.SetActive(false);
        tembok.SetActive(false);
        TeleportEnemyPlayer();
        fakeButton.localPosition = new Vector2(0, -340f);*/
    }

    public void OnFakeRestartButtonClick()
    {
        fakeButton.position = new Vector2(Random.Range(200, 1800), Random.Range(200, 800));
    }

    private void TeleportEnemyPlayer()
    {
        player.transform.position = playerSpawnPoint.transform.position;
        enemy.transform.position = enemySpawnPoint.transform.position;
    }
}
