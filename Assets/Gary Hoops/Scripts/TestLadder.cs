using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLadder : MonoBehaviour {

	public float speed = 2;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerStay(Collider other)
	{
		if (other.tag == "Player" && Input.GetKeyDown (KeyCode.J)) {
			other.GetComponent<Rigidbody> ().velocity = new Vector3 (0, speed);
		} 

		else if (other.tag == "Player" && Input.GetKeyDown (KeyCode.F)) 
		
		{
			other.GetComponent<Rigidbody> ().velocity = new Vector3 (0, -speed);

			Debug.Log ("test");
		} 

		else 
		
		{
			other.GetComponent<Rigidbody> ().velocity = new Vector3 (0, 1);
		}

	}

}
