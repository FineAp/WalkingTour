using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public enum Type { Coin };
    public Type type;
    public int value;
    public float speed;
    void Update()
    { 

    transform.Rotate(Vector3.back* speed * Time.deltaTime); //코인이 회전

     }
}
