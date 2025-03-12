using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction.HandGrab;
using UnityEngine;
using UnityEngine.Events;

public class FingerTrackParent : MonoBehaviour
{
    Coroutine cor;
    public List<FingerTrack> tracks = new List<FingerTrack>();
    public float time;
    public void Enter()
    {
        if (cor != null)
        {
            StopCoroutine(cor);
            cor = null;
        }
        for (int i = 0; i < tracks.Count; i++)
        {
            if (!tracks[i].actived)
            {
                return;
            }
        }
        OnActive();
    }

    public void Exit(FingerTrack tr)
    {
        if (cor != null)
        {
            StopCoroutine(cor);
        }
        cor = StartCoroutine(Delay(() =>
       {

           for (int i = 0; i < tracks.Count; i++)
           {
               if (tracks[i].actived)
               {
                   return;
               }
           }
           OnDeActive();
       }));
    }
    IEnumerator Delay(UnityEngine.Events.UnityAction action)
    {
        yield return new WaitForSeconds(time);
        cor = null;
        action();
    }
    public virtual void OnActive()
    {

    }
    public virtual void OnDeActive()
    {

    }
}
