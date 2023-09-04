using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightMoving : MonoBehaviour
{
    public float speed;




    void Update()
    {
        Vector3 curPos = transform.position;
        Vector3 nextPos = Vector3.right * speed * Time.deltaTime;
        transform.position = curPos + nextPos;

    }

}
