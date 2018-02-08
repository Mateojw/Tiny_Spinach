using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inside_Spotlight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
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
