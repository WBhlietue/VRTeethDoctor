using System.Collections;
using System.Collections.Generic;
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
    private void FixedUpdate()
    {
        transform.localPosition = Vector3.Lerp(transform.localPosition, Vector3.zero, moveSpeed * multSpeed * Time.deltaTime);
        transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.identity, rotSpeed * multSpeed * Time.deltaTime);
        // transform.localEulerAngles = Vector3.Lerp(transform.localEulerAngles, Vector3.zero, rotSpeed * Time.deltaTime);
    }
}
