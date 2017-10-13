using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameOverScore : MonoBehaviour {

    Text txt;

    void Start () {
        txt = gameObject.GetComponent<Text>();
    }
	

	void Update () {
        //zet de score naar de score uit de vorige scene
        txt.text = "Score : " + PlayerPrefs.GetInt("Player Score");
    }
}
