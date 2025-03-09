using System.Collections.Generic;
using UnityEngine;

public class FingerTrack : MonoBehaviour
{
    public FingerTrackParent parent;
    public Finger.HandSide side;
    public List<int> ranges;
    public bool actived = false;
    private void Start()
    {
        parent.tracks.Add(this);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Finger>(out var finger))
        {
            Debug.Log(finger.fingerIndex);
            if (finger.side != side)
            {
                return;
            }
            if (ranges.IndexOf(finger.fingerIndex) == -1)
            {
                return;
            }
            actived = true;
            parent.Enter();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<Finger>(out var finger))
        {
            if (finger.side != side)
            {
                return;
            }
            if (ranges.IndexOf(finger.fingerIndex) == -1)
            {
                return;
            }
            actived = false;
            parent.Exit(this);
        }
    }
}
