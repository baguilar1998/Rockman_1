using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flicker : MonoBehaviour {

    public Text select, start;
    public Color mainColor;

    public IEnumerator FlickText()
    {
        while(true)
        {
            yield return new WaitForSeconds(0.5f);
            select.color = Color.white;
            start.color = Color.white;
            yield return new WaitForSeconds(0.5f);
            select.color = mainColor;
            start.color = mainColor;
        }
    }

    // Use this for initialization
    void Start () {
        mainColor = select.color;
        StartCoroutine(FlickText());
    }
	
	// Update is called once per frame
	void Update () {
    }
}
