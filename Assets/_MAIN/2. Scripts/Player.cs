using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
    // public bool isVR;
    // public Transform cameraParent;
    // public float cameraUpLimit, cameraDownLimit;
    // Vector3 preMousePosition;
    // public float cameraHorSpeed;
    // public float cameraVerSpeed;
    // public ViewTarget vTarget;
    public Hand rightHand;
    public Hand leftHand;
    // public PickItem rPick;
    // public PickItem lPick;
    // public Transform lHandParent;
    // public Transform rHandParent;
    private void Awake()
    {
        instance = this;
    }
    // private void Start()
    // {
    //     preMousePosition = Input.mousePosition;
    // }
    // IEnumerator Delay()
    // {
    //     yield return new WaitForSeconds(2);
    //     lHandParent = leftHand.transform.parent;
    //     rHandParent = rightHand.transform.parent;
    // }


    // public bool TargetClick()
    // {
    //     if (vTarget == null)
    //     {
    //         return false;
    //     }
    //     vTarget.Click();
    //     return true;
    // }
    // public void RightPickItem()
    // {
    //     if (rightHand.items.Count > 0)
    //     {
    //         rightHand.items[0].Pick(rightHand.target);
    //         rPick = rightHand.items[0];
    //     }
    // }
    // public void RightDownItem()
    // {
    //     if (rPick != null)
    //     {
    //         rPick.Back();
    //     }
    //     rPick = null;
    // }

    // public void LeftPickItem()
    // {
    //     if (leftHand.items.Count > 0)
    //     {
    //         leftHand.items[0].Pick(leftHand.target);
    //         lPick = leftHand.items[0];
    //     }
    // }
    // public void LeftDownItem()
    // {
    //     if (lPick != null)
    //     {
    //         lPick.Back();
    //     }
    //     lPick = null;
    // }
}
