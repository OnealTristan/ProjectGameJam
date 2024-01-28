using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CorrectLiftCheckpoint : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private GameObject winPanel;
    [SerializeField] private PlayerMovement player;
    [SerializeField] private NavMeshAgent enemy;

    private void OnTriggerEnter(Collider other)
    {
        gameManager.audioSourceBgm.Stop();
        gameManager.WinSfxPlay();
        gameObject.SetActive(false);
        winPanel.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        player.playerCanMove = false;
        enemy.isStopped = true;
    }
}
