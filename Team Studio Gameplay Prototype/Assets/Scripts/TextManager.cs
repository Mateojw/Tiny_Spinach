using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {
	public GameObject textBox;
	public Text theText;
	public TextAsset textFile;
	public string[] textLines;
	public int currentLine;
	public int endAtLine;
	private Ice_Cream_Collide My_Ice_Cream_Collide;



	// Use this for initialization
	void Start () {

		if (textFile != null) {
			textLines = (textFile.text.Split("\n"[0]));
		}

		if (endAtLine == 0) {
			endAtLine = textLines.Length - 1;
		}

		My_Ice_Cream_Collide = GameObject.Find ("Ground").GetComponent<Ice_Cream_Collide> ();

	}


	
	// Update is called once per frame
	void Update () {
		theText.text = textLines [currentLine];

		if (Input.GetKeyDown (KeyCode.Mouse0) && currentLine < endAtLine ) {
			currentLine += 1;
			}
			
		Debug.Log (My_Ice_Cream_Collide.Grounded);
		if (My_Ice_Cream_Collide.Grounded == true && currentLine < 4) {
			currentLine = 4;
		}
			if (Input.GetKeyDown (KeyCode.Mouse0) && currentLine >= 4) {
				currentLine += 1;
			}


		}

		//if (currentLine > endAtLine) {
			//textBox.SetActive (false);
		//}


}
