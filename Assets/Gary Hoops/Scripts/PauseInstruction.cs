using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseInstruction : MonoBehaviour {


	[SerializeField]
	public float timer = 3;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, timer);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
