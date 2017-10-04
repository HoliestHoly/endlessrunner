using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour 
{
	[SerializeField] Rect size;

	public Rect Size { get { return size; } }

	void OnDrawGizmos() 
	{
		Vector3 middle = new Vector3 (transform.position.x + size.x + (size.width / 2), 
			transform.position.y + size.y + (size.height / 2));
		Vector3 gizmosSize = new Vector3 (size.width, size.height, 1);
		Gizmos.color = Color.green;
		Gizmos.DrawWireCube (middle, gizmosSize);
	}
}
