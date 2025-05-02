using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void Dinoscene(){
		Debug.Log ("Button A Clicked!");
		SceneManager.LoadScene ("Animations");
	}
	public void tutorialevel(){
		Debug.Log ("Button B Clicked!");
		SceneManager.LoadScene ("Levels Tutorial");
	}
	public void Enemyscene(){
		Debug.Log ("Button C Clicked!");
		SceneManager.LoadScene ("enemy");
	}
	public void Navigation(){
		Debug.Log ("Button D Clicked!");
		SceneManager.LoadScene ("Navigation");
	}

	public void menubutton(){
		Debug.Log ("button menu clicked!");
		SceneManager.LoadScene ("Menu");
	}
}

