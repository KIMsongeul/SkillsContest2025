using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    public Transform player;
    private float xRot;
    private float yRot;
    private float mouseSpeed;
    private Camera cam;

    private void Start()
    {
        cam = Camera.main;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        float xMouse = Input.GetAxis("Mouse X");
        float yMouse = Input.GetAxis("Mouse Y");

        xRot -= yMouse;
        yRot += xMouse;

        xRot = Mathf.Clamp(xRot, -70f, 70f);
        cam.transform.rotation = Quaternion.Euler(xRot, yRot, 0);
        player.transform.rotation = Quaternion.Euler(0, yRot, 0);
    }
}
