using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody2D rb;
    public int speed;
    public int jumpForce;
    public bool grounded;

    public StateManager stateManage;

    public MusicManager music;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKeyDown(KeyCode.Space))
        // {
        //     if(grounded){
        //         Jump();
        //     }
        // }

        // for AnDroid
        if(Input.touchCount > 0)
        {
            if(grounded){
                Jump();
            }
        }
        
    }

    void FixedUpdate(){
        if(stateManage.state == "Playing"){
            // rb.gravityScale = 3;
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        else{
            // rb.gravityScale = 0;
            rb.velocity = Vector2.zero;
        }
        
    }

    public void ResetGravity(int x){
        rb.gravityScale = x;
    }

    public void Jump()
    {
        music.PlayJump();
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);

    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Ground")){
            grounded = true;
        } 
        
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Ground")){
            grounded = false;
        }
    }





}
