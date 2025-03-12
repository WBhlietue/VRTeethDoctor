using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class MenuButtonManager : MonoBehaviour
{
    public Image[] btns;
    public Image selected = null;
    public int selectedNum = -1;
    public Color selectedColor;
    public Color unSelectedColor;
    public float duration;
    private void Start()
    {
        foreach (var item in btns)
        {
            item.color = unSelectedColor;
        }
    }
    public void Select(int num)
    {
        if (selected != null)
        {
            selected.DOColor(unSelectedColor, duration);
        }
        selected = btns[num];
        selectedNum = num;
        selected.DOColor(selectedColor, duration);
    }

    public void Confirm()
    {
        if (selectedNum >= 0)
        {
            SceneSwitch.instance.Call("VR 1");
        }
    }
}
