using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeNotWorkingHard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		CJC_manageJump.candoubleJump = false;
		CJC_manageTeleport.KnowsTeleport = false;
	}
}
