using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    [SerializeField] [Range(50f, 100f)] float speed = 100f; //range·Î Á¶Àý 
    public Rigidbody rb;
    float randomX, randomY;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        Jump();
    }
    public void Jump()
    {
        rb = GetComponent<Rigidbody>();


        randomY = Random.Range(0.1f, 0.4f);

        Vector3 dir = new Vector3(0, randomY, 0).normalized;

        rb.AddForce(dir * speed);
    }
}
