using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpacityChange : MonoBehaviour {

	public float alphaLevel1 = 1f;
	public float alphaLevel2 = 1f;
	public float alphaLevel3 = 1f;
	public float ControllValue = 0;

	public SpriteRenderer Color1;
	public SpriteRenderer Color2;
	public SpriteRenderer Color3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (ControllValue);
		if  (Input.acceleration.x < -.4 ) {
			ControllValue -= .01f;
		}
		if  (Input.acceleration.x > .4 ) {
			ControllValue += .01f;
		}

		if (ControllValue < -3) {
			ControllValue = -3;
		}
			
		if (ControllValue > 0) {
			ControllValue = 0;
		}
		if (ControllValue < 0 && ControllValue > -1) {

				if  (Input.acceleration.x > .2 ) {
				alphaLevel1 += .01f;
					}

				if  (Input.acceleration.x < -.2 ) {
				alphaLevel1 -= .01f;
					}
		}

		if (ControllValue < -1 && ControllValue > -2) {

				if  (Input.acceleration.x > .2 ) {
				alphaLevel2 += .01f;
					}

				if  (Input.acceleration.x < -.2 ) {
				alphaLevel2 -= .01f;
					}

		}

		if (ControllValue < -2 && ControllValue > -3) {

				if  (Input.acceleration.x > .2 ) {
				alphaLevel3 += .01f;
				}

				if  (Input.acceleration.x < -.2 ) {
				alphaLevel3 -= .01f;
				}

		}
	

		Color1.color = new Color (1, 1, 1, alphaLevel1);
		Color2.color = new Color (1, 1, 1, alphaLevel2);
		Color3.color = new Color (1, 1, 1, alphaLevel3);

	}
}
