using Oculus.Interaction;
using UnityEngine;

public class Bahi : MonoBehaviour
{
    public Transform t;
    public float distance;
    public LayerMask mask;
    RaycastHit hit;
    bool isGet = false;
    public GameObject pick;
    void Update()
    {
        Debug.Log(transform.up);
        if (isGet)
        {
            return;
        }
        if (Mathf.Abs(transform.up.z) < 0.8f)
        {
            return;
        }
        if (Physics.Raycast(transform.position, transform.forward, out hit, distance, mask))
        {
            Debug.Log(hit.collider.gameObject.name, hit.collider.gameObject);
            if (hit.collider.gameObject.TryGetComponent<ZuuTarget>(out var zuu))
            {
                if (Vector3.Angle(hit.normal, zuu.normal) < zuu.offset)
                {
                    TeethManager.instance.bahiShadow.SetActive(false);
                    // Player.instance.rightHand.LockHand();
                    // pick.SetActive(false);
                    pick.GetComponent<Grabbable>().InjectOptionalTargetTransform(t);
                    TeethManager.instance.isLockTeeth = true;
                    TeethManager.instance.tool = this;
                    // GetComponentInParent<PickItem>().enabled = false;
                    isGet = true;
                    Player.instance.rightHand.LockTeeth(transform.parent);
                    Player.instance.rightHand.LockHand();
                    transform.parent.parent = zuu.transform.parent;
                }
            }
        }
    }
    public void Get()
    {
        Player.instance.rightHand.UnLockHand();
        Player.instance.rightHand.OffTeeth();
        // pick.SetActive(true);
        pick.GetComponent<Grabbable>().InjectOptionalTargetTransform(transform.parent);
        // GetComponentInParent<PickItem>().enabled = true;
    }
}
