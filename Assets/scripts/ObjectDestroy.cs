using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour {



	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < -25) {
			Destroy (this.gameObject);
			GlobalVariables.obstaclesLive --;
			if (GlobalVariables.obstaclesLive < 5)
				GlobalVariables.spawnNow = true;
		}
	}
}
