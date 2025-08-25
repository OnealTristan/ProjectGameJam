using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    [Header(" Settings ")]
    [SerializeField] public Transform orientation;

    [Header(" Elements ")]
    [SerializeField] private float sensX;
    [SerializeField] private float sensY;

    float xRotation;
    float yRotation;

    public bool isStart = false;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        transform.localRotation = Quaternion.Euler(0, -270f, 0);
        yield return new WaitForSeconds(1);
        isStart = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isStart)
        {
            return;
        }
        if (Cursor.visible == false)
        {
            float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
            float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

            yRotation += mouseX;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0);
            orientation.localRotation = Quaternion.Euler(0, yRotation, 0);
        }
    }
}
