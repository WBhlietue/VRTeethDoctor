using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Image background;
    public Transform pointer;
    public float duration;
    public int minutes;
    public TextMeshProUGUI text;
    public int count;
    public static Timer instance;
    public Transform clock;
    private void Awake()
    {
        instance = this;
        gameObject.SetActive(false);
    }
    public void Call(UnityEngine.Events.UnityAction action)
    {
        gameObject.SetActive(true);
        // background.DOFade(0.6f, 0.3f).From(0).OnComplete(() =>
        // {
        clock.DOScale(1, 0.5f).SetEase(Ease.OutBack).From(0).OnComplete(() =>
        {

            count = 60 * minutes;
            DOTween.To(() => count, (i) =>
            {
                pointer.transform.localEulerAngles = Vector3.forward * ((count - i) % 60 * -6);
                int s = i % 60;
                int m = i / 60;
                text.text = "00:" + (m < 10 ? "0" : "") + m + ":" + (s < 10 ? "0" : "") + s;
            }, 0, duration).SetEase(Ease.Linear).OnComplete(() =>
            {
                clock.DOScale(0, 0.5f).SetEase(Ease.InBack).OnComplete(() =>
                {
                    // background.DOFade(0, 0.3f).OnComplete(() =>
                    // {
                    gameObject.SetActive(false);
                    action();
                    // });
                });
            });
        });

        // });
    }
}