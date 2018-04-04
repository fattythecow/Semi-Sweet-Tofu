using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour {

	public Rigidbody platform;

	public float fallTime;


	// Use this for initialization
	void Start () 
	{
		platform = GetComponent<Rigidbody> ();
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.GetComponent<Collider>().CompareTag("Player")) {
			StartCoroutine (Drop ());
		}
	}


	IEnumerator Drop()
	{
		yield return new WaitForSeconds (fallTime);
		platform.isKinematic = false;
		GetComponent<Collider> ().isTrigger = true;
		yield return 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
