using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementtest : MonoBehaviour {

	private float speed = 5;

	// Update is called once per frame
	void Update () {

		var pos = transform.position;
		pos.x -= speed * Time.deltaTime;
		transform.position = pos;
	}
}
