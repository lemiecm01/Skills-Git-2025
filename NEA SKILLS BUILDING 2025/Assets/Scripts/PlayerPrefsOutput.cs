using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour {

	public TextMeshPro TxtOutput;

	// Use this for initialization
	void Start () {
		TxtOutput.text = PlayerPrefs.GetString ("WhichButtonClicked");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
