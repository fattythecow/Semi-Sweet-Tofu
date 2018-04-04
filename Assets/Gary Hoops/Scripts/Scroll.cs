using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {

	public GameObject Wall;

	public GameObject Thescroll;

	static public bool scrollPickedup = false;

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
			scrollPickedup = true;
			Destroy (Wall);
			Destroy (Thescroll);
		}
	}
}
