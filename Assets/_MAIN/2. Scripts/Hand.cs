using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public float moveSpeed;
    public Vector3 chig;
    public Transform target;
    public List<PickItem> items = new List<PickItem>();
    public void Move(Vector3 c)
    {
        chig = c;
    }
    private void FixedUpdate()
    {
        transform.localPosition = Vector3.Lerp(transform.localPosition, Vector3.zero, moveSpeed*Time.deltaTime);
    }
}
