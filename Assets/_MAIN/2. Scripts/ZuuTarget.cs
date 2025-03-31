using UnityEngine;

public class ZuuTarget : MonoBehaviour
{
    public Vector3 normal;
    public float offset = 80;
    private void Start()
    {
        normal = transform.up;
    }
    // private void OnCollisionEnter(Collision other)
    // {
    //     Debug.Log(other.gameObject.name, other.gameObject);
    //     Debug.Log(gameObject.name, gameObject);
    //     if (other.gameObject.TryGetComponent<Zuu>(out var shahuur))
    //     {
    //         Player.instance.rightHand.LockHand();
    //         Debug.Log(Vector3.Angle(other.contacts[0].normal, normal));
    //         if (Vector3.Angle(other.contacts[0].normal, normal) < offset)
    //         {
    //             shahuur.shahuur.OnShahah();
    //         }
    //     }
    // }
}