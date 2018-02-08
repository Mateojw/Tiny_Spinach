using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Positioning : MonoBehaviour {

	public static bool Ice_Cream_Focus; // creating a public static bool for if the camera should be focused on icecream

	public GameObject Ice_Cream; // creatinga  public gameobejct for our icecream
	public GameObject Camera_Final_Position; // creating an object reference for our cameras final position

	public float Camera_Start_Size; // setting a camera start size
	public float Camera_Large_Size; // setting a camera to be at its largest size


	public SpriteRenderer Fader; // setting up a fader gameobject
	public Color Fader_Color_original; // settting up a fader color
	public Color Fader_Color_Final; // setting up a fader color for final


	public SpriteRenderer Cone; // creating a public gameobject for our icecream holder
	public SpriteRenderer Ice_Cream_Ball;
	public Color Ice_Cream_Color_ORiginal; // the original color of icecream
	public  Color Ice_Cream_Color_Final; // the final color of ice cream


	public float Zoom_Speed; // creatinga  public float for our zoom speed


	// Use this for initialization
	void Start () {
		Ice_Cream_Focus = true; // setting our camera to start on the icecream

		Fader.color = new Color (Fader_Color_original.r, Fader_Color_original.g, Fader_Color_original.b);  // setting our fader color at the start
		Cone.color = new Color (Ice_Cream_Color_ORiginal.r,Ice_Cream_Color_ORiginal.g,Ice_Cream_Color_ORiginal.b);
		Ice_Cream_Ball.color = new Color (Ice_Cream_Color_ORiginal.r,Ice_Cream_Color_ORiginal.g,Ice_Cream_Color_ORiginal.b);

		Fader.gameObject.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {

		if (Ice_Cream_Focus == true) { // if the camera is supposed to focus on ice cream

			transform.position = Vector3.Lerp (transform.position, new Vector3 (Ice_Cream.transform.position.x, Ice_Cream.transform.position.y, transform.position.z), Time.deltaTime * 1000); // lerp the camera to the icecreams position
			GetComponent<Camera>().orthographicSize = Camera_Start_Size;
		}

		if (Ice_Cream_Focus == false) { // checking to see if the caemra should not be focused on ice cream
//			transform.position = Vector3.Lerp (transform.position, new Vector3 (Camera_Final_Position.transform.position.x, Camera_Final_Position.transform.position.y, transform.position.z), Time.deltaTime * 2); // lerp the camera to the icecreams position
//			GetComponent<Camera>().orthographicSize = Mathf.Lerp(GetComponent<Camera>().orthographicSize,Camera_Large_Size,Time.deltaTime*20); // lerping our camera to the next size that we need it to be at
//
//			Fader.color = Color.Lerp (Fader.color, Fader_Color_Final, Time.deltaTime * 20);
			StartCoroutine(Zoom_Out()); // implementing our zoom out corouitne 

		}

	}


	IEnumerator Zoom_Out(){ // creating an IEnuemerator to establish a cutscene
		transform.position = Vector3.Lerp (transform.position, new Vector3 (Camera_Final_Position.transform.position.x, Camera_Final_Position.transform.position.y, transform.position.z), Time.deltaTime * 2); // lerp the camera to the icecreams position
		GetComponent<Camera>().orthographicSize = Mathf.Lerp(GetComponent<Camera>().orthographicSize,Camera_Large_Size,Time.deltaTime*Zoom_Speed); // lerping our camera to the next size that we need it to be at


		yield return new WaitForSeconds (1);
		Fader.color = Color.Lerp (Fader.color, Fader_Color_Final, Time.deltaTime * 20);

		yield return new WaitForSeconds (1);
		Cone.color = Color.Lerp (Cone.color, Ice_Cream_Color_Final, Time.deltaTime * 5);
		Ice_Cream_Ball.color = Color.Lerp (Ice_Cream_Ball.color, Ice_Cream_Color_Final, Time.deltaTime * 5);

		yield return new WaitForSeconds (0.5f);

		Destroy (Cone.gameObject); // destroying our ice cream cone
		Destroy (Ice_Cream_Ball.gameObject);

	}


}
