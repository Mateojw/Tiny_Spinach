using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class inside_Spotlight : MonoBehaviour {

	public float Spotlight_Meter ; // creating a float for spotlight meter
	bool Spotlight_Start; // creating a bool for the spotlight start

	public Image Applause_Meter; // creating an image for our applause meter
	public float Max_Applause; // creatinga  public float for the max score a person could ger

	public Color BAD_APPLAUSE;
	public Color GOOD_APPLAUSE;

	// Use this for initialization
	void Start () {
		Spotlight_Start = false; // setting spotlight to be off
		Spotlight_Meter = Max_Applause/2; // setting our spoghtlight meter to be 0
	

	}
	
	// Update is called once per frame
	void Update () {

		if (Spotlight_Start == true && Spotlight_Meter < Max_Applause) { // checking to see if our spotlight start is on
			Spotlight_Meter += 1 * Time.deltaTime; // adding to our spotlight meter
		
		} else if(Spotlight_Meter > 0) {

			Spotlight_Meter -= .5f * Time.deltaTime; // subtracting from our spoghtlight meter
		}

		Applause_Meter.fillAmount = (Spotlight_Meter / Max_Applause); // making our meter increase appaluse
	
	
		if (Spotlight_Meter < Max_Applause/2) { // meter color change code
			Applause_Meter.color = Color.Lerp(Applause_Meter.color,new Color (BAD_APPLAUSE.r,BAD_APPLAUSE.g,BAD_APPLAUSE.b),Time.deltaTime); //lerping color

		} else {
			Applause_Meter.color = Color.Lerp(Applause_Meter.color,new Color (GOOD_APPLAUSE.r,GOOD_APPLAUSE.g,GOOD_APPLAUSE.b),Time.deltaTime); // lerping color

		}


	}

	void OnTriggerEnter2D(Collider2D col){  // if the spotlight has collided with any object
		if (col.gameObject.tag == "Spotlight_Object") { // if the object is a spotlight obvject

			Debug.Log ("YAY"); // log that the objects have collided
			Spotlight_Start = true; // setting spotlight start to be equal to true
		}

	

	}


	void OnTriggerExit2D(Collider2D col){  // if the spotlight has collided with any object
		if (col.gameObject.tag == "Spotlight_Object") { // if the object is a spotlight obvject

			Debug.Log ("BOO"); // log that the objects have collided
			Spotlight_Start = false; // setting spotlight start to be equal to false
		}



	}
}
