using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Touch_To_Start : MonoBehaviour {

	public Spotlight_Movement Start_Spoghtlight;
	public inside_Spotlight Start_Meter;
	public Note Start_Note;

	public GameObject Start_Text;

	// Use this for initialization
	void Start () {
		Start_Spoghtlight.enabled = false;
		Start_Meter.enabled = false;
		Start_Note.enabled = false;
		Start_Text.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButton (0)) { // if the mouse button is down once
			Start_Spoghtlight.enabled = true; // start the spoghtlight movemnet
			Start_Meter.enabled = true; // start meter 
			Start_Note.enabled = true; // start notes

			Start_Text.SetActive (false);
			Destroy (GetComponent<Touch_To_Start> ());
		}
		
	}


}
