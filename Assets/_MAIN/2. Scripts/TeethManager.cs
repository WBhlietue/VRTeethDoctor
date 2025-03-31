using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class TeethManager : MonoBehaviour
{
    public static TeethManager instance;
    public bool isTaria;
    public Transform shud;
    public bool isLockTeeth = false;
    Hand rightHand;
    public float sensutive;
    public float rotSensutive;
    int direction = 1;
    public float upTarget;
    public float downTarget;
    public float rotateTarget;
    public int upDownCount;
    public int rotateCount;
    bool canRotate = false;
    public Bahi tool;
    public GameObject tariaShadow;
    public GameObject bahiShadow;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        rightHand = Player.instance.rightHand;
        GManager.instance.Delay(() =>
        {
            // tariaShadow.SetActive(false);
            bahiShadow.SetActive(false);
        }, 0);
    }

    private void Update()
    {
        Debug.Log(rightHand.rotateDelta);
        if (!isLockTeeth)
        {
            return;
        }
        if (!canRotate)
        {
            shud.localEulerAngles -= Vector3.right * (rightHand.moveDelta.y * sensutive);
            float x = shud.localEulerAngles.x;
            if (x > 180)
            {
                x -= 360;
            }
            if (x > upTarget)
            {
                shud.localEulerAngles = Vector3.right * upTarget;
                if (direction == 1)
                {
                    direction = -1;
                    CheckUpDownCount();
                }
            }
            else if (x < -downTarget)
            {
                shud.localEulerAngles = Vector3.right * -downTarget;
                if (direction == -1)
                {
                    direction = 1;
                    CheckUpDownCount();
                }
            }
        }
        else
        {
            shud.parent.localEulerAngles -= Vector3.up * (rightHand.moveDelta.z * rotSensutive);
            float x = shud.parent.localEulerAngles.y;
            if (x > 180)
            {
                x -= 360;
            }
            if (x > rotateTarget)
            {
                shud.parent.localEulerAngles = Vector3.up * rotateTarget;
                if (direction == 1)
                {
                    direction = -1;
                    CheckRotateCount();
                }
            }
            else if (x < -rotateTarget)
            {
                shud.parent.localEulerAngles = Vector3.up * -rotateTarget;
                if (direction == -1)
                {
                    direction = 1;
                    CheckRotateCount();
                }
            }
        }
    }

    void CheckUpDownCount()
    {
        upDownCount--;
        if (upDownCount <= 0)
        {
            shud.localEulerAngles = Vector3.zero;
            canRotate = true;
        }
    }
    void CheckRotateCount()
    {
        rotateCount--;
        if (rotateCount <= 0)
        {
            GetTeeth();
        }
    }
    void GetTeeth()
    {
        isLockTeeth = false;
        tool.transform.parent.parent = null;
        shud.parent = tool.transform.parent;
        tool.Get();
    }


}
