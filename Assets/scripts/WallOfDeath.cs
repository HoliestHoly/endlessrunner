﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallOfDeath : MonoBehaviour {

	void Start () 
	{
		
	}
	
	void Update() 
	{

	}

	void OnCollisionEnter(Collision col)
	{
		Destroy (col.gameObject);
	}

}

