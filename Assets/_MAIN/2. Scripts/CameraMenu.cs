using UnityEngine;

public class CameraMenu : MonoBehaviour
{
    public Transform cameraTarget;
    public float distance;
    public Vector3 offset;
    public float lerpSpeed;

    private void Update()
    {
        var forward = cameraTarget.forward;
        forward.y = 0;
        forward.Normalize();
        transform.position = Vector3.Lerp(transform.position, cameraTarget.position + forward * distance + offset, lerpSpeed * Time.deltaTime);
        transform.eulerAngles = Vector3.up * cameraTarget.eulerAngles.y;
    }
}
