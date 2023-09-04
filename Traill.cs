using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traill : MonoBehaviour
{
    public float speed;

    void Update()
    {
        Vector3 curPos = transform.position;
        Vector3 nextPos = Vector3.left * speed * Time.deltaTime;
        transform.position = curPos + nextPos;

    }
}
