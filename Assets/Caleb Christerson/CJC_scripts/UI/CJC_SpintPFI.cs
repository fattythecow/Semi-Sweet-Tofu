using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_SpintPFI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<MeshRenderer> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools damage = p1.GetComponent<CJC_PlayerAndBools> ();

		if (damage.IsSprinting == true) 
		{
			//gameObject.GetComponent<MeshRenderer> ().enabled = true;
		}
		else if (damage.IsSprinting == false) 
		{
			//gameObject.GetComponent<MeshRenderer> ().enabled = false;
		}
	}
}
