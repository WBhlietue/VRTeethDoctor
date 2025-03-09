using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMeshColl : MonoBehaviour
{
    
    void Awake()
    {
        Mesh m =GetComponent<MeshFilter>().mesh;
        var c = gameObject.AddComponent<MeshCollider>();
        c.sharedMesh = m;
    }

}
