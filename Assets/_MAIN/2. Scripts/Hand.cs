using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction.Input;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public float moveSpeed;
    public Vector3 chig;
    public Transform target;
    public bool inMonth = false;
    public float rotSpeed;
    public float multSpeed = 1;
    public Finger[] fingers;
    public Transform handPosition;
    public GameObject handData;
    public bool isLocked = false;
    public Transform handParent;
    public SyntheticHand hand;
    Transform baseParent;
    public Vector3 moveDelta;
    public Vector3 rotateDelta;
    Vector3 prePos;
    Vector3 preRot;
    private void Start()
    {
        handParent = transform.parent;
        baseParent = handParent.parent;
        prePos = handPosition.position;
        preRot = handPosition.eulerAngles;
    }
    private void Update()
    {
        moveDelta = handPosition.position - prePos;
        rotateDelta = handPosition.eulerAngles - preRot;
        prePos = handPosition.position;
        preRot = handPosition.eulerAngles;
    }

    public void LockHand()
    {
        isLocked = true;
        handData.SetActive(false);
    }
    public void UnLockHand()
    {
        isLocked = false;
        handData.SetActive(true);
    }
    public void LockTeeth(Transform tr)
    {
        handParent.parent = tr;
        handData.SetActive(true);
        hand.enabled = false;
    }
    public void OffTeeth(){
        handParent.parent = baseParent;
        hand.enabled = true;
    }

}
