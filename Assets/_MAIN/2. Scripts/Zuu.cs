using UnityEngine;

public class Zuu : MonoBehaviour
{
    public Shahuur shahuur;
    public float distance;
    public LayerMask mask;
    RaycastHit hit;
    bool isShahah = false;
    void Update()
    {
        if (isShahah)
        {
            return;
        }
        if (Physics.Raycast(transform.position, transform.forward, out hit, distance, mask))
        {
            Debug.Log(hit.collider.gameObject.name, hit.collider.gameObject);
            if (hit.collider.gameObject.TryGetComponent<ZuuTarget>(out var zuu))
            {
                TeethManager.instance.tariaShadow.SetActive(false);
                if (Vector3.Angle(hit.normal, zuu.normal) < zuu.offset)
                {
                    Player.instance.rightHand.LockHand();
                    shahuur.OnShahah();
                    isShahah = true;
                }
            }
        }
    }
}
