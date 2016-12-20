using UnityEngine;
using System.Collections;

public class RepeatingBackground : MonoBehaviour {

	private BoxCollider2D groundCollider;
	private float groundHorizontalLength;

	// Use this for initialization
	void Start () {
		groundCollider = GetComponent<BoxCollider2D> ();
		groundHorizontalLength = 24.4f; //groundCollider.size.x;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < -groundHorizontalLength) {
			RepositionBackground ();
		}
	}

	private void RepositionBackground(){
		Vector2 groundOffset = new Vector2 (groundHorizontalLength * 2f, 0);
		transform.position = new Vector2(24.4f, transform.position.y); //(Vector2)transform.position + groundOffset;
		//Both Works - 
		//transform.position = (Vector2)transform.position + groundOffset;
	}
}
