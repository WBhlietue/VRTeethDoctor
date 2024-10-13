using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;

public class ViewTarget : MonoBehaviour
{
    public float sensutive;
    Camera cam;
    bool isActive = false;
    public float duration;
    public UnityEvent evs;
    private void Start()
    {
        cam = Camera.main;
        transform.localScale = Vector3.zero;
    }
    private void Update()
    {
        float value = Vector3.Dot(cam.transform.forward, (transform.position - cam.transform.position).normalized);
        Debug.Log(value);
        if (value > sensutive)
        {
            Active();
        }
        else
        {
            DisActive();
        }

    }
    public void Active()
    {
        if (isActive)
        {
            return;
        }
        isActive = true;
        transform.DOScale(Vector3.one, duration).SetEase(Ease.OutBack);
        Player.instance.vTarget = this;

    }
    public void DisActive()
    {
        if (!isActive)
        {
            return;
        }
        isActive = false;
        transform.DOScale(Vector3.zero, duration).SetEase(Ease.InBack);
        Player.instance.vTarget = null;
    }
    public void Click()
    {
        evs.Invoke();
    }
}
