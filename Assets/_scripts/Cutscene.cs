using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene : MonoBehaviour {

    SpriteRenderer gameBackground;

	// Use this for initialization
	void Start () {
        gameBackground = GetComponent<SpriteRenderer>();
        StartCoroutine(FlickerFiveTimes());
    }
	
    public IEnumerator FlickerFiveTimes()
    {
        for(int i = 0; i < 5; ++i)
        {
            gameBackground.enabled = false;
            yield return new WaitForSeconds(0.1f);
            gameBackground.enabled = true;
            yield return new WaitForSeconds(0.1f);

        }
    }

	// Update is called once per frame
	void Update () {}
}
