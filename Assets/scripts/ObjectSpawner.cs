using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour 
{
	public GameObject[] obstacles;
	private float lastSpawnTime;
	private Chunk lastChunk;

	// Use this for initialization
	void Start () 
	{
		lastSpawnTime = 1;

		for (int i = 0; i < 4; i++) {
			Spawn ();
			GlobalVariables.obstaclesLive ++; //Spawned de eerste 4 chunks
		}
	}

	void Spawn ()
	{
		var randomObject = obstacles [Random.Range (0, obstacles.Length)]; // Pak een random object uit de array obstacles.

		Vector3 wantedPosition = new Vector3 (40, -5, 0); //  initaliseren een positie.

		if (lastChunk != null) // als er wel een chunk is.
		{
			Vector3 offset = new Vector3 (lastChunk.Size.width, 0);//lastChunk.Size.height); // zorgt dat de chunks netjes achter elkaar komen
			wantedPosition = lastChunk.transform.position + offset; 
		}

		lastSpawnTime = 1;
		var newchunk = Instantiate (randomObject, wantedPosition, Quaternion.identity); //Spawned het
		lastChunk = newchunk.GetComponent<Chunk> (); //veranderd de oude chunk in de nieuwe chunk

	}


	void LateUpdate () 
	{
		lastSpawnTime -= Time.deltaTime; //timer


			/*if (_lastSpawnTime <= 0)
			{
				Spawn();
			GlobalVariables.obstaclesLive ++;
			
			}
			*/
			if(GlobalVariables.spawnNow){  //Spawned een chunk en maakt het spel sneller
				Spawn();
				GlobalVariables.obstaclesLive ++;
				GlobalVariables.spawnNow = false;
				GlobalVariables.speed += 1f;
			}
	
	}
}