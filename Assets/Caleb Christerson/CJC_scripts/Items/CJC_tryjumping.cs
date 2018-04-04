using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_tryjumping : MonoBehaviour {

	public float speed = 6;
	public float jumpspeed = 11;
	public float grsvity = 20;
	public  Vector3 movedirection = Vector3.zero;
	public bool PlayerInWater = false;

	float hasjumpedtimer =0;

	public CharacterController contorller;

	public static bool candoubleJump = false;
	public bool AlreadyInAir = false;
	public float JumpForce = 1;
	float doublejumptimer =0;

	public bool Isdoublejumping = false;
	public bool Hasdoublejumped = false;
	public float hasdoublejumpedtimer = 0f;
	public float jumpingdoubletimer = 0f;
	public float NormaldoubleJumpHeight = 6;
	public int totaldoublejumps = 0;
	[SerializeField]
	GameObject doublejump;


	// Use this for initialization
	void Start () {
		contorller = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		GameObject sou = GameObject.FindWithTag ("Player");
		CJC_SoundHolder sound = sou.GetComponent<CJC_SoundHolder> ();
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();
		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();
		GameObject core = GameObject.FindWithTag ("GameCore");
		CJC_PauseShit gamecore = core.GetComponent<CJC_PauseShit> ();
		GameObject dir = GameObject.FindWithTag ("Player");
		CJC_PlayerAnimController anim = dir.GetComponent<CJC_PlayerAnimController> ();

		if (!CJC_InGameXboxUISelector.hastoshowcontrols && !CJC_ButtonPressFIX.nocontrols) {
			if (!player.PlayerDied && !anim.animCompletedLevel) {
			
				if (shop.isopen == false && gamecore.paused == false) {

					/*
			if (player.IsSprinting == true)
			{
				JumpForce = 1f;
			} 
			else if (player.IsSprinting == false)
			{
				JumpForce = 1f;
			}
			*/
					JumpForce = 1f;
					HandleJump ();

					if (candoubleJump) {
						DoubleJump ();
					}
				}


				if (contorller.isGrounded == true) {
					speed = player.NormalMoveSpeed;

					movedirection.x = (Input.GetAxis ("Horizontal") * Time.deltaTime * speed * 7.5f);
					//movedirection = transform.TransformDirection(movedirection);
					movedirection.x *= speed;
					//contorller.Move (movedirection * Time.deltaTime);
					hasjumpedtimer = 0;
					AlreadyInAir = false;
					player.OnGround = true;
					totaldoublejumps = 0;
					Hasdoublejumped = false;

					if (!player.IsYellow) {
						if (Input.GetAxis ("Horizontal") > .1 && movedirection.x > 11 && player.IsSprinting) {
							movedirection.x = 11;
							if (PlayerInWater) {
								movedirection.x = 8;
							}
						} else if (Input.GetAxis ("Horizontal") > .1 && movedirection.x > 7) {
							movedirection.x = 7;
							if (PlayerInWater) {
								movedirection.x = 5;
							}
						} else if (Input.GetAxis ("Horizontal") < 0 && movedirection.x < -11 && player.IsSprinting) {
							movedirection.x = -11;
							if (PlayerInWater) {
								movedirection.x = -8;
							}
						} else if (Input.GetAxis ("Horizontal") < 0 && movedirection.x < -7) {
							movedirection.x = -7;
							if (PlayerInWater) {
								movedirection.x = -5;
							}
						}
					} else if (player.IsYellow) {
						if (Input.GetAxis ("Horizontal") > .1 && movedirection.x > 14 && player.IsSprinting) {
							movedirection.x = 14;
							if (PlayerInWater) {
								movedirection.x = 8;
							}
						} else if (Input.GetAxis ("Horizontal") > .1 && movedirection.x > 10) {
							movedirection.x = 10;
							if (PlayerInWater) {
								movedirection.x = 5;
							}
						} else if (Input.GetAxis ("Horizontal") < 0 && movedirection.x < -14 && player.IsSprinting) {
							movedirection.x = -14;
							if (PlayerInWater) {
								movedirection.x = -8;
							}
						} else if (Input.GetAxis ("Horizontal") < 0 && movedirection.x < -10) {
							movedirection.x = -10;
							if (PlayerInWater) {
								movedirection.x = -5;
							}
						}
					}

				} else {
					movedirection.x = (Input.GetAxis ("Horizontal") * Time.deltaTime * speed * 7.5f);
					movedirection.x *= speed;
					AlreadyInAir = true;
					hasjumpedtimer += Time.deltaTime;

					if (hasjumpedtimer >= .2f) {
						hasjumpedtimer = .2f;
					}
				}
			}
		}
	}

	void HandleJump()
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();
		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();
		GameObject sou = GameObject.FindWithTag ("Player");
		CJC_SoundHolder sound = sou.GetComponent<CJC_SoundHolder> ();
		GameObject lad = GameObject.Find ("Ladder");
		Ladder ladder = lad.GetComponent<Ladder> ();

		if (shop.isopen == false) 
		{
			if (contorller.isGrounded)
			{
				player.OnGround = true;

				if (Input.GetKeyDown (KeyCode.Space) | Input.GetButtonDown ("360_AButton") | Input.GetButtonDown ("ps4_XButton"))
				{
					if (player.OnGround == true)
						GetComponent<AudioSource> ().PlayOneShot (sound.jumpsound);
						movedirection.y = jumpspeed * JumpForce * player.starvingjumpheightmultipleer * player.applejumpBuff;
				}
			} 
			else if (!contorller.isGrounded)
			{
				player.OnGround = false;

				if (Ladder.willClimb)
				{
					movedirection.y = 0;
				}
				if (PlayerInWater == true)
				{
					movedirection.y -= grsvity * Time.deltaTime * 4;
				} 
				else if (PlayerInWater == false && !Ladder.willClimb)
				{
					movedirection.y -= grsvity * Time.deltaTime;
				}

				if (movedirection.y < -10) 
				{
					movedirection.y = -10;
				}



				if (!player.IsYellow) {
					if (Input.GetAxis ("Horizontal") > .1 && movedirection.x > 11 && player.IsSprinting) {
						movedirection.x = 11;
						if (PlayerInWater) {
							movedirection.x = 8;
						}
					} else if (Input.GetAxis ("Horizontal") > .1 && movedirection.x > 7) {
						movedirection.x = 7;
						if (PlayerInWater) {
							movedirection.x = 5;
						}
					} else if (Input.GetAxis ("Horizontal") < 0 && movedirection.x < -11 && player.IsSprinting) {
						movedirection.x = -11;
						if (PlayerInWater) {
							movedirection.x = -8;
						}
					} else if (Input.GetAxis ("Horizontal") < 0 && movedirection.x < -7) {
						movedirection.x = -7;
						if (PlayerInWater) {
							movedirection.x = -5;
						}
					}
				}
				else if (player.IsYellow) {
					if (Input.GetAxis ("Horizontal") > .1 && movedirection.x > 14 && player.IsSprinting) {
						movedirection.x = 14;
						if (PlayerInWater) {
							movedirection.x = 8;
						}
					} else if (Input.GetAxis ("Horizontal") > .1 && movedirection.x > 10) {
						movedirection.x = 10;
						if (PlayerInWater) {
							movedirection.x = 5;
						}
					} else if (Input.GetAxis ("Horizontal") < 0 && movedirection.x < -14 && player.IsSprinting) {
						movedirection.x = -14;
						if (PlayerInWater) {
							movedirection.x = -8;
						}
					} else if (Input.GetAxis ("Horizontal") < 0 && movedirection.x < -10) {
						movedirection.x = -10;
						if (PlayerInWater) {
							movedirection.x = -5;
						}
					}
				}
			}


			contorller.Move (movedirection * Time.deltaTime);
		}

	}

	void DoubleJump()
	{
		GameObject sou = GameObject.FindWithTag ("Player");
		CJC_SoundHolder sound = sou.GetComponent<CJC_SoundHolder> ();
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		if (hasjumpedtimer >= .2f)
		{
			if (Hasdoublejumped == false && totaldoublejumps == 0)
			{
				doublejumptimer = 0;
				if (Input.GetKeyDown (KeyCode.Space) | Input.GetButtonDown ("360_AButton")  | Input.GetButtonDown("ps4_XButton"))
				{
					GetComponent<AudioSource> ().PlayOneShot (sound.jumpsound);
					doublejump.SetActive (true);
					totaldoublejumps = 1;
					Hasdoublejumped = true;
					movedirection.y = NormaldoubleJumpHeight *JumpForce * player.starvingjumpheightmultipleer * player.applejumpBuff;
				}
			}
		}
	}
}
