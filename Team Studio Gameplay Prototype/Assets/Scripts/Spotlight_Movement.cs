using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spotlight_Movement : MonoBehaviour {
	public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate (Input.acceleration.x, Input.acceleration.y, 0); // moving our object using the gyroscope
		//transform.Translate (Input.acceleration.x, 0, 0); // no y
		//rb.AddForce(new Vector2(Input.acceleration.x/10, 0));
	}
}
