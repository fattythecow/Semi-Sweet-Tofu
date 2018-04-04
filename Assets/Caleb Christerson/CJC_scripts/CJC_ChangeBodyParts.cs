using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_ChangeBodyParts : MonoBehaviour {

	public Material norm;
	public Material green;
	public Material red;
	public Material purple;
	public Material orange;
	public Material burnt;
	[SerializeField]
	GameObject burndeathsound;

	// Use this for initialization
	void Start () {
		burndeathsound.SetActive (false);
	}
	
	// Update is called once per frame
	void Update ()
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		GameObject ani = GameObject.FindWithTag ("Player");
		CJC_PlayerAnimController anim = ani.GetComponent<CJC_PlayerAnimController> ();

		if (!player.IsGreen && !player.IsRed && !player.IsPurple && !player.IsYellow &&!player.PlayerDied)
		{
			GetComponent<MeshRenderer> ().material = norm;
		} 
		else if (player.IsGreen &&!player.PlayerDied)
		{
			GetComponent<MeshRenderer> ().material = green;
		} 
		else if (player.IsRed &&!player.PlayerDied)
		{
			GetComponent<MeshRenderer> ().material = red;
		} 
		else if (player.IsPurple &&!player.PlayerDied)
		{
			GetComponent<MeshRenderer> ().material = purple;
		} 
		else if (player.IsYellow &&!player.PlayerDied)
		{
			GetComponent<MeshRenderer> ().material = orange;
		} 
		else if (player.PlayerDied && player.playerBurning && !anim.animCompletedLevel)
		{
			burndeathsound.SetActive (true);
			GetComponent<MeshRenderer> ().material = burnt;
		}

		
	}
}
