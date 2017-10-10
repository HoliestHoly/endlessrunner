using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateEnum : MonoBehaviour {

    public enum PlayerStates { PlayerBall, PlayerSquare, PlayerTriangle};
    public PlayerStates playerState;

    // Use this for initialization
    void Start () {
        playerState = PlayerStates.PlayerSquare;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerState = PlayerStates.PlayerSquare;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            playerState = PlayerStates.PlayerBall;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            playerState = PlayerStates.PlayerTriangle;
        }
    }
}
