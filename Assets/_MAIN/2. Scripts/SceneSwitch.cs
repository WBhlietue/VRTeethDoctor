using UnityEngine;
using Coffee.UIEffects;
using DG.Tweening;

public class SceneSwitch : MonoBehaviour
{
    public static SceneSwitch instance;
    public float time;
    public UITransitionEffect effect;
    bool isSwitch = false;
    private void Awake()
    {
        instance = this;
        DOTween.To(() => 1.0f, (i) => { effect.effectFactor = i; }, 0.0f, time).OnComplete(() =>
        {
            gameObject.SetActive(false);
        });
    }

    public void Call(string n)
    {
        if (isSwitch)
        {
            return;
        }
        isSwitch = true;
        gameObject.SetActive(true);
        DOTween.To(() => 0.0f, (i) => { effect.effectFactor = i; }, 1.0f, time).OnComplete(() =>
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(n);
        });
    }
}
