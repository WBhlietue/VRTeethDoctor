using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teeth : MonoBehaviour
{
    Outline outline;
    public float sensutive;
    bool selected;
    public float distance;
    public Transform handPos;
    public ParticleSystem blood;
    public bool isGet = false;
    void Start()
    {
        // TeethManager.instance.teeths.Add(this);
        // outline = GetComponent<Outline>();
        // outline.enabled = false;
    }
    public void Select()
    {
        if (selected)
        {
            return;
        }

        selected = true;

        outline.enabled = !isGet;
    }
    public void DeSelect()
    {
        if (!selected)
        {
            return;
        }
        
        selected = false;
        outline.enabled = false;
    }
    public bool Check(Transform viewDir)
    {
        float value = Vector3.Dot(viewDir.right, (viewDir.right - transform.position).normalized);
        if (value > sensutive && distance > Vector3.SqrMagnitude(transform.position - viewDir.position))
        {
            Select();
            return true;
        }
        else
        {
            DeSelect();
        }
        return false;
    }

}
