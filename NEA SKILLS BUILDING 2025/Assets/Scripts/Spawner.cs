using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	public GameObject altar;
	public bool Spawned;
	public Vector3 SpawnedPosition;



	// Use this for initialization
	void Start () {
		Spawned = false;
		SpawnedPosition = new Vector3 (-5.07f, 3.73f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SpawnAltar()
	{
		if (Spawned==false)
		{
			Instantiate(altar,SpawnedPosition, Quaternion.identity);
			Spawned = true;
			Debug.Log("Alter Spawned");
		}
	}
}
