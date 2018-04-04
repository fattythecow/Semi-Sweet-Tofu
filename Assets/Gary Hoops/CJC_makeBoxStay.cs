using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_makeBoxStay : MonoBehaviour {

	[SerializeField]
	GameObject box;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject == box)
		{
			other.transform.position = gameObject.transform.position;
			other.GetComponent<Rigidbody> ().useGravity = false;
			Debug.Log ("making box stay");
		}
	}

	void OnTriggerStay(Collider other)
	{
		if (other.gameObject == box)
		{
			other.transform.position = gameObject.transform.position;
			other.GetComponent<Rigidbody> ().useGravity = false;
			Debug.Log ("making box stay");
		}
	}
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject == box)
		{
			other.transform.position = gameObject.transform.position;
			other.GetComponent<Rigidbody> ().useGravity = false;
			Debug.Log ("making box stay");
		}
	}
}
