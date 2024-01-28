using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource audioSourceSfx;
    public AudioSource audioSourceBgm;
    [SerializeField] private AudioClip bgm, winSfx, triviaWrongSfx, jumpScareSfx, bruhSfx, emotionalDmgSfx, wrongBtnSfx1, wrongBtnSfx2, wrongBtnSfx3, wrongBtnSfx4;

    void Awake()
    {
        audioSourceBgm.clip = bgm;
        audioSourceBgm.loop = true;
        audioSourceBgm.Play();
    }

    public void WinSfxPlay()
    {
        audioSourceSfx.clip = winSfx;
        audioSourceSfx.Play();
    }

    public void TriviaSalahSfxPlay()
    {
        audioSourceSfx.clip = triviaWrongSfx;
        audioSourceSfx.loop = false;
        audioSourceSfx.Play();
    }

    public void JumpScareSfxPlay()
    {
        audioSourceSfx.clip = jumpScareSfx;
        audioSourceSfx.loop = false;
        audioSourceSfx.Play();
    }

    public void BruhSfxPlay()
    {
        audioSourceSfx.clip = bruhSfx;
        audioSourceSfx.loop = false;
        audioSourceSfx.Play();
    }

    public void EmotionalDmgSfxPlay()
    {
        audioSourceSfx.clip = emotionalDmgSfx;
        audioSourceSfx.loop = false;
        audioSourceSfx.Play();
    }

    public void WrongButton1SfxPlay()
    {
        audioSourceSfx.clip = wrongBtnSfx1;
        audioSourceSfx.loop = false;
        audioSourceSfx.Play();
    }

    public void WrongButton2SfxPlay()
    {
        audioSourceSfx.clip = wrongBtnSfx2;
        audioSourceSfx.loop = false;
        audioSourceSfx.Play();
    }

    public void WrongButton3SfxPlay()
    {
        audioSourceSfx.clip = wrongBtnSfx3;
        audioSourceSfx.loop = false;
        audioSourceSfx.Play();
    }

    public void WrongButton4SfxPlay()
    {
        audioSourceSfx.clip = wrongBtnSfx4;
        audioSourceSfx.loop = false;
        audioSourceSfx.Play();
    }
}
