using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class TeethManager : MonoBehaviour
{
    public static TeethManager instance;
    // public bool isOpen = false;
    public List<Teeth> teeths = new List<Teeth>();
    public Teeth selected = null;
    public bool chekingTeeth = true;
    public bool locked = false;
    public Transform openHand;
    public Transform handMovement;
    public float rotateOffset;
    public float handTrackSpeed;
    public float handHeight;
    public int fullCount;
    public int status = 0;
    public int currentCount;
    // public Transform huvunTarget;
    // public Transform huvun;
    private void Awake()
    {
        instance = this;
    }
    // public void OpenMonth()
    // {
    //     Player.instance.rightHand.transform.parent = openHand;
    //     Player.instance.rightHand.GetComponent<Collider>().enabled = false;
    //     Player.instance.rightHand.multSpeed = 5;
    //     headAnimation.SetBool("open", true);
    //     isOpen = true;
    // }
    // public void CloseMonth()
    // {
    //     Player.instance.rightHand.transform.parent = Player.instance.rHandParent;
    //     Player.instance.rightHand.GetComponent<Collider>().enabled = true;
    //     Player.instance.rightHand.multSpeed = 1;
    //     headAnimation.SetBool("open", false);
    //     isOpen = false;
    // }
    private void Update()
    {
        if (locked)
        {
            Vector3 r = selected.transform.localRotation.eulerAngles + Vector3.right * (handHeight - handMovement.position.y) * Time.deltaTime * handTrackSpeed;
            if (r.x > 180)
            {
                r.x -= 360;
            }
            handHeight = handMovement.position.y;
            Debug.Log("raw: " + r);
            if (r.x > rotateOffset)
            {
                if (status == -1)
                {
                    currentCount++;
                }
                status = 1;
                r = Vector3.right * rotateOffset;
            }
            if (r.x < -rotateOffset)
            {
                if (status == 1)
                {
                    currentCount++;
                }
                status = -1;
                r = Vector3.right * -rotateOffset;
            }
            Debug.Log("final: " + r);
            selected.transform.localRotation = Quaternion.Euler(r);
            Debug.Log("A: " + selected.transform.localRotation.eulerAngles);
            if (currentCount >= fullCount)
            {
                GetTeeth();
            }
        }
    }
    public void LockTeeth()
    {
        if (selected != null)
        {
            locked = true;
            chekingTeeth = false;
            Player.instance.leftHand.transform.parent = selected.handPos;
            Player.instance.leftHand.GetComponent<Collider>().enabled = false;
            Player.instance.leftHand.multSpeed = 5;
            handHeight = handMovement.position.y;
            status = 0;
            currentCount = 0;
        }
    }
    public void UnlockTeeth()
    {
        // if (!locked || chekingTeeth)
        // {
        //     return;
        // }
        // locked = false;
        // chekingTeeth = true;
        // Player.instance.leftHand.transform.parent = Player.instance.lHandParent;
        // Player.instance.leftHand.GetComponent<Collider>().enabled = true;
        // Player.instance.leftHand.multSpeed = 1;
    }
    public void GetTeeth()
    {
        // if (!locked || chekingTeeth)
        // {
        //     return;
        // }
        // selected.isGet = true;
        // huvun.transform.DOMove(huvunTarget.position, selected.blood.main.duration).SetEase(Ease.Linear);
        // selected.blood.Play();
        // locked = false;
        // chekingTeeth = true;
        // Player.instance.leftHand.transform.parent = Player.instance.lHandParent;
        // selected.transform.parent = Player.instance.lPick.taregetPos;
        // selected.transform.localPosition = Vector3.zero;
        // selected.transform.localRotation = Quaternion.identity;
        // Player.instance.leftHand.GetComponent<Collider>().enabled = true;
        // Player.instance.leftHand.multSpeed = 1;
    }
    

}
