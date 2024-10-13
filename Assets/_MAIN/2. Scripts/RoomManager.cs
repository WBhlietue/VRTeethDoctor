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
    private void Awake()
    {
        instance = this;
    }
    public void GotoInside()
    {
        Player.instance.transform.DORotate(Vector3.up * -90, rotDuration);
        Player.instance.transform.DOMove(gotoInnerRoomPos.position, Vector3.Distance(Player.instance.transform.position, gotoInnerRoomPos.position) / moveSpeed).SetEase(Ease.Linear).OnComplete(() =>
        {
            door.DORotate(new Vector3(-90, -90, 0), doorDuration).OnComplete(() =>
            {
                Player.instance.transform.DOMove(innerRoomPos.position, Vector3.Distance(Player.instance.transform.position, innerRoomPos.position) / moveSpeed).SetEase(Ease.Linear).OnComplete(() =>
                {
                    door.DORotate(new Vector3(-90, 0, 0), doorDuration);
                });
            });
        });
    }

}
