using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_manageJump : MonoBehaviour
{
	public static bool candoubleJump = false;
	public bool AlreadyInAir = false;
	public float JumpForce = 1;
	float doublejumptimer =0;
	public bool PlayerCanJump = true;

	public float jumprefresh = 0;
	[SerializeField]
	float jumpCoolDownOnLanding = .15f;

	public bool Isdoublejumping = false;
	public bool Hasdoublejumped = false;
	public float hasdoublejumpedtimer = 0f;
	public float jumpingdoubletimer = 0f;
	public float NormaldoubleJumpHeight = 6;
	public int totaldoublejumps = 0;
	CharacterController contorller;

	// Use this for initialization
	void Start () 
	{
		contorller = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();
		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();
		GameObject core = GameObject.FindWithTag ("GameCore");
		CJC_PauseShit gamecore = core.GetComponent<CJC_PauseShit> ();

		if (shop.isopen == false && gamecore.paused == false)
		{
			

			if (player.IsSprinting == true)
			{
				JumpForce = 1.125f;
			} 
			else if (player.IsSprinting == false)
			{
				JumpForce = 1f;
			}

			//HandleJump ();

			if (candoubleJump) {
				DoubleJump ();
			}
		}

	}

	void OnTriggerStay(Collider other)
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		if (other.tag == "Floor")
		{
			jumprefresh += Time.deltaTime;
			//JumpForce = 1;
			player.OnGround = true;
			totaldoublejumps = 0;
			Hasdoublejumped = false;

			if (player.OnGround == true && contorller.isGrounded == false && jumprefresh >= jumpCoolDownOnLanding) 
			{
				AlreadyInAir = false;

				if (Input.GetKey (KeyCode.Space) | Input.GetButton ("360_AButton") | Input.GetButton ("ps4_XButton")) {
					//GetComponent<AudioSource> ().PlayOneShot (Jump);
					jumprefresh = 0;
				}
			}


		}
	}

	void OnTriggerExit(Collider other)
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		if (other.tag == "Floor")
		{
			player.OnGround = false;
		}
	}

	void DoubleJump()
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		if (player.OnGround == false)
		{

			/*if (player.Isdoublejumping == false && player.totaldoublejumps == 0)
			{
				if (Input.GetKeyDown (KeyCode.Space) | Input.GetButtonDown ("360_AButton")  | Input.GetButtonDown("ps4_XButton"))
				{
					Debug.Log ("did a doublejump");
					//GetComponent<AudioSource> ().PlayOneShot (Jump);
					player.Hasdoublejumped = true;
					player.totaldoublejumps = 1;

				}
			}*/
			if (Hasdoublejumped == false && totaldoublejumps == 0)
			{
				doublejumptimer = 0;
				if (Input.GetKeyDown (KeyCode.Space) | Input.GetButtonDown ("360_AButton")  | Input.GetButtonDown("ps4_XButton"))
				{
					
					//GetComponent<AudioSource> ().PlayOneShot (Jump);
					Hasdoublejumped = true;
					totaldoublejumps = 1;

				}


			}

			if (Hasdoublejumped == true) 
			{
				doublejumptimer += Time.deltaTime;
				//player.transform.Translate (0, ((player.NormalJumpHeight/9)* JumpForce) * player.starvingjumpheightmultipleer * player.applejumpBuff, 0);
				if (doublejumptimer >= .15f)
				Hasdoublejumped = false;
			}
		}
	}


	/*void HandleJump()
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();
		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();
		if (shop.isopen == false) 
		{
			if (PlayerCanJump == true)
			{
				
				if (player.Hasjumped == true)
				{
					if (player.IsSprinting == false)
					{
						AlreadyInAir = true;
					} 
					else
						AlreadyInAir = false;

					player.transform.Translate (0, ((player.NormalJumpHeight /15)* JumpForce) * player.starvingjumpheightmultipleer * player.applejumpBuff, 0 );
					player.hasjumpedtimer += Time.deltaTime;
				}

				if (player.hasjumpedtimer >= .2f) {
					player.Isjumping = true;
				}

				if (player.Isjumping == true) {
					player.jumpingtimer += Time.deltaTime;

					if (player.jumpingtimer >= .1f) {
						player.Hasjumped = false;
						player.hasjumpedtimer = 0;
						player.jumpingtimer = 0;
						player.Isjumping = false;
					}
				}
			}
		}

	}*/
}
