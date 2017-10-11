using System.Collections;
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
            transform.localScale = new Vector3(1.149944f, 1.149944f, 1);
            meshrenderer.mesh = _playerBall;           
        }
        if (playerState == PlayerStateEnum.PlayerStates.PlayerSquare)
        {
            meshrenderer.mesh = _playerSquare;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.localScale = new Vector3(0.7001128f, 0.5f, 1);
            }
            else
            {
                transform.localScale = new Vector3(0.7001128f, 1.149944f, 1);
            }
            //if (Input.GetKeyUp(KeyCode.LeftShift))
            //{
            //    transform.localScale = new Vector3(0.7001128f, 1.149944f, 1);
            //}
        }
        if(playerState == PlayerStateEnum.PlayerStates.PlayerTriangle)
        {
            meshrenderer.mesh = _playerTriangle;
            transform.localScale = new Vector3(0.7001128f, 0.75f, 1);
        }

    }
}
//comment om te pushen