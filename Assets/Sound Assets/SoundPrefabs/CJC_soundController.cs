using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_soundController : MonoBehaviour {

	[SerializeField]
	GameObject PlayerAnimHolder = null;
	private Animator characteranim;
	bool gitdeaded;

	// Use this for initialization
	void Start () {
		characteranim = PlayerAnimHolder.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		GameObject jumpp = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = jumpp.GetComponent<CJC_PlayerAndBools> ();

		if (player.PlayerDied)
		{
			gitdeaded = true;
		}

		if (gitdeaded)
		{
			characteranim.SetBool ("TofuKilled", true);
		}
	}
}
