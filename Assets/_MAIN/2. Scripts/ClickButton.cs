using System.Collections;
using UnityEngine;
using UnityEngine.Events;
public class ClickButton : MonoBehaviour
{
    public bool useOne = false;
    bool canUse = true;
    public bool single = false;
    public float timing;
    bool click = false;
    public UnityEvent events;
    Coroutine cor;
    IEnumerator Counter()
    {
        yield return new WaitForSeconds(timing);
        click = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("finger"))
        {
            if (single)
            {
                events.Invoke();
                if (useOne)
                {
                    canUse = false;
                }
            }
            else
            {
                if (!click)
                {
                    click = true;
                    if (cor != null)
                    {
                        StopCoroutine(cor);

                    }
                    cor = StartCoroutine(Counter());
                }
                else
                {
                    if (cor != null)
                    {
                        StopCoroutine(cor);

                    }
                    click = false;
                    events.Invoke();
                }
            }
        }
    }
}

