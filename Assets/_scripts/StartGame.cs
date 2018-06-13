using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class StartGame : MonoBehaviour {

    public Text changeText;

    void Start()
    {
       //nothing happens
    }

    public IEnumerator FlickerText()
    {
        for (int i = 0; i < 6; ++i)
        {
            changeText.color = Color.black;
            yield return new WaitForSeconds(0.1f);
            changeText.color = Color.white;
            yield return new WaitForSeconds(0.1f);
        }
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartCoroutine(FlickerText());
        }
	}
}
