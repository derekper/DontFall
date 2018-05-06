using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FallCounter : MonoBehaviour {

    public static int falls;
    public Text fallText;

	// Use this for initialization
	void Start () {
        falls = 0;

	}
	
	// Update is called once per frame
	void Update () {
        string f = falls.ToString();
        fallText.text = "Falls: " + f;
	}
}
