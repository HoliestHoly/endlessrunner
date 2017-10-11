using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementtest : MonoBehaviour {



	// Update is called once per frame
	void Update () {

		var pos = transform.position;
		pos.x -= GlobalVariables.speed * Time.deltaTime;
		transform.position = pos;
	}
}
