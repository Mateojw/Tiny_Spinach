using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inside_Spotlight : MonoBehaviour {

	public float Spotlight_Meter = 0; // creating a float for spotlight meter
	bool Spotlight_Start; // creating a bool for the spotlight start

	// Use this for initialization
	void Start () {
		Spotlight_Start = false; // setting spotlight to be off
	}
	
	// Update is called once per frame
	void Update () {


	}

	void OnTriggerEnter2D(Collider2D col){  // if the spotlight has collided with any object
		if (col.gameObject.tag == "Spotlight_Object") { // if the object is a spotlight obvject

			Debug.Log ("YAY"); // log that the objects have collided
		}

	}
}
