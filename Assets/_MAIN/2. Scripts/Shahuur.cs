using UnityEngine;

public class Shahuur : FingerTrackParent
{
    public override void OnActive()
    {
        Debug.Log("active");
        // transform.parent = Player.instance.rightHand.fingers[1].transform;
        transform.parent = Player.instance.rightHand.target;
    }
    public override void OnDeActive()
    {
        // Debug.Break();
        transform.parent = null;
        // GetComponent<PickItem>().Back();

    }
}
