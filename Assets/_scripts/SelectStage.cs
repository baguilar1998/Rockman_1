﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectStage : MonoBehaviour {

    SpriteRenderer select;
    public AudioClip selectSound;
    AudioSource audioSource;

    private Vector3[] positions = {new Vector3(-1.673f, 2.978f, 0),
                                    new Vector3(1.62f, 2.96f, 0),
                                    new Vector3(2.97f, 0.33f, 0),
                                    new Vector3(1.62f, -2.69f, 0),
                                    new Vector3(-1.65f, -2.66f, 0),
                                    new Vector3(-3.03f, 0.33f, 0)};
    private int index = 0;

    public IEnumerator Flick()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            select.enabled = true; 
            yield return new WaitForSeconds(0.5f);
            select.enabled = false;

        }
    }

    // Use this for initialization
    void Start () {
        select = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(Flick());
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.D))
        {
            audioSource.Play();
            index++;
            if (index == 6) index = 0;
            select.transform.position = positions[index];
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            audioSource.Play();
            index--;
            if (index == -1) index = 5;
            select.transform.position = positions[index];
        }
		
	}
}