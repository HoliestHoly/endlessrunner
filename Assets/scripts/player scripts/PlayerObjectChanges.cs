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
	

	void Update () {
        //Checkt de Current playerstate
        var playerState = playerstateenum.playerState;

        if (playerState == PlayerStateEnum.PlayerStates.PlayerBall)
        {
            //verandert de box collider het rondje
            boxCollider.size = new Vector2(1.149944f, 1.149944f);
            boxCollider.offset = new Vector2(0.03f, 0.07f);
            //verandert de Mesh grootte en vorm van het rondje
            transform.localScale = new Vector2(1.149944f, 1.149944f);
            meshrenderer.mesh = _playerBall;
        }
        if (playerState == PlayerStateEnum.PlayerStates.PlayerSquare)
        {

            //verandert de box collider van het vierkant
            boxCollider.size = new Vector2(0.7001128f, 1f);
            boxCollider.offset = new Vector2(0.12f, 0.04f);
            //verandert de Mesh vorm naar het vierkant
            meshrenderer.mesh = _playerSquare;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                //verandert de Mesh grootte van het vierkant
                transform.localScale = new Vector2(0.7001128f, 0.5f);
            }
            else
            {
                //verandert de Mesh grootte voor crouch het "vierkant"
                transform.localScale = new Vector2(0.7001128f, 1.149944f);
            }
        }
        if (playerState == PlayerStateEnum.PlayerStates.PlayerTriangle)
        {
            //verandert de box collider van de driehoek
            boxCollider.size = new Vector2(1f, 3.7f);
            boxCollider.offset = new Vector2(1f, 2f);
            //verandert de Mesh grootte en vorm van en naar de driehoek
            meshrenderer.mesh = _playerTriangle;
            transform.localScale = new Vector2(0.3f, 0.3f);
        }

    }
}
//comment om te pushen