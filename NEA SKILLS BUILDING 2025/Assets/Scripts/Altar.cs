using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Altar : MonoBehaviour {
	// Use this for initialization

	void Start () {
	}
	// Update is called once per frame
	void Update () {
	}

private void OnCollisionEnter2D(Collision2D other)

	{
		if (SceneManager.GetActiveScene ().name == "Levels Tutorial" && other.gameObject.tag == "Player") {
			SceneManager.LoadScene ("Level 2");
		} 
		else
		{
			SceneManager.LoadScene("Won");
		}
}
}