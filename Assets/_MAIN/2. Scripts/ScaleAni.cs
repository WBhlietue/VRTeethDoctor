using UnityEngine;
using DG.Tweening;

public class ScaleAni : MonoBehaviour
{
    public float duration;

    [ContextMenu("asd")]
    public void Call()
    {
        gameObject.SetActive(true);
        transform.DOScale(1.0f, duration).SetEase(Ease.OutBack).From(0.0f);
    }
    [ContextMenu("asas")]
    public void Off()
    {
        transform.DOScale(0.0f, duration).SetEase(Ease.InBack).From(1.0f).OnComplete(() =>
        {
            gameObject.SetActive(false);
        });
    }
}
