using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryToGITGUDAI : MonoBehaviour {


	private float timePassed = 0;

	// Use this for initialization
	void Start () {
		ResetTimeSinceLastTransition ();
	}
	
	// Update is called once per frame
	void Update () {
		timePassed += Time.deltaTime;
	}

	public void ResetTimeSinceLastTransition () {
		timePassed = 0;
	}
}
