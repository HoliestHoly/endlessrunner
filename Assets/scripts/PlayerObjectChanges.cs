using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Director;

public class PlayerObjectChanges : MonoBehaviour {

    public Mesh _playerBall;
    public Mesh _playerSquare;
    public Mesh _playerTriangle;
    private MeshFilter meshrenderer;
    private BoxCollider2D boxCollider;

    private PlayerStateEnum playerstateenum;

    // Use this for initialization
    void Start ()
    {
        meshrenderer = GetComponent<MeshFilter>();
        boxCollider = GetComponent<BoxCollider2D>();
        playerstateenum = GetComponent<PlayerStateEnum>();

    }
	
	// Update is called once per frame
	void Update () {
        var playerState = playerstateenum.playerState;

        if (playerState == PlayerStateEnum.PlayerStates.PlayerBall)
        {
            boxCollider.size = new Vector2(1.149944f, 1.149944f);
            boxCollider.offset = new Vector2(0.03f, 0.07f);
            transform.localScale = new Vector2(1.149944f, 1.149944f);
            meshrenderer.mesh = _playerBall;           
        }
        if (playerState == PlayerStateEnum.PlayerStates.PlayerSquare)
        {
            meshrenderer.mesh = _playerSquare;
            boxCollider.size = new Vector2(0.7001128f, 1f);
            boxCollider.offset = new Vector2(0.12f, 0.04f);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.localScale = new Vector2(0.7001128f, 0.5f);
            }
            else
            {
                transform.localScale = new Vector2(0.7001128f, 1.149944f);
            }
        }
        if(playerState == PlayerStateEnum.PlayerStates.PlayerTriangle)
        {
            meshrenderer.mesh = _playerTriangle;
            transform.localScale = new Vector2(0.3f, 0.3f);
            boxCollider.size = new Vector2(1f, 3.7f);
            boxCollider.offset = new Vector2(1f, 2f);
        }

    }
}
//comment om te pushen