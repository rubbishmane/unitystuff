using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    //public float maxMoveSpeed;
    public float moveX, moveY;
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        

        
        
    }

    void FixedUpdate()
    {
        PlayerMove();
        

        //Clamp Player Speed
        // if(rb.velocity.magnitude >= maxMoveSpeed)
        // {
        //     rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxMoveSpeed);
        // }

    }

    void PlayerMove()
    {
        
        

        rb.AddForce(new Vector3(moveX, 0, moveY), ForceMode.Impulse);
        if(moveX == 0)
        {
            rb.velocity = new Vector3(0,0,moveY);
        }
        if(moveY == 0)
        {
            rb.velocity = new Vector3(moveX,0,0);
        }

        

    }
}


