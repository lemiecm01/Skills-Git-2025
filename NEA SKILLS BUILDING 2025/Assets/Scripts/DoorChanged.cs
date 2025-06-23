using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorChanged : MonoBehaviour {

	public Sprite doorBlueStroked;
	public Sprite doorGreenStroke;
	public Sprite doorRedStroked;
	SpriteRenderer door;

	void Start (){
		door=GetComponent<SpriteRenderer> ();
	}


	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Alpha1))
		{
			door.sprite = doorBlueStroked;
		}
		else if(Input.GetKey (KeyCode.Alpha2))
		{
			door.sprite=doorGreenStroke;
		}
		else if(Input.GetKey (KeyCode.Alpha3))
		{
			door.sprite=doorRedStroked;
		}
	}
}
