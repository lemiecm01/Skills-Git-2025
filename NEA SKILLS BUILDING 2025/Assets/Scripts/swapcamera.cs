using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swapcamera : MonoBehaviour {

	public Camera Minimap;
	public Camera Maincamera;

	void Update(){
		if (Input.GetKeyDown (KeyCode.C)) {
			Maincamera.enabled = true;
			Minimap.enabled = false;
		}
		if (Input.GetKeyDown (KeyCode.M)) {
			Maincamera.enabled = false;
			Minimap.enabled = true;
		}
	}

}
