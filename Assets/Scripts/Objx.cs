using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objx : MonoBehaviour
{
    public float speed;

    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Vector3 curPos = transform.position;
            Vector3 nextPos = Vector3.down * speed * Time.deltaTime;
            transform.position = curPos + nextPos;
        }
    }
 }
