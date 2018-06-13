using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {
    void Start()
    {
        print("game started");
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("Enter was pressed");
        }
	}
}
