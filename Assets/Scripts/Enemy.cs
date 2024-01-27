using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject losePanel;
    [SerializeField] private PlayerMovement player;
    [SerializeField] private NavMeshAgent enemy;
    [SerializeField] private Transform playerPosition;
    private NavMeshAgent navMeshAgent;

    public bool isChase = false;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isChase == true)
        {
            navMeshAgent.destination = playerPosition.position;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && isChase == true)
        {
            losePanel.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
            player.playerCanMove = false;
            enemy.isStopped = true;
        }
    }
}
