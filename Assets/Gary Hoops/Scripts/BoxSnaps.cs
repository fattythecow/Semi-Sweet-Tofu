using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSnaps : MonoBehaviour {

	public GameObject empty;

	public float speed = 0f;

	public bool isIn = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay (Collider other)
	{
		if (other.tag == "Player") 
		{
			transform.Translate (speed * Time.deltaTime, 0, 0);
			//GetComponent<Rigidbody>().mass = 0;
		}

		if (other.name == "Snap") {
			isIn = true;
			transform.position = Vector3.MoveTowards (transform.position, empty.transform.position, speed * Time.deltaTime);
			gameObject.GetComponent<BoxCollider> ().enabled = false;
			gameObject.GetComponent<Rigidbody> ().useGravity = false;
		}

	}
}
