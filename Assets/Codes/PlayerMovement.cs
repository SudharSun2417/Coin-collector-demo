using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float player_Speed;
    public Rigidbody2D rb;  
    public Animator animator;
    float mx;
    public Transform feet;
    public LayerMask ground;
    public float jumpforce;
    public SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
       mx = Input.GetAxisRaw("Horizontal");
       Vector2 movement = new Vector2(mx * player_Speed, rb.velocity.y);
       rb.velocity = movement;
       animator.SetBool("grounded", isGrounded());
       if(Input.GetButtonDown("Jump") && isGrounded())
       {
           Jump();
       }
       if(Mathf.Abs(mx)>0.06) 
       {
           animator.SetBool("isRunning",true);
       }
       else 
       {
           animator.SetBool("isRunning",false);
       }
       if(mx>0)
       {
           sr.flipX = false;
       }
       else if(mx<0)
       {
           sr.flipX = true;
       }
        
    }
    void Jump()
    {
        Vector2 movement = new Vector2(rb.velocity.x, jumpforce);
        rb.velocity = movement;
    }
    public bool isGrounded()
    {
        Collider2D ground_Check = Physics2D.OverlapCircle(feet.position,0.6f,ground);
        if(ground_Check != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
