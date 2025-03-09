using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
    void Awake()
    {

        Application.targetFrameRate = 90;
        OVRManager.display.displayFrequency = 90;
        QualitySettings.vSyncCount = 1;
        OVRManager.foveatedRenderingLevel = OVRManager.FoveatedRenderingLevel.Off;


    }

}
