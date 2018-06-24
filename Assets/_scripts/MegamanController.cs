using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegamanController : MonoBehaviour {

    Animator anim;
    SpriteRenderer sprite;
    float speed, axisX;
    bool flip,isJumping;
    int jump;

	void Start () {
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        speed = 4f;
        flip = isJumping = false;
        jump = 1200;
	}
	
    private void MovePlayer()
    {
        //Moves the sprite left and right
        axisX = Input.GetAxis("Horizontal");


        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
            Jump();
            anim.SetTrigger("Jump");
        }
        else if (!isJumping)
        {
            AnimationStates();
        }


        //Flips the sprite depending on the direction it's going
        if (axisX <0.0f && flip ==false)Flip();
        else if(axisX > 0.0f && flip == true) Flip();

        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(axisX * speed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    private void Flip()
    {
        flip = !flip;
        sprite.flipX = flip;
    }

    private void Jump()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jump);
    }

    private void AnimationStates()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("Walk");
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetTrigger("Idle");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("Walk");
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetTrigger("Idle");
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            anim.SetTrigger("Shoot");
        }
        else if (Input.GetKeyUp(KeyCode.K))
        {
            anim.SetTrigger("Idle");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isJumping)isJumping = !isJumping;
    }

    // Update is called once per frame
    void Update () {
        MovePlayer();
    }
}
