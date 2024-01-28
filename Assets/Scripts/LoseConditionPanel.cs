using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class LoseConditionPanel : MonoBehaviour
{
    [SerializeField] private RectTransform fakeButton;
    [SerializeField] private GameManager gameManager;

    public void OnRealRestartButtonClick()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OnFakeRestartButtonClick()
    {
        gameManager.BruhSfxPlay();
        fakeButton.position = new Vector2(Random.Range(200, 1800), Random.Range(200, 800));
    }
}
