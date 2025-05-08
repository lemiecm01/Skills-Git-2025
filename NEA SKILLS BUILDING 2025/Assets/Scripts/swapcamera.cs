using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swapcamera : MonoBehaviour {

	public Camera minimap;
	public Camera Maincamera;

	void update(){
		if (Input.GetKey (KeyCode.M)) {
			Maincamera.enabled = false;
			minimap.enabled = true;
		} else if (Input.GetKey (KeyCode.N)) {
			Maincamera.enabled = true;
			minimap.enabled = false;
		}
	}
}
