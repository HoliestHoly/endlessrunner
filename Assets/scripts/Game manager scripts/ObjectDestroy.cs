using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour {



	

	void Update () { //destroys obstacles en zorgt dat er nooit minder/meer dan 5 objecten in het level zijn
		if (transform.position.x < -32) {
			Destroy (this.gameObject);
			GlobalVariables.obstaclesLive --;
			if (GlobalVariables.obstaclesLive < 5)
				GlobalVariables.spawnNow = true;
		}
	}
}
