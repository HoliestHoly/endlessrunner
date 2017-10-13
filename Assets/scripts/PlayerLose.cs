using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLose : MonoBehaviour {


	private float timeLeft = 2f;
	

	void Update () //als de speler uit de map valt dan gaat het spel naar een lose screen na een timer van 2 seconde
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
