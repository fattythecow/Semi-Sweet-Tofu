using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll2 : MonoBehaviour {

	public GameObject Wall;

	public GameObject Thescroll;

	static public bool scroll2Pickedup = false;

	public float timer = 0;
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
			scroll2Pickedup = true;
			Destroy (Wall);
			Destroy (Thescroll);
		}
	}
}
