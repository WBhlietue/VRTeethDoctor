using UnityEngine;
using DG.Tweening;

public class Shahuur : MonoBehaviour
{
    public Transform backShahuur;
    public float duration;
    public float targetValue;
    float initValue;
    public void Start()
    {
        initValue = backShahuur.localPosition.y;
    }
    public void OnShahah()
    {
        backShahuur.DOLocalMoveY(targetValue, duration).OnComplete(() =>
        {
            backShahuur.DOLocalMoveY(initValue, duration).OnComplete(() =>
            {
                Debug.Log("Over");
            });
        });
    }

}
