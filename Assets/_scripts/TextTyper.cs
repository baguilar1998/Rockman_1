using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;
using UnityEngine.Animations;

public class TextTyper : MonoBehaviour {

    public Text currentText;
    string displayText;

	// Use this for initialization
	void Start () {
        currentText = GetComponent<Text>();
        currentText.enabled = false;
        StartCoroutine(TypeText());
    }
	
    public IEnumerator TypeText()
    {
        //yield return new WaitForSeconds(3f);
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
	void Update () {}
}
