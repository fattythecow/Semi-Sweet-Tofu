using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll4ass : MonoBehaviour {
	
	public GameObject Wall;

	public GameObject Thescroll;

	static public bool scroll4Pickedup = false;
	[SerializeField]
	GameObject musicAnimHolder = null;
	private Animator musicanim;
	bool levelcompleted;

	// Use this for initialization
	void Start () {
		musicanim = musicAnimHolder.GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {

	}


	void OnTriggerEnter (Collider other){

		if (other.tag == "Player"){
			musicanim.SetBool ("LevelCompleted", true);
			scroll4Pickedup = true;
			Destroy (Wall);
			Destroy (Thescroll);
		}
	}
}
