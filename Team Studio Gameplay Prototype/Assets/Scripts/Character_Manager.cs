using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Manager : MonoBehaviour {
	
	public static bool IS_ROMEO; // creating a public static bool to see if is romeo = true

	public GameObject Romeo; // creatinga  public gameobject to reference our romeo character
	public GameObject Juliet; // creating a public cameobject ro reference our juliet character


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (IS_ROMEO) { // if the selected character is romeo
			Romeo.gameObject.tag = "Spotlight_Object"; // chanigng romeos tag
			Juliet.gameObject.tag = "Untagged"; // untagginf our juliet object

		} else { // if the selected character is not romeo

			Juliet.gameObject.tag = "Spotlight_Object"; // chanigng romeos tag
			Romeo.gameObject.tag = "Untagged"; // untagginf our juliet object
		}
		
	}
}
