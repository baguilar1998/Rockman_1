using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegamanController : MonoBehaviour {

    Animator anim;
    SpriteRenderer sprite;
    float speed, axisX;
    bool flip;
    int jump;

	void Start () {
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        speed = 4f;
        flip = false;
        jump = 1250;
	}
	
    void MovePlayer()
    {
        //Moves the sprite left and right
        axisX = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
            anim.SetInteger("State", 2);
        }

        //Keeps track of key inputs to switch to certain animations
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetInteger("State", 1);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetInteger("State", 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetInteger("State", 1);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetInteger("State", 0);
        }

        //Flips the sprite depending on the direction it's going
        if (axisX <0.0f && flip ==false)Flip();
        else if(axisX > 0.0f && flip == true) Flip();

        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(axisX * speed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void Flip()
    {
        flip = !flip;
        sprite.flipX = flip;
    }

    void Jump()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jump);
    }

	// Update is called once per frame
	void Update () {
        MovePlayer();
    }
}
