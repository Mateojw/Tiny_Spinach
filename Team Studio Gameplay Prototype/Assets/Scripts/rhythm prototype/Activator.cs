using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour {

	public KeyCode key;
	bool active = false;
	GameObject note;
	public GameObject Particle;
	bool longnote;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(key)&&active){
			Destroy(note);
		}
		if (Input.GetKeyDown(key)&&active){
			
			Particle = Instantiate (Particle, transform.position, transform.rotation);
		}
		if(Input.GetKeyUp(key)&& longnote){
			DestroyImmediate (Particle, true);
			longnote = false;
			
		}
	}
	void OnTriggerEnter2D(Collider2D col){
		Debug.Log ("enter");
		active=true;
		if (col.gameObject.tag == "Note") {
			note = col.gameObject;
		}

		if (col.gameObject.tag == "longNote") {
			longnote = true;

		}


	}

	void OnTrigerExit2D(Collider2D col){
		Debug.Log ("exit");
		active = false;
	
	}
}
