using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class TextDisappear : MonoBehaviour {


	public GameObject text;

	public GameObject text2;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () 
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();
	}

	void OnTriggerStay (Collider other)
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();
		GameObject pj = GameObject.FindWithTag ("Player");
		CJC_tryjumping jump = pj.GetComponent<CJC_tryjumping> ();
		

		if (other.gameObject.tag == "Player")
		{
			text.SetActive (true);

			if (jump.AlreadyInAir == false && player.IsSprinting == false) {
				if (Input.GetKeyDown (KeyCode.Q) | Input.GetButtonDown ("360_YButton") | Input.GetButtonDown ("ps4_TriangleButton")) {
					if (text.gameObject.activeInHierarchy) {
						text.SetActive (false);
					} 
					if (text2 != null) {
						text2.SetActive (true);
					}

					if (text2.gameObject.activeInHierarchy && text2 != null) {
						Destroy (text2.gameObject, 6.0f);
					}
				}
			}
		}


	}




}

