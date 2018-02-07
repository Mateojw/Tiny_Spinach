using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice_Cream_Collide : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col){ // if the ground has collided with any obejct
		if (col.gameObject.name == "Ice_Cream") { // if the ground has collided with ice cream

			Debug.Log ("Ground");

			Camera_Positioning.Ice_Cream_Focus = false; // telling the camera to no longer focus on ice cream
		}

	}
}
