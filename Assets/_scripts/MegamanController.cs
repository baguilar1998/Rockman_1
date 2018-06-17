using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegamanController : MonoBehaviour {

    Animator anim;
    SpriteRenderer sprite;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
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
    }
}
