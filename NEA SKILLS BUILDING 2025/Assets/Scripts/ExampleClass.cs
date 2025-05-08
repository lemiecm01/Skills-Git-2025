using UnityEngine;

public class ExampleClass : MonoBehaviour
{
	public Transform hero;
	public Vector3 offset;

	void Update () 
	{
		transform.position = new Vector3 (hero.position.x + offset.x, hero.position.y + offset.y, offset.z); // Camera follows the player with specified offset position
	}
}