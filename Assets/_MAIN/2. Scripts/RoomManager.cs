using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Dreamteck.Splines;
using UnityEngine.Rendering;

public class RoomManager : MonoBehaviour
{
    public static RoomManager instance;
    public Transform gotoInnerRoomPos;
    public Transform innerRoomPos;
    public Transform door;
    public float doorDuration;
    public float moveSpeed;
    public float rotDuration;
    public SplineFollower follower;
    bool updateActive = false;
    bool goInside = false;
    private void Awake()
    {
        instance = this;
    }
    public void GotoInside()
    {
        follower.followSpeed = moveSpeed;
        updateActive = true;
        goInside = true;
        door.DORotate(new Vector3(-90, -90, 0), doorDuration);

    }
    private void Update()
    {
        if (!updateActive)
        {
            return;
        }
        if (goInside)
        {
            if (follower.GetPercent() >= 1)
            {
                updateActive = false;
                door.DORotate(new Vector3(-90, 0, 0), doorDuration);
            }
        }
    }

}
