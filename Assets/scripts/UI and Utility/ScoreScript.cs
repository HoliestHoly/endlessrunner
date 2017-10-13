using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreScript : MonoBehaviour {

    Text txt;
    private static int intScore;
    private float floatScore = 0;
    private float speed = GlobalVariables.speed;
    
    void Start () {
        txt = gameObject.GetComponent<Text>();
    }
	
	void Update () {
        //berekent de score
        floatScore = floatScore + 0.06f * speed;
        //zet de score over naar int
        intScore = Mathf.RoundToInt(floatScore);

        //saves de score
        PlayerPrefs.SetInt("Player Score", intScore);

        //veranderd de text 
        txt.text = "Score : " + intScore;
    }
}
