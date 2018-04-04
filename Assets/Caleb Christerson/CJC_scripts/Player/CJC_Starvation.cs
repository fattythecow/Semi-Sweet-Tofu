using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_Starvation : MonoBehaviour
{
	public float HungerTimerMax = 60;
	public float HungerTimer = 60;
	public float HungerMultiplier = 1;

	public bool IsStarving = false;
	[SerializeField]
	float levelDifficulty = 1;

	public float TutorialvideoTimer =1;

	[SerializeField]
	GameObject YouNeedFood;
	[SerializeField]
	GameObject YoureStarving;



	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();
		GameObject dir = GameObject.FindWithTag ("Player");
		CJC_PlayerAnimController anim = dir.GetComponent<CJC_PlayerAnimController> ();
		if (shop.isopen == false && !anim.animCompletedLevel)
		{

			HandleHunger ();
			HandleStarving ();
			HandleStarvingPFI ();
		}
			
		/*if (CJC_TutPlayer.VideoOn)
		{
			TutorialvideoTimer = 0;
		}
		else if (CJC_TutPlayer.VideoOn)
		{
			TutorialvideoTimer = 1;
		}*/

	}

	void HandleHunger()
	{

		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools Player = p1.GetComponent<CJC_PlayerAndBools> ();

		if (HungerTimer > 0) 
		{
			IsStarving = false;
		}

		if (IsStarving == false)
		{
			Player.speedStarvingMultiplier = 1;
			Player.starvingjumpheightmultipleer = 1;
			Player.staminastarvingmultiplier = 1;


			HungerTimer -= Time.deltaTime * levelDifficulty * TutorialvideoTimer;

			if (HungerTimer < 0)
			{
				HungerTimer = 0;
				IsStarving = true;
			} 
			else if (HungerTimer >= 60) 
			{
				HungerTimer = 60;
			}
		}
		else if (IsStarving == true) 
		{
			if (HungerTimer > 0) 
			{
				HungerTimer = HungerTimer;
				IsStarving = false;
			}
		}

	}

	void HandleStarving()
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools Player = p1.GetComponent<CJC_PlayerAndBools> ();

		if (Player.PlayerDied == false && IsStarving == true) 
		{
			Player.PlayerHealth -= Time.deltaTime * 3;
			Player.speedStarvingMultiplier = .8f;
			//Player.starvingjumpheightmultipleer = 1f;
			Player.staminastarvingmultiplier = .825f;
		}
	}

	void HandleStarvingPFI()
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools Player = p1.GetComponent<CJC_PlayerAndBools> ();

		if (Player.PlayerDied)
		{
			YoureStarving.SetActive (false);
			YouNeedFood.SetActive (false);
		}
		else if (HungerTimer > HungerTimerMax / 2 && !Player.PlayerDied) 
		{
			YoureStarving.SetActive (false);
			YouNeedFood.SetActive (false);
		}
		else if (HungerTimer <= HungerTimerMax / 2 && HungerTimer > 0 && !Player.PlayerDied) 
		{
			YoureStarving.SetActive (false);
			YouNeedFood.SetActive (true);
		}
		else if (HungerTimer <= 0 && !Player.PlayerDied) 
		{
			YoureStarving.SetActive (true);
			YouNeedFood.SetActive (false);
		}
	}
}
