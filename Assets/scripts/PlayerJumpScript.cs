using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpScript : MonoBehaviour {

    public float jumpPower = 100f;
    private int doubleJump = 0;
    public LayerMask mask;
    new private Rigidbody2D rigidbody;

    private PlayerStateEnum playerstateenum;


    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        playerstateenum = GetComponent<PlayerStateEnum>();
    }

    // Update is called once per frame
    void Update()
    {
        var playerState = playerstateenum.playerState;



        
        if (doubleJump == 1 && playerState == PlayerStateEnum.PlayerStates.PlayerTriangle)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpPower);
                doubleJump = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && CanJump())
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpPower);
            doubleJump = 1;

        }

    }

    bool CanJump()
    {
        return Physics2D.Raycast(transform.position, Vector2.down, 0.6f, mask);
    }

}
