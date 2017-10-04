using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObjectChanges : MonoBehaviour {

    public Mesh PlayerRondje;
    public Mesh PlayerSquare;
    public Mesh PlayerTree;
    private MeshFilter meshrenderer;
    // Use this for initialization
    void Start ()
    {
        meshrenderer = GetComponent<MeshFilter>();
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.S))
        {
            meshrenderer.mesh = PlayerRondje;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            meshrenderer.mesh = PlayerSquare;
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            meshrenderer.mesh = PlayerTree;
        }

    }
}
//comment om te pushen