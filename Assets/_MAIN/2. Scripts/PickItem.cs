using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickItem : MonoBehaviour
{
    public Vector3 initPos;
    public Quaternion initRot;
    private void Start()
    {
        initPos = transform.position;
        initRot = transform.rotation;
    }
    public void Pick(Transform target)
    {
        StartCoroutine(MoveHand(transform.position, target));

    }
    public void Back()
    {
        StartCoroutine(MoveBack(transform.position));
    }
    IEnumerator MoveHand(Vector3 startPos, Transform endPos)
    {
        Vector3 height = (startPos + endPos.position) / 2 + Vector3.up * 0;
        Quaternion rot = transform.rotation;
        for (float i = 0; i < 1; i += Time.deltaTime)
        {
            transform.position = BezierManager.GetBezier(startPos, height, endPos.position, i);
            transform.rotation = Quaternion.Lerp(rot, endPos.rotation, i);
            yield return 0;
        }
        transform.parent = endPos;
        transform.position = endPos.position;
        transform.rotation = endPos.rotation;
    }
    IEnumerator MoveBack(Vector3 startPos)
    {
        Vector3 height = (startPos + initPos) / 2 + Vector3.up * 0;
        Quaternion rot = transform.rotation;
        for (float i = 0; i < 1; i += Time.deltaTime)
        {
            transform.position = BezierManager.GetBezier(startPos, height, initPos, i);
            transform.rotation = Quaternion.Lerp(rot, initRot, i);
            yield return 0;
        }
        transform.parent = null;
        transform.position = initPos;
        transform.rotation = initRot;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("hand"))
        {
            Hand hand = other.GetComponent<Hand>();
            if (!hand.items.Contains(this))
            {
                hand.items.Add(this);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("hand"))
        {
            Hand hand = other.GetComponent<Hand>();
            if (hand.items.Contains(this))
            {
                hand.items.Remove(this);
            }
        }
    }
}
