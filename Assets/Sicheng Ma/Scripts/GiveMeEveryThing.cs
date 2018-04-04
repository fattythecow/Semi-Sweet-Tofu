using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveMeEveryThing : MonoBehaviour {

	public GameObject num1;

	public GameObject num2;

	public GameObject num3;

	public GameObject button1;

	public GameObject button2;

	// Use this for initialization
	void Start () {
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		if (player.RestartLevel == "PieSlice2") {
			num1.SetActive (false);
			num2.SetActive (false);
			num3.SetActive (true);
			button1.SetActive (false);
			button2.SetActive (true);
		} else {
			num1.SetActive (true);
			num2.SetActive (true);
			num3.SetActive (false);
			button1.SetActive (true);
			button2.SetActive (false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		if (player.RestartLevel == "PieSlice2") {
			num1.SetActive (true);
			num2.SetActive (true);
			num3.SetActive (false);
			button1.SetActive (true);
			button2.SetActive (false);
		}
	}


}
