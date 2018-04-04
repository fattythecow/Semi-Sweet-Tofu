using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_Changefaces : MonoBehaviour {

	public Material facenorm;
	public Material facegreen;
	public Material facered;
	public Material facepurple;
	public Material faceorange;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update ()
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		GameObject ani = GameObject.FindWithTag ("Player");
		CJC_PlayerAnimController anim = ani.GetComponent<CJC_PlayerAnimController> ();

		if (!player.IsGreen && !player.IsRed && !player.IsPurple && !player.IsYellow)
		{
			GetComponent<MeshRenderer> ().material = facenorm;
		} 
		else if (player.IsGreen &&!player.PlayerDied)
		{
			GetComponent<MeshRenderer> ().material = facegreen;
		} 
		else if (player.IsRed &&!player.PlayerDied)
		{
			GetComponent<MeshRenderer> ().material = facered;
		} 
		else if (player.IsPurple &&!player.PlayerDied)
		{
			GetComponent<MeshRenderer> ().material = facepurple;
		} 
		else if (player.IsYellow &&!player.PlayerDied)
		{
			GetComponent<MeshRenderer> ().material = faceorange;
		}


	}
}
