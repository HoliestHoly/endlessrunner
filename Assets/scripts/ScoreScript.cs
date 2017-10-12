using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreScript : MonoBehaviour {

    Text txt;
    private int intScore;
    private float floatScore = 0;
    private float speed = GlobalVariables.speed; 

    // Use this for initialization
    void Start () {

        txt = gameObject.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        floatScore = floatScore + 0.03f * speed;
        intScore = Mathf.RoundToInt(floatScore);

        txt.text = "Score : " + intScore;
    }
}
