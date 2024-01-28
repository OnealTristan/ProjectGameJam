using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelTutorialScripts : MonoBehaviour
{
    [SerializeField] private PlayerCam cam;

    // Start is called before the first frame update
    void Awake()
    {
        cam.isStart = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }
}
