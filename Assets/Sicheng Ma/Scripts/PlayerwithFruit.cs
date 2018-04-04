using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerwithFruit : MonoBehaviour
{
	public GameObject banana;
	public GameObject apple;
	public GameObject grape;
	public GameObject strawberry;
	public GameObject durian;
	public GameObject grapeFruit;
	public CJC_PlayerAndBools colorChange;
	public CJC_tryjumping jumper;
	public CJC_Starvation healing;

	public GameObject slowmotion;

	public bool isholding = false;

	public string currentFruitInHand = null;

	public float timer = 0f;

	public bool Isdebuff = false;
	bool hasbeenpressed = false;

	public bool pickedup =false;

	float pickuptimer = 0;

	public GameObject bananaPre;
	public GameObject applePre;
	public GameObject grapePre;
	public GameObject strawberryPre;
	public GameObject durianPre;
	public GameObject grapeFruitPre;
	public static float Btimer = 0;

	[SerializeField]
	AudioClip decolorsound;


	// Use this for initialization
	void Start () {
		slowmotion.SetActive (false);
	}
		
	// Update is called once per frame
	void Update ()
	{
		if (!CJC_InGameXboxUISelector.hastoshowcontrols && !CJC_ButtonPressFIX.nocontrols) {
			DropFruit ();
		}
		testTriggers ();
		if (!CJC_InGameXboxUISelector.hastoshowcontrols && !CJC_ButtonPressFIX.nocontrols) {
			eatingfruit ();
		}
		TestBbutton ();

		if (Isdebuff) {
			timer += Time.deltaTime;
			if (timer <= 3.0f) {
				colorChange.SpeedDebuff = 0.75f;
				slowmotion.SetActive (true);
			}
			
			else if
				(timer > 3f)
			{
				colorChange.SpeedDebuff = 1f;
				slowmotion.SetActive (false);
				Isdebuff = false;
				timer = 0f;
			}
		}

		if (pickedup == true) {
			pickuptimer += Time.deltaTime;
			if (pickuptimer >= .1f) 
			{
				pickuptimer = 0;
				pickedup = false;
			}
		}
	}

	void DropFruit(){
		GameObject core = GameObject.Find ("CoreGameController");
		CJC_PauseShit pitbull = core.GetComponent<CJC_PauseShit> ();

		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();

		GameObject p1 = GameObject.Find ("Ladder");
		Ladder climb = p1.GetComponent<Ladder> ();

		GameObject p2 = GameObject.Find ("nose");
		CJC_ShowDirection ohyes = p2.GetComponent<CJC_ShowDirection> ();

		GameObject p3 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools boyes = p3.GetComponent<CJC_PlayerAndBools> ();

		GameObject p5 = GameObject.FindWithTag ("Player");
		CJC_tryjumping boylish = p5.GetComponent<CJC_tryjumping> ();

		GameObject p4 = GameObject.Find ("Water");
		CJC_InWater coldones = p4.GetComponent<CJC_InWater> ();

		GameObject p = GameObject.FindWithTag ("Player");
		CJC_PlayerAnimController player = p.GetComponent<CJC_PlayerAnimController> ();

		GameObject sou = GameObject.FindWithTag ("Player");
		CJC_SoundHolder sound = sou.GetComponent<CJC_SoundHolder> ();

		if (!pitbull.paused && !shop.isopen) {
			if (isholding) {
				if (boyes.OnGround || coldones.inwater || boylish.AlreadyInAir) {
					if (!Ladder.willClimb) {
						if (Input.GetKeyDown (KeyCode.Q) | Input.GetButtonDown ("360_YButton") | Input.GetButtonDown ("ps4_TriangleButton")) {
							sound.GetComponent<AudioSource> ().PlayOneShot (sound.DropSound);
							player.isdropping = true;
							if (banana.activeInHierarchy) {
								if (ohyes.facingleft)
									Instantiate (bananaPre, new Vector2 (transform.position.x - 3, transform.position.y), gameObject.transform.rotation);
								else if (ohyes.facingright)
									Instantiate (bananaPre, new Vector2 (transform.position.x + 3, transform.position.y), gameObject.transform.rotation);
								isholding = false;
								currentFruitInHand = null;
								banana.SetActive (false);
							} else if (apple.activeInHierarchy) {
								if (ohyes.facingleft)
									Instantiate (applePre, new Vector2 (transform.position.x - 3, transform.position.y), gameObject.transform.rotation);
								else if (ohyes.facingright)
									Instantiate (applePre, new Vector2 (transform.position.x + 3, transform.position.y), gameObject.transform.rotation);
								isholding = false;
								currentFruitInHand = null;
								apple.SetActive (false);
							} else if (grape.activeInHierarchy) {
								if (ohyes.facingleft)
									Instantiate (grapePre, new Vector2 (transform.position.x - 3, transform.position.y), gameObject.transform.rotation);
								else if (ohyes.facingright)
									Instantiate (grapePre, new Vector2 (transform.position.x + 3, transform.position.y), gameObject.transform.rotation);
								isholding = false;
								currentFruitInHand = null;
								grape.SetActive (false);
							} else if (strawberry.activeInHierarchy) {
								if (ohyes.facingleft)
									Instantiate (strawberryPre, new Vector2 (transform.position.x - 3, transform.position.y), gameObject.transform.rotation);
								else if (ohyes.facingright)
									Instantiate (strawberryPre, new Vector2 (transform.position.x + 3, transform.position.y), gameObject.transform.rotation);
								isholding = false;
								currentFruitInHand = null;
								strawberry.SetActive (false);
							} else if (durian.activeInHierarchy) {
								if (ohyes.facingleft)
									Instantiate (durianPre, new Vector2 (transform.position.x - 3, transform.position.y), gameObject.transform.rotation);
								else if (ohyes.facingright)
									Instantiate (durianPre, new Vector2 (transform.position.x + 3, transform.position.y), gameObject.transform.rotation);
								isholding = false;
								currentFruitInHand = null;
								durian.SetActive (false);
							} else if (grapeFruit.activeInHierarchy) {
								if (ohyes.facingleft)
									Instantiate (grapeFruitPre, new Vector2 (transform.position.x - 3, transform.position.y), gameObject.transform.rotation);
								else if (ohyes.facingright)
									Instantiate (grapeFruitPre, new Vector2 (transform.position.x + 3, transform.position.y), gameObject.transform.rotation);
								isholding = false;
								currentFruitInHand = null;
								grapeFruit.SetActive (false);
							}
						}
					}
				}
			}
		}
	}

	void TestBbutton(){
		if (ShopController.PressedB) {
			Btimer += Time.deltaTime;
			if (Btimer >= .1f) 
			{
				Btimer = 0;
				ShopController.PressedB = false;
			}
		}
	}


	void testTriggers()
	{


		if (Input.GetAxis ("360_Triggers") > 0.5f && hasbeenpressed == false) 
		{
			//Debug.Log ("right trigger pressed once");
			//hasbeenpressed = true;
		}
		else if (Input.GetAxis ("360_Triggers") <0 && hasbeenpressed == false) 
		{
			//Debug.Log ("left trigger pressed once");
			//hasbeenpressed = true;
		}
		else if (Input.GetAxis ("360_Triggers") == 0) 
		{
			hasbeenpressed = false;
		}
	}

	void eatingfruit()
	{
		GameObject healthref = GameObject.Find ("Health");
		CJC_HealthPFI Health = healthref.GetComponent<CJC_HealthPFI> ();

		GameObject core = GameObject.Find ("CoreGameController");
		CJC_PauseShit pitbull = core.GetComponent<CJC_PauseShit> ();

		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();

		GameObject p = GameObject.FindWithTag ("Player");
		CJC_PlayerAnimController player = p.GetComponent<CJC_PlayerAnimController> ();

		GameObject sou = GameObject.FindWithTag ("Player");
		CJC_SoundHolder sound = sou.GetComponent<CJC_SoundHolder> ();

		if (banana.activeInHierarchy == true)
		{
			currentFruitInHand = "banana";
			if (!pitbull.paused && !shop.isopen) {
				if (!ShopController.PressedB) {
					if (Input.GetKeyDown (KeyCode.E) | Input.GetButtonDown ("360_BButton") | Input.GetButtonDown ("ps4_CircleButton")) {
						sound.GetComponent<AudioSource> ().PlayOneShot (sound.EatSound);
						sound.GetComponent<AudioSource> ().PlayOneShot (decolorsound);
						player.iseating = true;
						isholding = false;
						currentFruitInHand = null;
						colorChange.IsYellow = true;
						colorChange.IsGreen = false;
						colorChange.IsPurple = false;
						colorChange.IsRed = false;
						banana.SetActive (false);
						healing.HungerTimer += 15;
					}
				}
			}
		}

		if (grape.activeInHierarchy == true) 
		{
			currentFruitInHand = "grape";
			if (!pitbull.paused && !shop.isopen) {
				if (!ShopController.PressedB) {
					if (Input.GetKeyDown (KeyCode.E) | Input.GetButtonDown ("360_BButton") | Input.GetButtonDown ("ps4_CircleButton")) {
						sound.GetComponent<AudioSource> ().PlayOneShot (sound.EatSound);
						sound.GetComponent<AudioSource> ().PlayOneShot (decolorsound);
						player.iseating = true;
						isholding = false;
						currentFruitInHand = null;
						colorChange.IsYellow = false;
						colorChange.IsGreen = false;
						colorChange.IsPurple = true;
						colorChange.IsRed = false;
						grape.SetActive (false);
						if (colorChange.PlayerHealth < 85) {
							healing.HungerTimer += 15;
							colorChange.SprintStamina += 5;
							colorChange.SprintExhausted = false;
							colorChange.ExhaustionTimer = 0;
						} else if (colorChange.PlayerHealth >= 100) {
							healing.HungerTimer += 15;
							colorChange.SprintStamina += 5;
							colorChange.SprintExhausted = false;
							colorChange.ExhaustionTimer = 0;
						} else if (colorChange.PlayerHealth < 100 && colorChange.PlayerHealth >= 85) {
							healing.HungerTimer += 15;
							colorChange.SprintStamina += 5;
							colorChange.SprintExhausted = false;
							colorChange.ExhaustionTimer = 0;
						}
					
					}
				}
			}
		}

		if (apple.activeInHierarchy == true)
		{
			currentFruitInHand = "apple";
			if (!pitbull.paused && !shop.isopen) {
				if (!ShopController.PressedB) {
					if (Input.GetKeyDown (KeyCode.E) | Input.GetButtonDown ("360_BButton") | Input.GetButtonDown ("ps4_CircleButton")) {
						sound.GetComponent<AudioSource> ().PlayOneShot (sound.EatSound);
						sound.GetComponent<AudioSource> ().PlayOneShot (decolorsound);
						player.iseating = true;
						isholding = false;
						currentFruitInHand = null;
						colorChange.IsYellow = false;
						colorChange.IsGreen = true;
						colorChange.IsPurple = false;
						colorChange.IsRed = false;
						apple.SetActive (false);
						healing.HungerTimer += 15;
					}
				}
			}
		}

		if (strawberry.activeInHierarchy == true) 
		{
			currentFruitInHand = "strawberry";
			if (!pitbull.paused && !shop.isopen) {
				if (!ShopController.PressedB) {
					if (Input.GetKeyDown (KeyCode.E) | Input.GetButtonDown ("360_BButton") | Input.GetButtonDown ("ps4_CircleButton")) {
						sound.GetComponent<AudioSource> ().PlayOneShot (sound.EatSound);
						sound.GetComponent<AudioSource> ().PlayOneShot (decolorsound);
						player.iseating = true;
						isholding = false;
						currentFruitInHand = null;
						colorChange.IsYellow = false;
						colorChange.IsGreen = false;
						colorChange.IsPurple = false;
						colorChange.IsRed = true;
						strawberry.SetActive (false);
						healing.HungerTimer += 15;
					}
				}
			}
		}

		if (durian.activeInHierarchy == true)
		{
			currentFruitInHand = "durian";
			if (!pitbull.paused && !shop.isopen) {
				if (!ShopController.PressedB) {
					if (Input.GetKeyDown (KeyCode.E) | Input.GetButtonDown ("360_BButton") | Input.GetButtonDown ("ps4_CircleButton")) {
						sound.GetComponent<AudioSource> ().PlayOneShot (sound.EatSound);
						sound.GetComponent<AudioSource> ().PlayOneShot (decolorsound);
						player.iseating = true;
						isholding = false;
						currentFruitInHand = null;
						durian.SetActive (false);
						healing.HungerTimer += 25;
						colorChange.PlayerHealth -= 15;
						Health.Playerdamaged = true;
					}
				}
			}
		}

		if (grapeFruit.activeInHierarchy == true)
		{
			currentFruitInHand = "grapefruit";
			if (!pitbull.paused && !shop.isopen) {
				if (!ShopController.PressedB) {
					if (Input.GetKeyDown (KeyCode.E) | Input.GetButtonDown ("360_BButton") | Input.GetButtonDown ("ps4_CircleButton")) {
						sound.GetComponent<AudioSource> ().PlayOneShot (sound.EatSound);
						sound.GetComponent<AudioSource> ().PlayOneShot (decolorsound);
						player.iseating = true;
						isholding = false;
						currentFruitInHand = null;
						grapeFruit.SetActive (false);
						Isdebuff = true;
						Health.Playerhealed = true;
						if (colorChange.PlayerHealth < 70) {
							colorChange.PlayerHealth += 30;
						} else {
							colorChange.PlayerHealth = 100;
						}
					}
				}
			}
		}
	

	}
	/*
	void SwitchFruit()
	{
		GameObject core = GameObject.Find ("CoreGameController");
		CJC_PauseShit pitbull = core.GetComponent<CJC_PauseShit> ();

		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();

		if (!pitbull.paused && !shop.isopen) {
			if (inven1full == true) {
				if (Input.GetKeyDown (KeyCode.Alpha1) | Input.GetAxis ("360_Triggers") < 0 && hasbeenpressed == false | Input.GetButtonDown ("ps4_L1Button")) {
					hasbeenpressed = true;

					if (currentFruitInHand == "banana" && in1grape.activeInHierarchy) {
						grape.SetActive (true);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (true);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
					} else if (currentFruitInHand == "banana" && in1red.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (true);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (true);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "banana" && in1green.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (true);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (true);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "banana" && in1yellow.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (true);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (true);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "banana" && in1black.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (true);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (true);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "banana" && in1gray.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (true);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (true);
					} else if (currentFruitInHand == null && in1grape.activeInHierarchy) {
						grape.SetActive (true);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (true);
						inven1full = false;
						isholding = true;
					} else if (currentFruitInHand == null && in1red.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (true);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (true);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						inven1full = false;
						isholding = true;
					} else if (currentFruitInHand == null && in1green.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (true);
						grape.SetActive (false);
						apple.SetActive (true);
						strawberry.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						banana.SetActive (false);
						inven1full = false;
						isholding = true;
					} else if (currentFruitInHand == null && in1yellow.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (true);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						banana.SetActive (true);
						inven1full = false;
						isholding = true;
					} else if (currentFruitInHand == null && in1black.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (true);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						durian.SetActive (true);
						grapeFruit.SetActive (false);
						banana.SetActive (false);
						inven1full = false;
						isholding = true;
					} else if (currentFruitInHand == null && in1gray.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (true);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (true);
						banana.SetActive (false);
						inven1full = false;
						isholding = true;
					} else if (currentFruitInHand == "grape" && in1grape.activeInHierarchy) {
						grape.SetActive (true);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (true);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
					} else if (currentFruitInHand == "grape" && in1red.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (true);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (true);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "grape" && in1green.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (true);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (true);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "grape" && in1yellow.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (true);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (true);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "grape" && in1black.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (true);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (true);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "grape" && in1gray.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (true);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (true);
					} else if (currentFruitInHand == "apple" && in1grape.activeInHierarchy) {
						grape.SetActive (true);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						in1green.SetActive (true);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);

					} else if (currentFruitInHand == "apple" && in1red.activeInHierarchy) {
						in1green.SetActive (true);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (true);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "apple" && in1green.activeInHierarchy) {
						in1green.SetActive (true);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (true);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "apple" && in1yellow.activeInHierarchy) {
						in1green.SetActive (true);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (true);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "apple" && in1black.activeInHierarchy) {
						in1green.SetActive (true);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (true);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "apple" && in1gray.activeInHierarchy) {
						in1green.SetActive (true);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (true);
					} else if (currentFruitInHand == "strawberry" && in1grape.activeInHierarchy) {
						grape.SetActive (true);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						in1green.SetActive (false);
						in1red.SetActive (true);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);

					} else if (currentFruitInHand == "strawberry" && in1red.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (true);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (true);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "strawberry" && in1green.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (true);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (true);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "strawberry" && in1yellow.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (true);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (true);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "strawberry" && in1black.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (true);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (true);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "strawberry" && in1gray.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (true);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (true);
					} else if (currentFruitInHand == "durian" && in1grape.activeInHierarchy) {
						grape.SetActive (true);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (true);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);

					} else if (currentFruitInHand == "durian" && in1red.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (true);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (true);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "durian" && in1green.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (true);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (true);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "durian" && in1yellow.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (true);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (true);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "durian" && in1black.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (true);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (true);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "durian" && in1gray.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (true);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (true);
					} else if (currentFruitInHand == "grapefruit" && in1grape.activeInHierarchy) {
						grape.SetActive (true);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (true);
						in1enpty.SetActive (false);

					} else if (currentFruitInHand == "grapefruit" && in1red.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (true);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (true);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "grapefruit" && in1green.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (true);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (true);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "grapefruit" && in1yellow.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (true);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (true);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "grapefruit" && in1black.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (true);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (true);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "grapefruit" && in1gray.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (true);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (true);
					}
				}
			} else {
				if (Input.GetKeyDown (KeyCode.Alpha1) | Input.GetAxis ("360_Triggers") < 0 && hasbeenpressed == false | Input.GetButtonDown ("ps4_L1Button")) {
					hasbeenpressed = true;
					if (currentFruitInHand == "banana" && in1enpty.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (true);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						currentFruitInHand = null;
						isholding = false;
						inven1full = true;
					} else if (currentFruitInHand == "grape" && in1enpty.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (true);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						currentFruitInHand = null;
						isholding = false;
						inven1full = true;
					} else if (currentFruitInHand == "apple" && in1enpty.activeInHierarchy) {
						in1green.SetActive (true);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						currentFruitInHand = null;
						isholding = false;
						inven1full = true;
					} else if (currentFruitInHand == "strawberry" && in1enpty.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (true);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						currentFruitInHand = null;
						isholding = false;
						inven1full = true;
					} else if (currentFruitInHand == "durian" && in1enpty.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (true);
						in1gray.SetActive (false);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						currentFruitInHand = null;
						isholding = false;
						inven1full = true;
					} else if (currentFruitInHand == "grapefruit" && in1enpty.activeInHierarchy) {
						in1green.SetActive (false);
						in1red.SetActive (false);
						in1grape.SetActive (false);
						in1yellow.SetActive (false);
						in1black.SetActive (false);
						in1gray.SetActive (true);
						in1enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						currentFruitInHand = null;
						isholding = false;
						inven1full = true;
					}
				}
			}


			if (inven2full == true) {
				if (Input.GetKeyDown (KeyCode.Alpha2) | Input.GetAxis ("360_Triggers") > 0.5f && hasbeenpressed == false | Input.GetButtonDown ("ps4_R1Button")) {
					hasbeenpressed = true;
					if (currentFruitInHand == "banana" && in2grape.activeInHierarchy) {
						grape.SetActive (true);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (true);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
					} else if (currentFruitInHand == "banana" && in2red.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (true);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (true);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "banana" && in2green.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (true);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (true);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "banana" && in2yellow.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (true);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (true);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "banana" && in2black.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (true);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (true);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "banana" && in2gray.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (true);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (true);
					} else if (currentFruitInHand == null && in2grape.activeInHierarchy) {
						grape.SetActive (true);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (true);
						inven2full = false;
						isholding = true;
					} else if (currentFruitInHand == null && in2red.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (true);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (true);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						inven2full = false;
						isholding = true;
					} else if (currentFruitInHand == null && in2green.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (true);
						grape.SetActive (false);
						apple.SetActive (true);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						inven2full = false;
						isholding = true;
					} else if (currentFruitInHand == null && in2yellow.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (true);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (true);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						inven2full = false;
						isholding = true;
					} else if (currentFruitInHand == null && in2black.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (true);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (true);
						grapeFruit.SetActive (false);
						inven2full = false;
						isholding = true;
					} else if (currentFruitInHand == null && in2gray.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (true);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (true);
						inven2full = false;
						isholding = true;
					} else if (currentFruitInHand == "grape" && in2grape.activeInHierarchy) {
						grape.SetActive (true);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (true);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);

					} else if (currentFruitInHand == "grape" && in2red.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (true);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (true);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "grape" && in2green.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (true);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (true);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "grape" && in2yellow.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (true);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (true);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "grape" && in2black.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (true);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (true);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "grape" && in2gray.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (true);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (true);
					} else if (currentFruitInHand == "apple" && in2grape.activeInHierarchy) {
						grape.SetActive (true);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						in2green.SetActive (true);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);

					} else if (currentFruitInHand == "apple" && in2red.activeInHierarchy) {
						in2green.SetActive (true);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (true);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "apple" && in2green.activeInHierarchy) {
						in2green.SetActive (true);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (true);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "apple" && in2yellow.activeInHierarchy) {
						in2green.SetActive (true);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (true);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "apple" && in2black.activeInHierarchy) {
						in2green.SetActive (true);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (true);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "apple" && in2gray.activeInHierarchy) {
						in2green.SetActive (true);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (true);
					} else if (currentFruitInHand == "strawberry" && in2grape.activeInHierarchy) {
						grape.SetActive (true);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						in2green.SetActive (false);
						in2red.SetActive (true);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);

					} else if (currentFruitInHand == "strawberry" && in2red.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (true);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (true);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "strawberry" && in2green.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (true);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (true);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "strawberry" && in2yellow.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (true);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (true);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "strawberry" && in2black.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (true);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (true);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "strawberry" && in2gray.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (true);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (true);
					} else if (currentFruitInHand == "durian" && in2grape.activeInHierarchy) {
						grape.SetActive (true);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (true);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);

					} else if (currentFruitInHand == "durian" && in2red.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (true);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (true);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "durian" && in2green.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (true);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (true);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "durian" && in2yellow.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (true);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (true);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "durian" && in2black.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (true);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (true);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "durian" && in2gray.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (true);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (true);
					} else if (currentFruitInHand == "grapefruit" && in2grape.activeInHierarchy) {
						grape.SetActive (true);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (true);
						in2enpty.SetActive (false);

					} else if (currentFruitInHand == "grapefruit" && in2red.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (true);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (true);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "grapefruit" && in2green.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (true);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (true);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "grapefruit" && in2yellow.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (true);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (true);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "grapefruit" && in2black.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (true);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (true);
						grapeFruit.SetActive (false);
					} else if (currentFruitInHand == "grapefruit" && in2gray.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (true);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (true);
					}
				}
			} else {
				if (Input.GetKeyDown (KeyCode.Alpha2) | Input.GetAxis ("360_Triggers") > 0.5f && hasbeenpressed == false | Input.GetButtonDown ("ps4_R1Button")) {
					hasbeenpressed = true;
					if (currentFruitInHand == "banana" && in2enpty.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (true);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						currentFruitInHand = null;
						isholding = false;
						inven2full = true;
					} else if (currentFruitInHand == "grape" && in2enpty.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (true);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						currentFruitInHand = null;
						isholding = false;
						inven2full = true;
					} else if (currentFruitInHand == "apple" && in2enpty.activeInHierarchy) {
						in2green.SetActive (true);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						currentFruitInHand = null;
						isholding = false;
						inven2full = true;
					} else if (currentFruitInHand == "strawberry" && in2enpty.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (true);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						currentFruitInHand = null;
						isholding = false;
						inven2full = true;
					} else if (currentFruitInHand == "durian" && in2enpty.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (true);
						in2gray.SetActive (false);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						currentFruitInHand = null;
						isholding = false;
						inven2full = true;
					} else if (currentFruitInHand == "grapefruit" && in2enpty.activeInHierarchy) {
						in2green.SetActive (false);
						in2red.SetActive (false);
						in2grape.SetActive (false);
						in2yellow.SetActive (false);
						in2black.SetActive (false);
						in2gray.SetActive (true);
						in2enpty.SetActive (false);
						grape.SetActive (false);
						apple.SetActive (false);
						strawberry.SetActive (false);
						banana.SetActive (false);
						durian.SetActive (false);
						grapeFruit.SetActive (false);
						currentFruitInHand = null;
						isholding = false;
						inven2full = true;
					}
				}
			}
		}
	}

	*/
	void OnTriggerStay(Collider other)
	{
		GameObject core = GameObject.Find ("CoreGameController");
		CJC_PauseShit pitbull = core.GetComponent<CJC_PauseShit> ();

		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();

		if (!pitbull.paused && !shop.isopen) {
			//if (!jumper.AlreadyInAir) {
				if (other.tag == "Banana") {
					//if (Input.GetKeyDown (KeyCode.Q) | Input.GetButtonDown ("360_YButton") | Input.GetButtonDown ("ps4_TriangleButton")) {
						if (isholding == false && pickedup == false) {
							Destroy (other.gameObject);
							banana.SetActive (true);
							isholding = true;
							grape.SetActive (false);
							apple.SetActive (false);
							strawberry.SetActive (false);
							durian.SetActive (false);
							grapeFruit.SetActive (false);
							pickedup = true;
						}
					//}
				}
				if (other.tag == "Grape") {
					//if (Input.GetKeyDown (KeyCode.Q) | Input.GetButtonDown ("360_YButton") | Input.GetButtonDown ("ps4_TriangleButton")) {
						if (isholding == false && pickedup == false) {
							Destroy (other.gameObject);
							grape.SetActive (true);
							isholding = true;
							apple.SetActive (false);
							strawberry.SetActive (false);
							banana.SetActive (false);
							durian.SetActive (false);
							grapeFruit.SetActive (false);
							pickedup = true;
						} 
					//}
				}
				if (other.tag == "Apple") {
					//if (Input.GetKeyDown (KeyCode.Q) | Input.GetButtonDown ("360_YButton") | Input.GetButtonDown ("ps4_TriangleButton")) {
						if (isholding == false && pickedup == false) {
							Destroy (other.gameObject);
							grape.SetActive (false);
							apple.SetActive (true);
							isholding = true;
							strawberry.SetActive (false);
							banana.SetActive (false);
							durian.SetActive (false);
							grapeFruit.SetActive (false);
							pickedup = true;
						} 
					//}
				}
				if (other.tag == "Strawberry") {
					//if (Input.GetKeyDown (KeyCode.Q) | Input.GetButtonDown ("360_YButton") | Input.GetButtonDown ("ps4_TriangleButton")) {
						if (isholding == false && pickedup == false) {
							Destroy (other.gameObject);
							strawberry.SetActive (true);
							isholding = true;
							grape.SetActive (false);
							apple.SetActive (false);
							banana.SetActive (false);
							durian.SetActive (false);
							grapeFruit.SetActive (false);
							pickedup = true;
						} 
					//}
				}

				if (other.tag == "Durian") {
					//if (Input.GetKeyDown (KeyCode.Q) | Input.GetButtonDown ("360_YButton") | Input.GetButtonDown ("ps4_TriangleButton")) {
						if (isholding == false && pickedup == false) {
							Destroy (other.gameObject);
							strawberry.SetActive (false);
							isholding = true;
							grape.SetActive (false);
							apple.SetActive (false);
							banana.SetActive (false);
							durian.SetActive (true);
							grapeFruit.SetActive (false);
							pickedup = true;
						} 
					//}
				}

				if (other.tag == "GrapeFruit") {
					//if (Input.GetKeyDown (KeyCode.Q) | Input.GetButtonDown ("360_YButton") | Input.GetButtonDown ("ps4_TriangleButton")) {
						if (isholding == false && pickedup == false) {
							Destroy (other.gameObject);
							strawberry.SetActive (false);
							isholding = true;
							grape.SetActive (false);
							apple.SetActive (false);
							banana.SetActive (false);
							durian.SetActive (false);
							grapeFruit.SetActive (true);
							pickedup = true;
						} 
					//}
				}
			//}
		}
	}
}
