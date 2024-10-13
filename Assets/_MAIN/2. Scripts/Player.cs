using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
    public bool isVR;
    public Transform cameraParent;
    public float cameraUpLimit, cameraDownLimit;
    Vector3 preMousePosition;
    public float cameraHorSpeed;
    public float cameraVerSpeed;
    public ViewTarget vTarget;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        preMousePosition = Input.mousePosition;
    }
    private void Update()
    {
        if (!isVR)
        {
            if (Input.GetKey(KeyCode.W))
            {

            }
            if (Input.GetKey(KeyCode.A))
            {

            }
            if (Input.GetKey(KeyCode.S))
            {

            }
            if (Input.GetKey(KeyCode.D))
            {

            }
            if (Input.GetKey(KeyCode.Q))
            {

            }
            if (Input.GetKey(KeyCode.E))
            {

            }
            if (Input.GetKey(KeyCode.Space))
            {
                vTarget?.Click();
                
            }
            Vector3 mouseDelta = Input.mousePosition - preMousePosition;
            transform.eulerAngles += Vector3.up * (cameraHorSpeed * Time.deltaTime * mouseDelta.x);
            Vector3 rot = cameraParent.eulerAngles;
            rot.x += cameraVerSpeed * Time.deltaTime * -mouseDelta.y;
            if (rot.x > 180)
            {
                rot.x -= 360;
            }
            if (rot.x < cameraDownLimit)
            {
                rot.x = cameraDownLimit;
            }
            else
            if (rot.x > cameraUpLimit)
            {
                rot.x = cameraUpLimit;
            }
            cameraParent.eulerAngles = rot;
            preMousePosition = Input.mousePosition;

        }
    }
}
