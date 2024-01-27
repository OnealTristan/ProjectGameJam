using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class CheckpointMechanic : MonoBehaviour
{
    [SerializeField] private PlayerMovement player;
    [SerializeField] private GameObject trivia;
    [SerializeField] private NavMeshAgent enemy;
    [SerializeField] private PlayerCam playerCam;
    private void OnTriggerEnter(Collider other)
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        player.playerCanMove = false;
        trivia.SetActive(true);
        enemy.isStopped = true;
    }
}
