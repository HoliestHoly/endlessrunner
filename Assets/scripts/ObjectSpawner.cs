﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour 
{
	public GameObject[] obstacles;
	private float _lastSpawnTime;
	private Chunk _lastChunk;

	// Use this for initialization
	void Start () 
	{
		_lastSpawnTime = 1;
	}

	void Spawn ()
	{
		var randomObject = obstacles [Random.Range (0, obstacles.Length)]; // Pak een random object uit de array obstacles.

		Vector3 wantedPosition = new Vector3 (20, 0, 0); //  initaliseren een positie.

		if (_lastChunk != null) // als er wel een chunk is.
		{
			Vector3 offset = new Vector3 (_lastChunk.Size.width, 0);//_lastChunk.Size.height); // gewoon
			wantedPosition = _lastChunk.transform.position + offset; 
		}

		_lastSpawnTime = 1;
		var newchunk = Instantiate (randomObject, wantedPosition, Quaternion.identity);
		_lastChunk = newchunk.GetComponent<Chunk> ();
	}


	void LateUpdate () 
	{
		_lastSpawnTime -= Time.deltaTime;
		if (GlobalVariables.obstaclesLive < 7) {
			Spawn ();
			GlobalVariables.obstaclesLive++;
		}


			/*if (_lastSpawnTime <= 0)
			{
				Spawn();
			GlobalVariables.obstaclesLive ++;
			
			}
			*/
			if(GlobalVariables.spawnNow){
				Spawn();
			}
	
	}
}