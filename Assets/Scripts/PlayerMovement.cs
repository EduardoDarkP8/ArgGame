using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rg;
    SpriteRenderer sr;
    public float velocity = 2f;
    float x, y;
    Animator animator;
    public Animator follow;
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        animator.SetInteger("Horizontal",(int)x);
        if (x > 0) 
        {
            sr.flipX = false;
        }
        else if (x < 0) 
        {
            sr.flipX = true;
        }
    }
    private void FixedUpdate()
    {
        rg.velocity = new Vector3(x * velocity, rg.velocity.y);
    }
}
