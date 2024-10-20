using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierManager : MonoBehaviour
{
    public static Vector3 GetBezier(Vector3 startPos, Vector3 height, Vector3 endPos, float value)
    {
        return startPos * (1 - value) * (1 - value) + height * value * (1 - value) + endPos * value * value;
    }
}
