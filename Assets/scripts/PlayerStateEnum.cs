using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateEnum : MonoBehaviour {

    //enum voor de PlayerStates
    public enum PlayerStates { PlayerBall, PlayerSquare, PlayerTriangle};
    public PlayerStates playerState;

    // Use this for initialization
    void Start () {
        //zet de playerstate naar PlayerSquare
        playerState = PlayerStates.PlayerSquare;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //verandert de playerstate naar PlayerBall als je "A" klikt
            playerState = PlayerStates.PlayerSquare;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            //verandert de playerstate naar PlayerBall als je "S" klikt
            playerState = PlayerStates.PlayerBall;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            //verandert de playerstate naar PlayerTriangle als je "D" klikt
            playerState = PlayerStates.PlayerTriangle;
        }
    }
}
