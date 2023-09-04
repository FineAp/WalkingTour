using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public float speed;

    void Update()
    {
        Vector3 curPos = transform.position;  //땅이 앞으로 움직이게 설정하였음.
        Vector3 nextPos = Vector3.forward * speed * Time.deltaTime;
        transform.position = curPos + nextPos;

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Road")
        {
            Destroy(collision.gameObject);
            GameManager.Instance.Score();
        }
        else if(collision.gameObject.tag == "OBJ")
        {
            Destroy(collision.gameObject);
        }

        else if (collision.gameObject.tag == "EnemyR")
        {
            Destroy(collision.gameObject);
        }

        else if (collision.gameObject.tag == "EnemyL")
        {
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "OBJX")
        {
            Destroy(collision.gameObject);
        }
    }
}
