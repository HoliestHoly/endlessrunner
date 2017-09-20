using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpScript : MonoBehaviour {
    
    public float jumpPower = 100f;
    public LayerMask mask;
    new private Rigidbody2D rigidbody;


    void Start ()
    {
        rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) && CanJump())
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpPower);
        }
    }

    bool CanJump()
    {
        return Physics2D.Raycast(transform.position, Vector2.down, 0.6f, mask);
    }

}
