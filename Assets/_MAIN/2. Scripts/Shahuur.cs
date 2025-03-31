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
                Player.instance.rightHand.UnLockHand();
                GManager.instance.Delay(() =>
                {
                    Timer.instance.Call(() =>
                    {
                        TeethManager.instance.isTaria = true;
                        
                        TeethManager.instance.bahiShadow.SetActive(true);
                    });
                }, 1f);
            });
        });
    }

}
