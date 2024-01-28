using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Trivia2Mechanic : MonoBehaviour
{
    [SerializeField] private List<GameObject> health;


    [Space(10)]
    [SerializeField] private GameManager gameManager;
    [SerializeField] private GameObject checkpoint;
    [SerializeField] private GameObject losePanel;
    [SerializeField] private GameObject trivia;
    [SerializeField] private PlayerMovement player;
    [SerializeField] private NavMeshAgent enemy;

    public void OnWrongButtonClick()
    {
        if (health.Count > 1)
        {
            health[health.Count - 1].SetActive(false);
            health.RemoveAt(health.Count - 1);
        } else
        {
            gameManager.audioSourceBgm.Stop();
            gameManager.TriviaSalahSfxPlay();
            losePanel.SetActive(true);
            trivia.SetActive(false);
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
            player.playerCanMove = false;
            enemy.isStopped = true;
        }
    }

    public void OnCorrectButtonClick()
    {
        checkpoint.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        player.playerCanMove = true;
        trivia.SetActive(false);
        enemy.isStopped = false;
    }
}
