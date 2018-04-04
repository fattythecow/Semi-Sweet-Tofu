using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_ImMagiGrounds : MonoBehaviour {

	[SerializeField]
	AudioClip darksoulsenter = null;

	// Use this for initialization
	void Start () {
		
	}

	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay(Collider other)
	{
		GameObject cam = GameObject.FindWithTag ("MainCamera");
		CJC_PopSmoke camera = cam.GetComponent<CJC_PopSmoke> ();

		if (other.tag == "Player")
		{
			//GetComponent<AudioSource> ().PlayOneShot (darksoulsenter);
			camera.InMagiArea = true;
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			GetComponent<AudioSource> ().PlayOneShot (darksoulsenter);
		}
	}

	void OnTriggerExit(Collider other)
	{
		GameObject cam = GameObject.FindWithTag ("MainCamera");
		CJC_PopSmoke camera = cam.GetComponent<CJC_PopSmoke> ();

		if (other.tag == "Player")
		{
			camera.InMagiArea = false;
		}
	}
}
