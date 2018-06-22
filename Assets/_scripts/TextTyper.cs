using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;

public class TextTyper : MonoBehaviour {

    public Text currentText;
    string displayText;
    public AudioSource audio;

	// Use this for initialization
	void Start () {
        currentText = GetComponent<Text>();
        audio = gameObject.GetComponent<AudioSource>();
        currentText.enabled = false;
        audio.Play();
        StartCoroutine(TypeText());
    }
	
    public IEnumerator TypeText()
    {
        
        if (currentText.text.Equals("Cutman"))
        {
            yield return new WaitForSeconds(3f);
            currentText.enabled = true;
            currentText.text = "";
            displayText = "Cutman";
            for(int i = 0; i < displayText.Length; ++i)
            {
                yield return new WaitForSeconds(0.2f);
                currentText.text = currentText.text + displayText.Substring(i, 1);
            }
            
        }

        if (currentText.text.Equals("Gutsman"))
        {
            yield return new WaitForSeconds(2f);
            currentText.enabled = true;
            currentText.text = "";
            displayText = "Gutsman";
            for (int i = 0; i < displayText.Length; ++i)
            {
                yield return new WaitForSeconds(0.2f);
                currentText.text = currentText.text + displayText.Substring(i, 1);
            }

        }

        if (currentText.text.Equals("Iceman"))
        {
            yield return new WaitForSeconds(3f);
            currentText.enabled = true;
            currentText.text = "";
            displayText = "Iceman";
            for(int i=0; i < displayText.Length; ++i)
            {
                yield return new WaitForSeconds(0.2f);
                currentText.text = currentText.text + displayText.Substring(i, 1);
            }
        }

        if (currentText.text.Equals("Bombman"))
        {
            yield return new WaitForSeconds(2.3f);
            currentText.enabled = true;
            currentText.text = "";
            displayText = "Bombman";
            for (int i = 0; i < displayText.Length; ++i)
            {
                yield return new WaitForSeconds(0.2f);
                currentText.text = currentText.text + displayText.Substring(i, 1);
            }
        }

        if (currentText.text.Equals("Fireman"))
        {
            yield return new WaitForSeconds(3f);
            currentText.enabled = true;
            currentText.text = "";
            displayText = "Fireman";
            for (int i = 0; i < displayText.Length; ++i)
            {
                yield return new WaitForSeconds(0.2f);
                currentText.text = currentText.text + displayText.Substring(i, 1);
            }
        }

        if (currentText.text.Equals("Elecman"))
        {
            yield return new WaitForSeconds(2f);
            currentText.enabled = true;
            currentText.text = "";
            displayText = "Elecman";
            for (int i = 0; i < displayText.Length; ++i)
            {
                yield return new WaitForSeconds(0.2f);
                currentText.text = currentText.text + displayText.Substring(i, 1);
            }
        }


    }

	// Update is called once per frame
	void Update () {

         if (audio.isPlaying == false)
         {
            SceneManager.LoadScene(currentText.text.ToLower() + "_stage");
         }

    }
}
