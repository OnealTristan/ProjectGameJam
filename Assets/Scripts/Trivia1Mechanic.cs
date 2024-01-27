using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Trivia1Mechanic : MonoBehaviour
{
    [SerializeField] private GameObject tembok;
    [SerializeField] private GameObject checkpoint;
    [SerializeField] private PlayerMovement player;
    [SerializeField] private GameObject trivia1;
    [SerializeField] private NavMeshAgent enemy;
    [SerializeField] private PlayerCam playerCam;

    public void ButtonBenarClicked()
    {
        checkpoint.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        player.playerCanMove = true;
        trivia1.SetActive(false);
        enemy.isStopped = false;
    }

    public void ButtonSalahClicked()
    {
        checkpoint.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        player.playerCanMove = true;
        trivia1.SetActive(false);
        enemy.isStopped = false;
        tembok.SetActive(true);
    }
}
