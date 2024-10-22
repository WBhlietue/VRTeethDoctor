using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class GManager : MonoBehaviour
{
    public SteamVR_Action_Boolean leftHandBig;
    public SteamVR_Action_Boolean leftHandLittle;
    public SteamVR_Action_Boolean leftHandA;
    public SteamVR_Action_Boolean leftHandB;
    public SteamVR_Input_Sources leftHand;

    public SteamVR_Action_Boolean rightHandBig;
    public SteamVR_Action_Boolean rightHandLittle;
    public SteamVR_Action_Boolean rightHandA;
    public SteamVR_Action_Boolean rightHandB;
    public SteamVR_Input_Sources rightHand;
    void Awake()
    {
        Application.targetFrameRate = 60;
        leftHandBig.AddOnStateDownListener(LeftHandBigDown, leftHand);
        leftHandBig.AddOnStateUpListener(LeftHandBigUp, leftHand);
        leftHandLittle.AddOnStateDownListener(LeftHandLittleDown, leftHand);
        leftHandLittle.AddOnStateUpListener(LeftHandLittleUp, leftHand);
        leftHandA.AddOnStateDownListener(LeftHandADown, leftHand);
        leftHandA.AddOnStateUpListener(LeftHandAUp, leftHand);
        leftHandB.AddOnStateDownListener(LeftHandBDown, leftHand);
        leftHandB.AddOnStateUpListener(LeftHandBUp, leftHand);

        rightHandBig.AddOnStateDownListener(RightHandBigDown, rightHand);
        rightHandBig.AddOnStateUpListener(RightHandBigUp, rightHand);
        rightHandLittle.AddOnStateDownListener(RightHandLittleDown, rightHand);
        rightHandLittle.AddOnStateUpListener(RightHandLittleUp, rightHand);
        rightHandA.AddOnStateDownListener(RightHandADown, rightHand);
        rightHandA.AddOnStateUpListener(RightHandAUp, rightHand);
        rightHandB.AddOnStateDownListener(RightHandBDown, rightHand);
        rightHandB.AddOnStateUpListener(RightHandBUp, rightHand);

    }
    public void LeftHandBigDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Debug.Log("Big " + fromAction);
    }
    public void LeftHandLittleDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Debug.Log("Little " + fromAction);
    }
    public void LeftHandADown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        if (Player.instance.TargetClick())
        {

        }
    }
    public void LeftHandBDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Debug.Log("B " + fromAction);
    }
    public void LeftHandBigUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Debug.Log("Big " + fromAction);
    }
    public void LeftHandLittleUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Debug.Log("Little " + fromAction);
    }
    public void LeftHandAUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Debug.Log("A " + fromAction);
    }
    public void LeftHandBUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Debug.Log("B " + fromAction);
    }


    public void RightHandBigDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Debug.Log("Big " + fromAction);
    }
    public void RightHandLittleDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Player.instance.RightPickItem();
    }
    public void RightHandADown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {

    }
    public void RightHandBDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Debug.Log("B " + fromAction);
    }
    public void RightHandBigUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Debug.Log("Big " + fromAction);
    }
    public void RightHandLittleUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Player.instance.RightDownItem();
    }
    public void RightHandAUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Debug.Log("A " + fromAction);
    }
    public void RightHandBUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Debug.Log("B " + fromAction);
    }


}
