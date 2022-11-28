using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 moveVector;
    private Animator anim;
    private SpriteRenderer sr;
    public Transform GroundCheck;
    public LayerMask Ground;
    public float checkRadius = 0.5f;
    private bool grounded;
    public float speed;
    public float jumpForce;  
    private int  jumpCount = 0;
    private int maxValueJump = 2;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }    
    void Update()
    {       
        float moveVector = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveVector * speed, rb.velocity.y); 
        Jump();
        Flip();
                    
        grounded = Physics2D.OverlapCircle(GroundCheck.position, checkRadius, Ground);

        anim.SetBool("Run", moveVector != 0);   
        anim.SetBool("grounded", grounded);      
    }
    void Jump()
    {
        if(Input.GetKey(KeyCode.Space) && grounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce); 
            anim.SetTrigger("Jump");          
        }
        
        if(Input.GetKeyDown(KeyCode.Space) && ++jumpCount < maxValueJump)
        {        
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);                                            
        }  

        if(grounded)
        {
            jumpCount = 0;
        }
        
    }
    void Flip()
    {
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            sr.flipX = false;
        }
        else if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))   
        {
            sr.flipX = true;
        }  
    }
}
