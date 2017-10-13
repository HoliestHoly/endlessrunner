using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {




	void Update () { //laat dingen bewegen

		var pos = transform.position;
		pos.x -= GlobalVariables.speed * Time.deltaTime;
		transform.position = pos; 
	}
}
