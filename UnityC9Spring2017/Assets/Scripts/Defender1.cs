using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender1 : MonoBehaviour {

	//Instatiate Object to Hold the 2D Postion of Defender 1
	//Reference https://docs.unity3d.com/ScriptReference/Vector2.html
	Vector2 Def1Pos;

	//Instatiate a Body for Defender 1
	private Rigidbody2D Def1Body;


	// Use this for initialization
	void Start () {
		//Set Def1Body to the Body of the Current Object (aka Defender1)
		Def1Body = GetComponent<Rigidbody2D> ();
		//Set the postion to the current postion of Defender1
		Def1Pos = Def1Body.position;
		Def1Body.drag = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
		//Vector3 right = transform.TransformDirection (Vector3.right);
		//float curSpeed = speed * inputH;
		//if (Input.GetKey('d'))
		//	Def1Controller.SimpleMove (right * 5);

		float inputH = Input.GetAxis ("Horizontal");
		Debug.Log ("inputH = " + inputH);
		Def1Body.AddForce (transform.right * inputH * 2);
		//Def1Body.drag = 1;

		//if (inputH == 0)
		//	Def1Body.drag
		//	Def1Body.velocity = 0;

		//Vector2 force = transform.TransformDirection (force);
		//Def1Body.AddForce (force);
		//Vector3 right = transform.TransformDirection (Vector3.right);
		//float curSpeed = 5 * inputH;
		//Def1Body.p

	}

}
