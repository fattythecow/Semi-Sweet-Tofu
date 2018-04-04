using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_ControlAuras : MonoBehaviour
{

	[SerializeField]
	GameObject red = null;
	[SerializeField]
	GameObject green = null;
	[SerializeField]
	GameObject yellow = null;
	[SerializeField]
	GameObject purple = null;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		ManageAurasOn ();
		ManageAurasOff ();
	}

	void ManageAurasOn()
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools Player = p1.GetComponent<CJC_PlayerAndBools> ();

		if (Player.IsRed == true) 
		{
			red.SetActive (true);
			green.SetActive (false);
			yellow.SetActive (false);
			purple.SetActive (false);
		}
		else if (Player.IsGreen == true) 
		{
			red.SetActive (false);
			green.SetActive (true);
			yellow.SetActive (false);
			purple.SetActive (false);
		}
		else if (Player.IsYellow == true) 
		{
			red.SetActive (false);
			green.SetActive (false);
			yellow.SetActive (true);
			purple.SetActive (false);
		}
		else if (Player.IsPurple == true) 
		{
			red.SetActive (false);
			green.SetActive (false);
			yellow.SetActive (false);
			purple.SetActive (true);
		}
	}

	void ManageAurasOff()
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools Player = p1.GetComponent<CJC_PlayerAndBools> ();

		if (Player.IsRed == false) 
		{
			red.SetActive (false);
		}


		if (Player.IsGreen == false) 
		{
			green.SetActive (false);
		}


		if (Player.IsYellow == false) 
		{
			yellow.SetActive (false);
		}


		if (Player.IsPurple == false) 
		{
			purple.SetActive (false);
		}
	}
}
