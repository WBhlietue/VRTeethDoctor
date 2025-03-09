using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RoomManager : MonoBehaviour
{
    public static RoomManager instance;
    public Transform gotoInnerRoomPos;
    public Transform innerRoomPos;
    public Transform door;
    public float doorDuration;
    public float moveSpeed;
    public float rotDuration;
    bool updateActive = false;
    bool goInside = false;
    public float speedNum;
    public float cameraOffset;
    public Transform cameraMove;
    float count = 0;
    private void Awake()
    {
        instance = this;
    }
    public void GotoInside()
    {

        
    }
    private void Update()
    {
        if (!updateActive)
        {
            return;
        }
        count += Time.deltaTime;
        float value = count * speedNum;
        float sin = Mathf.Sin(value);
        if (sin > 0)
        {
            sin *= -1;
        }
        float cos = Mathf.Cos(value);
        cameraMove.localPosition = new Vector3(cos, sin, 0) * cameraOffset;
        
    }

}
