using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_FaceController : MonoBehaviour {

	[SerializeField]
	GameObject HappyFaceNothungry;
	[SerializeField]
	GameObject SlightlyHungry;
	[SerializeField]
	GameObject PrettyHungry;
	[SerializeField]
	GameObject StarvingFace;
	[SerializeField]
	GameObject HurtFace;
	[SerializeField]
	GameObject SwimmingFace;
	[SerializeField]
	GameObject EatingFace;
	[SerializeField]
	GameObject ExcitedFace;
	[SerializeField]
	GameObject DeadFromEnemiesFace;
	[SerializeField]
	GameObject sprintingface;
	[SerializeField]
	GameObject DeadFromStarvingFace;

	bool sprintingfacebool = false;
	bool Happybool = false;
	bool SlightlyHungrybool = false;
	bool PrettyHungrybool = false;
	bool Starvingbool = false;
	bool Hurtbool = false;
	bool Swimmingbool = false;
	bool Eatingbool = false;
	bool Excitedbool = false;
	bool DeadfromEnemybool = false;
bool DeadfromFirebool = false;
	bool DeadfromStarvingbool = false;


	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		GameObject dir = GameObject.Find ("nose");
		CJC_ShowDirection direction = dir.GetComponent<CJC_ShowDirection> ();

		if (direction.facingleft)
		{
			transform.localPosition = new Vector3 (0, 0, -.08f);
			transform.localRotation = new Quaternion (0, 0,0, 1);
			//Debug.Log ("facing left");
			//transform.rotation = new Quaternion (0, 0,0, 1);
		}
		else if (direction.facingright)
		{
		//	transform.rotation = new Quaternion (0, 0,0, 1);
			transform.localPosition = new Vector3 (0, 0, .08f);
			transform.localRotation = new Quaternion (0, 180,0, 1);
			//Debug.Log ("falcing right");
		}
		SetBools ();
		SetOBJs ();
	}

	void SetOBJs()
	{
		if (Happybool)
		{
			HappyFaceNothungry.SetActive (true);
			SlightlyHungry.SetActive (false);
			PrettyHungry.SetActive (false);
			StarvingFace.SetActive (false);
			HurtFace.SetActive (false);
			SwimmingFace.SetActive (false);
			EatingFace.SetActive (false);
			ExcitedFace.SetActive (false);
			DeadFromEnemiesFace.SetActive (false);
			//DeadFromFireFace.SetActive (false);
			DeadFromStarvingFace.SetActive (false);
			sprintingface.SetActive (false);
		}
		else if (SlightlyHungrybool)
		{
			HappyFaceNothungry.SetActive (false);
			SlightlyHungry.SetActive (true);
			PrettyHungry.SetActive (false);
			StarvingFace.SetActive (false);
			HurtFace.SetActive (false);
			SwimmingFace.SetActive (false);
			EatingFace.SetActive (false);
			ExcitedFace.SetActive (false);
			DeadFromEnemiesFace.SetActive (false);
			//DeadFromFireFace.SetActive (false);
			DeadFromStarvingFace.SetActive (false);
			sprintingface.SetActive (false);
		}
		else if (PrettyHungrybool)
		{
			HappyFaceNothungry.SetActive (false);
			SlightlyHungry.SetActive (false);
			PrettyHungry.SetActive (true);
			StarvingFace.SetActive (false);
			HurtFace.SetActive (false);
			SwimmingFace.SetActive (false);
			EatingFace.SetActive (false);
			ExcitedFace.SetActive (false);
			DeadFromEnemiesFace.SetActive (false);
			//DeadFromFireFace.SetActive (false);
			DeadFromStarvingFace.SetActive (false);
			sprintingface.SetActive (false);
		}
		else if (Starvingbool)
		{
			HappyFaceNothungry.SetActive (false);
			SlightlyHungry.SetActive (false);
			PrettyHungry.SetActive (false);
			StarvingFace.SetActive (true);
			HurtFace.SetActive (false);
			SwimmingFace.SetActive (false);
			EatingFace.SetActive (false);
			ExcitedFace.SetActive (false);
			DeadFromEnemiesFace.SetActive (false);
			//DeadFromFireFace.SetActive (false);
			DeadFromStarvingFace.SetActive (false);
			sprintingface.SetActive (false);
		}
		else if (Hurtbool)
		{
			HappyFaceNothungry.SetActive (false);
			SlightlyHungry.SetActive (false);
			PrettyHungry.SetActive (false);
			StarvingFace.SetActive (false);
			HurtFace.SetActive (true);
			SwimmingFace.SetActive (false);
			EatingFace.SetActive (false);
			ExcitedFace.SetActive (false);
			DeadFromEnemiesFace.SetActive (false);
			//DeadFromFireFace.SetActive (false);
			DeadFromStarvingFace.SetActive (false);
			sprintingface.SetActive (false);
		}
		else if (Swimmingbool)
		{
			HappyFaceNothungry.SetActive (false);
			SlightlyHungry.SetActive (false);
			PrettyHungry.SetActive (false);
			StarvingFace.SetActive (false);
			HurtFace.SetActive (false);
			SwimmingFace.SetActive (true);
			EatingFace.SetActive (false);
			ExcitedFace.SetActive (false);
			DeadFromEnemiesFace.SetActive (false);
			//DeadFromFireFace.SetActive (false);
			DeadFromStarvingFace.SetActive (false);
			sprintingface.SetActive (false);
		}
		else if (Eatingbool)
		{
			HappyFaceNothungry.SetActive (false);
			SlightlyHungry.SetActive (false);
			PrettyHungry.SetActive (false);
			StarvingFace.SetActive (false);
			HurtFace.SetActive (false);
			SwimmingFace.SetActive (false);
			EatingFace.SetActive (true);
			ExcitedFace.SetActive (false);
			DeadFromEnemiesFace.SetActive (false);
			//DeadFromFireFace.SetActive (false);
			DeadFromStarvingFace.SetActive (false);
			sprintingface.SetActive (false);
		}
		else if (Excitedbool)
		{
			HappyFaceNothungry.SetActive (false);
			SlightlyHungry.SetActive (false);
			PrettyHungry.SetActive (false);
			StarvingFace.SetActive (false);
			HurtFace.SetActive (false);
			SwimmingFace.SetActive (false);
			EatingFace.SetActive (false);
			ExcitedFace.SetActive (true);
			DeadFromEnemiesFace.SetActive (false);
			//DeadFromFireFace.SetActive (false);
			DeadFromStarvingFace.SetActive (false);
			sprintingface.SetActive (false);
		}
		else if (DeadfromEnemybool)
		{
			HappyFaceNothungry.SetActive (false);
			SlightlyHungry.SetActive (false);
			PrettyHungry.SetActive (false);
			StarvingFace.SetActive (false);
			HurtFace.SetActive (false);
			SwimmingFace.SetActive (false);
			EatingFace.SetActive (false);
			ExcitedFace.SetActive (false);
			DeadFromEnemiesFace.SetActive (true);
			//DeadFromFireFace.SetActive (false);
			DeadFromStarvingFace.SetActive (false);
			sprintingface.SetActive (false);
		}
		else if (DeadfromFirebool)
		{
			HappyFaceNothungry.SetActive (false);
			SlightlyHungry.SetActive (false);
			PrettyHungry.SetActive (false);
			StarvingFace.SetActive (false);
			HurtFace.SetActive (false);
			SwimmingFace.SetActive (false);
			EatingFace.SetActive (false);
			ExcitedFace.SetActive (false);
			DeadFromEnemiesFace.SetActive (false);
			//DeadFromFireFace.SetActive (false);
			DeadFromStarvingFace.SetActive (false);
			sprintingface.SetActive (false);
		}
		else if (DeadfromStarvingbool)
		{
			HappyFaceNothungry.SetActive (false);
			SlightlyHungry.SetActive (false);
			PrettyHungry.SetActive (false);
			StarvingFace.SetActive (false);
			HurtFace.SetActive (false);
			SwimmingFace.SetActive (false);
			EatingFace.SetActive (false);
			ExcitedFace.SetActive (false);
			DeadFromEnemiesFace.SetActive (false);
			//DeadFromFireFace.SetActive (false);
			DeadFromStarvingFace.SetActive (true);
			sprintingface.SetActive (false);
		}
		else if (sprintingfacebool)
		{
			HappyFaceNothungry.SetActive (false);
			SlightlyHungry.SetActive (false);
			PrettyHungry.SetActive (false);
			StarvingFace.SetActive (false);
			HurtFace.SetActive (false);
			SwimmingFace.SetActive (false);
			EatingFace.SetActive (false);
			ExcitedFace.SetActive (false);
			DeadFromEnemiesFace.SetActive (false);
			//DeadFromFireFace.SetActive (false);
			DeadFromStarvingFace.SetActive (false);
			sprintingface.SetActive (true);
		}
	}

	void SetBools()
	{
		GameObject jum = GameObject.FindWithTag ("Player");
		CJC_tryjumping jump = jum.GetComponent<CJC_tryjumping> ();

		GameObject Str = GameObject.FindWithTag ("Player");
		CJC_Starvation starve = Str.GetComponent<CJC_Starvation> ();

		GameObject dir = GameObject.Find ("nose");
		CJC_ShowDirection direction = dir.GetComponent<CJC_ShowDirection> ();

		GameObject p1 = GameObject.Find ("Ladder");
		Ladder climb = p1.GetComponent<Ladder> ();

		GameObject fruity = GameObject.FindWithTag ("Player");
		PlayerwithFruit fruit = fruity.GetComponent<PlayerwithFruit> ();

		GameObject jumpp = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = jumpp.GetComponent<CJC_PlayerAndBools> ();

		GameObject ani = GameObject.FindWithTag ("Player");
		CJC_PlayerAnimController anim = ani.GetComponent<CJC_PlayerAnimController> ();


		if(!player.PlayerHurt && !player.PlayerDied && !jump.PlayerInWater && !anim.iseating && !anim.animCompletedLevel && player.IsSprinting)
		{ //if player is sprinting
			Happybool = false;
			SlightlyHungrybool = false;
			PrettyHungrybool = false;
			Starvingbool = false;
			Hurtbool = false;
			Swimmingbool = false;
			Eatingbool = false;
			Excitedbool = false;
			DeadfromEnemybool = false;
			DeadfromFirebool = false;
			DeadfromStarvingbool = false;
			sprintingfacebool = true;
		}
		else if(starve.HungerTimer > starve.HungerTimerMax /2 && !player.PlayerHurt && !player.PlayerDied && !jump.PlayerInWater && !anim.iseating && !anim.animCompletedLevel && !player.IsSprinting)
		{ //if player is not starving at all
			Happybool = true;
			SlightlyHungrybool = false;
			PrettyHungrybool = false;
			Starvingbool = false;
			Hurtbool = false;
			Swimmingbool = false;
			Eatingbool = false;
			Excitedbool = false;
			DeadfromEnemybool = false;
			DeadfromFirebool = false;
			DeadfromStarvingbool = false;
			sprintingfacebool = false;

		}
		else if(starve.HungerTimer <= starve.HungerTimerMax /2 && starve.HungerTimer > 10 && !player.PlayerHurt && !player.PlayerDied && !jump.PlayerInWater && !anim.iseating && !anim.animCompletedLevel && !player.IsSprinting)
		{ // if player is 50% starving
			Happybool = false;
			SlightlyHungrybool = true;
			PrettyHungrybool = false;
			Starvingbool = false;
			Hurtbool = false;
			Swimmingbool = false;
			Eatingbool = false;
			Excitedbool = false;
			DeadfromEnemybool = false;
			DeadfromFirebool = false;
			DeadfromStarvingbool = false;
			sprintingfacebool = false;
		}
		else if(starve.HungerTimer <= 10 && starve.HungerTimer > 0 && !player.PlayerHurt && !player.PlayerDied && !jump.PlayerInWater && !anim.iseating && !anim.animCompletedLevel && !player.IsSprinting)
		{ // if player is 75% starving
			Happybool = false;
			SlightlyHungrybool = false;
			PrettyHungrybool = true;
			Starvingbool = false;
			Hurtbool = false;
			Swimmingbool = false;
			Eatingbool = false;
			Excitedbool = false;
			DeadfromEnemybool = false;
			DeadfromFirebool = false;
			DeadfromStarvingbool = false;
			sprintingfacebool = false;
		}
		else if(starve.HungerTimer <= 0 && !player.PlayerHurt && !player.PlayerDied && !jump.PlayerInWater && !anim.iseating && !anim.animCompletedLevel && !player.IsSprinting)
		{ // if player is starving
			Happybool = false;
			SlightlyHungrybool = false;
			PrettyHungrybool = false;
			Starvingbool = true;
			Hurtbool = false;
			Swimmingbool = false;
			Eatingbool = false;
			Excitedbool = false;
			DeadfromEnemybool = false;
			DeadfromFirebool = false;
			DeadfromStarvingbool = false;
			sprintingfacebool = false;
		}
		else if(player.PlayerHurt && !player.PlayerDied && !anim.iseating && !anim.animCompletedLevel)
		{ // if player is hurt at all
			Happybool = false;
			SlightlyHungrybool = false;
			PrettyHungrybool = false;
			Starvingbool = false;
			Hurtbool = true;
			Swimmingbool = false;
			Eatingbool = false;
			Excitedbool = false;
			DeadfromEnemybool = false;
			DeadfromFirebool = false;
			DeadfromStarvingbool = false;
			sprintingfacebool = false;
		}
		else if(jump.PlayerInWater && !player.PlayerHurt && !player.PlayerDied && !anim.iseating && !anim.animCompletedLevel)
		{ // if player is in water at all
			Happybool = false;
			SlightlyHungrybool = false;
			PrettyHungrybool = false;
			Starvingbool = false;
			Hurtbool = false;
			Swimmingbool = true;
			Eatingbool = false;
			Excitedbool = false;
			DeadfromEnemybool = false;
			DeadfromFirebool = false;
			DeadfromStarvingbool = false;
			sprintingfacebool = false;
		}
		else if(anim.iseating && !jump.PlayerInWater && !player.PlayerHurt && !player.PlayerDied && !anim.animCompletedLevel)
		{ // if player is eating
			Happybool = false;
			SlightlyHungrybool = false;
			PrettyHungrybool = false;
			Starvingbool = false;
			Hurtbool = false;
			Swimmingbool = false;
			Eatingbool = true;
			Excitedbool = false;
			DeadfromEnemybool = false;
			DeadfromFirebool = false;
			DeadfromStarvingbool = false;
			sprintingfacebool = false;
		}
		else if(anim.animCompletedLevel)
		{ // if player completes a level
			Happybool = false;
			SlightlyHungrybool = false;
			PrettyHungrybool = false;
			Starvingbool = false;
			Hurtbool = false;
			Swimmingbool = false;
			Eatingbool = false;
			Excitedbool = true;
			DeadfromEnemybool = false;
			DeadfromFirebool = false;
			DeadfromStarvingbool = false;
			sprintingfacebool = false;
		}
		else if(player.PlayerDied && !player.playerBurning && !starve.IsStarving && !anim.animCompletedLevel)
		{ // if player dies from enemies, saws, spikes, etc.
			Happybool = false;
			SlightlyHungrybool = false;
			PrettyHungrybool = false;
			Starvingbool = false;
			Hurtbool = false;
			Swimmingbool = false;
			Eatingbool = false;
			Excitedbool = false;
			DeadfromEnemybool = true;
			DeadfromFirebool = false;
			DeadfromStarvingbool = false;
			sprintingfacebool = false;
		}
		else if(player.PlayerDied && player.playerBurning && !anim.animCompletedLevel)
		{ // if player dies from fire
			Happybool = false;
			SlightlyHungrybool = false;
			PrettyHungrybool = false;
			Starvingbool = false;
			Hurtbool = false;
			Swimmingbool = false;
			Eatingbool = false;
			Excitedbool = false;
			DeadfromEnemybool = false;
			DeadfromFirebool = true;
			DeadfromStarvingbool = false;
			sprintingfacebool = false;
		}
		else if(player.PlayerDied && !player.playerBurning && starve.IsStarving && !anim.animCompletedLevel)
		{ // if player dies from starving
			Happybool = false;
			SlightlyHungrybool = false;
			PrettyHungrybool = false;
			Starvingbool = false;
			Hurtbool = false;
			Swimmingbool = false;
			Eatingbool = false;
			Excitedbool = false;
			DeadfromEnemybool = false;
			DeadfromFirebool = false;
			DeadfromStarvingbool = true;
			sprintingfacebool = false;
		}
	}
}
