using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GH_FallingPlatform : MonoBehaviour 
{

	private Rigidbody rb3d;
	public float FallDelay;
	public float destroyTime = 1.0f;


	//public Transform shakingObject;

	// Use this for initialization
	void Start () 
	{
		rb3d = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () 
	{

	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == ("Player")) 
		{
			StartCoroutine (Fall ());
			Destroy (gameObject, destroyTime);
		}
	}
	IEnumerator Fall()
	{
		yield return new WaitForSeconds (FallDelay);
		rb3d.isKinematic = false;
		yield return 0;
	}

}