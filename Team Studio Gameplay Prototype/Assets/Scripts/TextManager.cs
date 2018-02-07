﻿using System.Collections;
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


	// Use this for initialization
	void Start () {

		if (textFile != null) {
			textLines = (textFile.text.Split("\n"[0]));
		}

		if (endAtLine == 0) {
			endAtLine = textLines.Length - 1;
		}



	}


	
	// Update is called once per frame
	void Update () {
		theText.text = textLines [currentLine];

		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			currentLine += 1;
		}


		Debug.Log ("hmm");


		if (currentLine > endAtLine) {
			textBox.SetActive (false);
		}
	}
}
