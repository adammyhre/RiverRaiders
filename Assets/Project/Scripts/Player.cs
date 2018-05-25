using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float horizontalSpeed = 3f;
	public float verticalSpeed = 1f;
	public float horizontalLimit = 2.8f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Move the plater
		GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal") * horizontalSpeed, verticalSpeed);
		if (transform.position.x > horizontalLimit) {
			transform.position = new Vector2 (horizontalLimit, transform.position.y);
		} else if (transform.position.x < -horizontalLimit) {
			transform.position = new Vector2 (-horizontalLimit, transform.position.y);
		}
		
	}
}
