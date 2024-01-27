using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCheckpoint : MonoBehaviour
{
    [SerializeField] private Enemy enemy;

    private void OnTriggerEnter(Collider other)
    {
        enemy.isChase = true;
        gameObject.SetActive(false);
    }
}
