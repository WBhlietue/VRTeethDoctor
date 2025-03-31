using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GManager : MonoBehaviour
{
    public static GManager instance;
    void Awake()
    {
        instance = this;
        Application.targetFrameRate = 90;
        OVRManager.display.displayFrequency = 90;
        QualitySettings.vSyncCount = 1;
        OVRManager.foveatedRenderingLevel = OVRManager.FoveatedRenderingLevel.Off;
    }
    public void Delay(UnityAction action, float time)
    {
        StartCoroutine(DelayCor(action, time));
    }
    IEnumerator DelayCor(UnityAction action, float time)
    {
        yield return new WaitForSeconds(time);
        action();
    }


}
