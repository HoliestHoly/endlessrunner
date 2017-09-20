using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour 
{
	public GameObject _Obstacle1;
	private float lastSpawnTime;

	// Use this for initialization
	void Start () 
	{
		lastSpawnTime = 1;
	}



	void Spawn ()
	{
		lastSpawnTime = 1;
		Instantiate (_Obstacle1, new Vector3 (20, 0, 0), Quaternion.identity);
	}


	void Update () 
	{
		lastSpawnTime -= Time.deltaTime;
		if(lastSpawnTime <= 0)
			Spawn ();
	}
}