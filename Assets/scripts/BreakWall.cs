﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakWall : MonoBehaviour {


    private PlayerStateEnum playerstateenum;

    // Use this for initialization
    void Start () {
        playerstateenum = GetComponent<PlayerStateEnum>();
    }
	
	// Update is called once per frame
	void Update () {
        var playerState = playerstateenum.playerState;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        var playerState = playerstateenum.playerState;
		if (other.gameObject.tag == "BreakableWall" && playerState == PlayerStateEnum.PlayerStates.PlayerBall)
		{

			Destroy (other.gameObject);
		} 
		else if (other.gameObject.tag == "BreakableWall" && playerState == PlayerStateEnum.PlayerStates.PlayerSquare) 
		{
			GlobalVariables.playerLost = true;
		}
		else if (other.gameObject.tag == "BreakableWall" && playerState == PlayerStateEnum.PlayerStates.PlayerTriangle) 
		{
			GlobalVariables.playerLost = true;
		}
    }

}
