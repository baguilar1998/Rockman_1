using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

    public Text changeText;
    public AudioClip impact;
    AudioSource audioSource;

    void Start()
    {
        //nothing happens
        audioSource = GetComponent<AudioSource>();
    }

    public IEnumerator Transition()
    {
        audioSource.Play();
        for (int i = 0; i < 6; ++i)
        {
            changeText.color = Color.black;
            yield return new WaitForSeconds(0.1f);
            changeText.color = Color.white;
            yield return new WaitForSeconds(0.1f);
        }
        SceneManager.LoadScene("stage_select");
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartCoroutine(Transition());
            
        }
	}
}
