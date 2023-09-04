using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset; //보존값
    
    void Update()
    {
        transform.position = target.position + offset;
       
    }
}
