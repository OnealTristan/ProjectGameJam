using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongLiftCheckpoint : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        gameManager.EmotionalDmgSfxPlay();
        gameObject.SetActive(false);
    }
}
