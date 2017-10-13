using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLose : MonoBehaviour {

	// Use this for initialization
	private float timeLeft = 3f;
	
	// Update is called once per frame
	void Update () 
	{
		if (transform.position.y < -10)
		{
				timeLeft -= Time.deltaTime;
				if ( timeLeft < 0 )
				{
					SceneManager.LoadScene("Lose_Scene");
				}

		}
		if (GlobalVariables.playerLost) 
		{
			SceneManager.LoadScene("Lose_Scene");
		}
	}
}
