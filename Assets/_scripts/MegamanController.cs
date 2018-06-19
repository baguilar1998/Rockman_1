using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegamanController : MonoBehaviour {

    Animator anim;
    SpriteRenderer sprite;
    private float speed;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        speed = 4f;
	}
	
	// Update is called once per frame
	void Update () {

        float axisX = Input.GetAxis("Horizontal");
        //float axisY = Input.GetAxis("Vertical");

        sprite.transform.Translate(new Vector2(axisX, 0) * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetInteger("State", 1);
            sprite.flipX = false;
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetInteger("State", 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetInteger("State", 1);
            sprite.flipX = true;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetInteger("State", 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetInteger("State", 2);
        }else if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetInteger("State", 0);
        }
        
    }
}
