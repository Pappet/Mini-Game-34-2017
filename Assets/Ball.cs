using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	bool isClicking = false;
	float thrust = 20f;

	Vector3 dir;
	Vector3 startPos;
	Vector3 stopPos;
	Camera cam;
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		cam = Camera.main;
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		float kH = Input.GetAxis("Horizontal");
		float kV = Input.GetAxis("Vertical");

		Vector3 move = new Vector3(kH,kV,0);

		dir = (transform.position - move).normalized;

		rb.AddForce(dir * thrust);
	}

}
