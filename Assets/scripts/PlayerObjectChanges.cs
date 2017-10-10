﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Director;

public class PlayerObjectChanges : MonoBehaviour {

    public Mesh _playerBall;
    public Mesh _playerSquare;
    public Mesh _playerTriangle;
    private MeshFilter meshrenderer;

    private PlayerStateEnum playerstateenum;

    // Use this for initialization
    void Start ()
    {
        GameObject thePlayer = GameObject.Find("GameManager");
        meshrenderer = GetComponent<MeshFilter>();
        playerstateenum = GetComponent<PlayerStateEnum>();

    }
	
	// Update is called once per frame
	void Update () {
        var playerState = playerstateenum.playerState;

        if (playerState == PlayerStateEnum.PlayerStates.PlayerBall)
        {
            meshrenderer.mesh = _playerBall;
        }
        if (playerState == PlayerStateEnum.PlayerStates.PlayerSquare)
        {
            meshrenderer.mesh = _playerSquare;
        }
        if(playerState == PlayerStateEnum.PlayerStates.PlayerTriangle)
        {
            meshrenderer.mesh = _playerTriangle;
        }

    }
}
//comment om te pushen