using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRHand : MonoBehaviour
{
    public bool isRight;
    private void Start()
    {
        if (isRight)
        {
            Player.instance.rightHand = GetComponent<Hand>();
        }
        else
        {
            Player.instance.leftHand = GetComponent<Hand>();
        }
    }
}
