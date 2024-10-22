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
    public Hand rightHand;
    public Hand leftHand;
    PickItem rPick;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        preMousePosition = Input.mousePosition;
    }
    private void FixedUpdate()
    {
        if (!isVR)
        {
            Vector3 chig = Vector3.zero;
            if (Input.GetKey(KeyCode.W))
            {
                chig.z += 1;
            }
            if (Input.GetKey(KeyCode.A))
            {
                chig.x += -1;
            }
            if (Input.GetKey(KeyCode.S))
            {
                chig.z += -1;
            }
            if (Input.GetKey(KeyCode.D))
            {
                chig.x += 1;
            }
            if (Input.GetKey(KeyCode.Q))
            {
                chig.y += 1;
            }
            if (Input.GetKey(KeyCode.E))
            {
                chig.y += -1;
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                if (rightHand.items.Count > 0)
                {
                    rightHand.items[0].Pick(rightHand.target);
                    rPick = rightHand.items[0];
                }
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                if (rPick != null)
                {
                    rPick.Back();
                }
                rPick = null;
            }
            if (Input.GetKey(KeyCode.Space))
            {
                vTarget?.Click();

            }
            rightHand.Move(chig.normalized);
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

    public bool TargetClick()
    {
        if (vTarget == null)
        {
            return false;
        }
        vTarget.Click();
        return true;
    }
    public void RightPickItem()
    {
        if (rightHand.items.Count > 0)
        {
            rightHand.items[0].Pick(rightHand.target);
            rPick = rightHand.items[0];
        }
    }
    public void RightDownItem()
    {
        if (rPick != null)
        {
            rPick.Back();
        }
        rPick = null;
    }
}
