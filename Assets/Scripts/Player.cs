using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rigidbody;

    public float speed;

    public int coin;
    public int maxCoin;
   

    float hAxis;
    float vAxis;
    

    Vector3 moveVec;
    Animator anim;

  
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Awake()
    {
        anim = GetComponentInChildren<Animator>();
    }

    void OnTriggerEnter(Collider collision)
    {
      
        if(collision.gameObject.tag == "EnemyR" || collision.gameObject.tag == "EnemyL" || collision.gameObject.tag == "OBJ" || collision.gameObject.tag == "Wall")
        {
            GameManager.Instance.GameOver();
        }
       
    }

    void Update()
    {
        //이동
        hAxis = Input.GetAxisRaw("Horizontal");

        vAxis = Input.GetAxisRaw("Vertical");
        
            anim.SetBool("RunP", moveVec != Vector3.zero); //애니메이터에 이름 넣기 아직 없음.
        // X축 y축 이동값을 가져온다.

        moveVec = new Vector3(hAxis, 0, vAxis).normalized; //움직임

        transform.position += moveVec * speed * Time.deltaTime;

       

        transform.LookAt(transform.position + moveVec); //Stop

        
    }
    
    }

