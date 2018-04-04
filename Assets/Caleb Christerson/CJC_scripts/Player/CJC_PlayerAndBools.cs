using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CJC_PlayerAndBools : MonoBehaviour
{

	CharacterController contorller;
	public float NormalMoveSpeed = 8f;
	public float speedStarvingMultiplier = 1;
	float BannanaSpeedBuff = 1;
	public float SprintingSpeed = 12f;
	public float SpeedDebuff = 1;
	public float pauseSpeedDebuff =1;

	public float grapestaminabuff = 1;
	public float grapestaminaloss = 1;
	public float strawberryhealthregenbuff = 1;



	public bool IsGreen = false;
	public bool IsRed = false;
	public bool IsYellow = false;
	public bool IsPurple = false;

	public float PlayerHealth = 100;
	public bool PlayerDied = false;


	[SerializeField]
	GameObject SpawnPoint = null;


	public bool IsSprinting = false;
	public float SprintStamina = 10;
	public float staminastarvingmultiplier = 1;
	float MaxStamina = 10;
	public bool SprintExhausted = false;
	public float ExhaustionTimer = 0;
	[SerializeField]
	float ExhaustionTimerMax = 2.5f;

	public float starvingjumpheightmultipleer = 1;
	public float applejumpBuff = 1;

	public bool OnGround = true;

	public GameObject sprintjump;

	[SerializeField]
	GameObject HealthBar = null;

	[SerializeField]
	GameObject StaminaBar = null;
	[SerializeField]
	GameObject exhaustedLeft = null;

	public string RestartLevel = "";

	public bool SprintKillSwitch = false;

	public bool cantmovehor = false;

	public GameObject checkpiintPFI;

	public float checkpointtimer = 0;

	public bool PlayerHurt = false;
	float playerhurttimer = 0;
	float playerhurtmaxtimer = 1;
	public bool playerBurning = false;

	public bool cpPFI;

	public bool itsfirsttime = true;

	// Use this for initialization
	void Start () 
	{
		PlayerDied = false;
		contorller = GetComponent<CharacterController> ();
		HandleStaringAbilities ();
		Ladder.willClimb = false;
	}

	void HandleStaringAbilities()
	{
		//GameObject telepp = GameObject.Find ("TeleportSpot");
		//CJC_manageTeleport tele = telepp.GetComponent<CJC_manageTeleport> ();

		GameObject p2 = GameObject.Find ("shooter");
		CJC_ShootProjectile shot = p2.GetComponent<CJC_ShootProjectile> ();

		if (RestartLevel == "PieSlice1") {
			if (!CJC_LevelTranSition.finishLevel) {
				GoCheckPointT ();
			}
		}
		if (RestartLevel == "PieSlice2") 
		{
			//CJC_manageTeleport.KnowsTeleport = true;
			if (!exitLevel1.finishLevel) {
				GoCheckPoint ();
			} 
		}
		if (RestartLevel == "PieSlice3") 
		{
			shot.AllowPlayerToShoot = true;

			if (!exitlevel2.finishLevel) {
				GoCheckPoint2 ();
			} 
		}

		if (RestartLevel == "Level3") {
			shot.AllowPlayerToShoot = true;


			if (!exitlevelagain.finishLevel) {
				GoCheckPoint3 ();
			} 
		}

		if (RestartLevel == "Level4") {
			shot.AllowPlayerToShoot = true;

			if (!exitlevel4.finishLevel) {
				GoCheckPoint4 ();
			} 
		}

		if (RestartLevel == "Level5") {
			shot.AllowPlayerToShoot = true;


			if (!exitlevel5.finishLevel) {
				GoCheckPoint5 ();
			} 
		}
		if (RestartLevel == "Level6") {
			shot.AllowPlayerToShoot = true;


			if (!exitlevel6.finishLevel) {
				GoCheckPoint6 ();
			} 
		}
	}
	void GoCheckPointT(){
		GameObject checky = GameObject.Find ("Checkpoint25");
		if (checky != null) {
			Checkpoint checkpointy = checky.GetComponent<Checkpoint> ();
		}

		if (Checkpoint.reachedcheckpoint25) {
			SpawnPoint.transform.position = checky.transform.position;
			gameObject.transform.position = SpawnPoint.transform.position;
		}else
		{
			if (SpawnPoint != null)
				gameObject.transform.position = SpawnPoint.transform.position;
		}
	}

	void GoCheckPoint(){
		GameObject checky = GameObject.Find ("GIVEMEEVERYTHING");
		if (checky != null) {
			Checkpoint checkpointy = checky.GetComponent<Checkpoint> ();
		}

		if (Checkpoint.reachedCheckpoint) {
			SpawnPoint.transform.position = checky.transform.position;
			gameObject.transform.position = SpawnPoint.transform.position;
		} else if (Checkpoint.reachedCheckpoint2) {
			checky = GameObject.Find ("MRWW");
			SpawnPoint.transform.position = checky.transform.position;
			gameObject.transform.position = SpawnPoint.transform.position;
		} else
		{
			if (SpawnPoint != null)
				gameObject.transform.position = SpawnPoint.transform.position;
		}

	}

	void GoCheckPoint2(){
		GameObject checky = GameObject.Find ("Checkpoint3");
		if (checky != null) {
			Checkpoint checkpointy = checky.GetComponent<Checkpoint> ();
		}

		if (Checkpoint.reachedCheckpoint3) {
			checky = GameObject.Find ("Checkpoint3");
			SpawnPoint.transform.position = checky.transform.position;
			gameObject.transform.position = SpawnPoint.transform.position;
		} else if (Checkpoint.reachedcheckpoint4) {
			checky = GameObject.Find ("checkpointyourface");
			SpawnPoint.transform.position = checky.transform.position;
			gameObject.transform.position = SpawnPoint.transform.position;
		} else if (Checkpoint.reachedcheckpoint5) {
			checky = GameObject.Find ("Checkpoint5");
			SpawnPoint.transform.position = checky.transform.position;
			gameObject.transform.position = SpawnPoint.transform.position;
		} else if (Checkpoint.reachedcheckpoint6) {
			checky = GameObject.Find ("Mr305");
			SpawnPoint.transform.position = checky.transform.position;
			gameObject.transform.position = SpawnPoint.transform.position;
		} else
		{
			if (SpawnPoint != null)
				gameObject.transform.position = SpawnPoint.transform.position;
		}
	}

	void GoCheckPoint3(){
		GameObject checky = GameObject.Find ("Checkpoint7");
		if (checky != null) {
			Checkpoint checkpointy = checky.GetComponent<Checkpoint> ();
		}

		if (Checkpoint.reachedcheckpoint7) {
			checky = GameObject.Find ("Checkpoint7");
			SpawnPoint.transform.position = checky.transform.position;
			gameObject.transform.position = SpawnPoint.transform.position;
		} else if (Checkpoint.reachedcheckpoint8) {
			checky = GameObject.Find ("Checkpoint8");
			SpawnPoint.transform.position = checky.transform.position;
			gameObject.transform.position = SpawnPoint.transform.position;
		} else if (Checkpoint.reachedcheckpoint9) {
			checky = GameObject.Find ("Checkpoint9");
			SpawnPoint.transform.position = checky.transform.position;
			gameObject.transform.position = SpawnPoint.transform.position;
		} else if (Checkpoint.reachedcheckpoint10) {
			checky = GameObject.Find ("Checkpoint10");
			SpawnPoint.transform.position = checky.transform.position;
			gameObject.transform.position = SpawnPoint.transform.position;
		}else if (Checkpoint.reachedcheckpoint11) {
			checky = GameObject.Find ("Checkpoint11");
			SpawnPoint.transform.position = checky.transform.position;
			gameObject.transform.position = SpawnPoint.transform.position;
		} 
		else
		{
			if (SpawnPoint != null)
				gameObject.transform.position = SpawnPoint.transform.position;
		}
	}

	void GoCheckPoint4(){
		GameObject checky = GameObject.Find ("Checkpoint16");
		if (checky != null) {
			Checkpoint checkpointy = checky.GetComponent<Checkpoint> ();
		}

		if (Checkpoint.reachedcheckpoint16) {
			checky = GameObject.Find ("Checkpoint16");
			SpawnPoint.transform.position = checky.transform.position;
			gameObject.transform.position = SpawnPoint.transform.position;
		} else if (Checkpoint.reachedcheckpoint17) {
			checky = GameObject.Find ("Checkpoint17");
			SpawnPoint.transform.position = checky.transform.position;
			gameObject.transform.position = SpawnPoint.transform.position;
		} else if (Checkpoint.reachedcheckpoint18) {
			checky = GameObject.Find ("Checkpoint18");
			SpawnPoint.transform.position = checky.transform.position;
			gameObject.transform.position = SpawnPoint.transform.position;
		} else if (Checkpoint.reachedcheckpoint19) {
			checky = GameObject.Find ("Checkpoint19");
			SpawnPoint.transform.position = checky.transform.position;
			gameObject.transform.position = SpawnPoint.transform.position;
		}else if (Checkpoint.reachedcheckpoint20) {
			checky = GameObject.Find ("Checkpoint20");
			SpawnPoint.transform.position = checky.transform.position;
			gameObject.transform.position = SpawnPoint.transform.position;
		} 
		else
		{
			if (SpawnPoint != null)
				gameObject.transform.position = SpawnPoint.transform.position;
		}
	}

	void GoCheckPoint5(){
		GameObject checky = GameObject.Find ("Checkpoint12");
		if (checky != null) {
			Checkpoint checkpointy = checky.GetComponent<Checkpoint> ();
		}

		if (Checkpoint.reachedcheckpoint12) {
			checky = GameObject.Find ("Checkpoint12");
			SpawnPoint.transform.position = checky.transform.position;
			gameObject.transform.position = SpawnPoint.transform.position;
		} else if (Checkpoint.reachedcheckpoint13) {
			checky = GameObject.Find ("Checkpoint13");
			SpawnPoint.transform.position = checky.transform.position;
			gameObject.transform.position = SpawnPoint.transform.position;
		} else if (Checkpoint.reachedcheckpoint14) {
			checky = GameObject.Find ("Checkpoint14");
			SpawnPoint.transform.position = checky.transform.position;
			gameObject.transform.position = SpawnPoint.transform.position;
		} else if (Checkpoint.reachedcheckpoint15) {
			checky = GameObject.Find ("Checkpoint15");
			SpawnPoint.transform.position = checky.transform.position;
			gameObject.transform.position = SpawnPoint.transform.position;
		}
		else
		{
			if (SpawnPoint != null)
				gameObject.transform.position = SpawnPoint.transform.position;
		}
	}

	void GoCheckPoint6(){
		GameObject checky = GameObject.Find ("Checkpoint21");
		if (checky != null) {
			Checkpoint checkpointy = checky.GetComponent<Checkpoint> ();
		}

		if (Checkpoint.reachedcheckpoint21) {
			checky = GameObject.Find ("Checkpoint21");
			SpawnPoint.transform.position = checky.transform.position;
			gameObject.transform.position = SpawnPoint.transform.position;
		} else if (Checkpoint.reachedcheckpoint22) {
			checky = GameObject.Find ("Checkpoint22");
			SpawnPoint.transform.position = checky.transform.position;
			gameObject.transform.position = SpawnPoint.transform.position;
		} else if (Checkpoint.reachedcheckpoint23) {
			checky = GameObject.Find ("Checkpoint23");
			SpawnPoint.transform.position = checky.transform.position;
			gameObject.transform.position = SpawnPoint.transform.position;
		} else if (Checkpoint.reachedcheckpoint24) {
			checky = GameObject.Find ("Checkpoint24");
			SpawnPoint.transform.position = checky.transform.position;
			gameObject.transform.position = SpawnPoint.transform.position;
		}
		else
		{
			if (SpawnPoint != null)
				gameObject.transform.position = SpawnPoint.transform.position;
		}
	}



	// Update is called once per frame
	void Update ()
	{

		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();

		GameObject p1 = GameObject.Find ("Ladder");
		Ladder player = p1.GetComponent<Ladder> ();
		GameObject dir = GameObject.FindWithTag ("Player");
		CJC_PlayerAnimController anim = dir.GetComponent<CJC_PlayerAnimController> ();

		GameObject p2 = GameObject.FindWithTag ("Player");
		CJC_Starvation player2 = p2.GetComponent<CJC_Starvation> ();

		//DoDeath ();
		//HandleHealth ();
		HandleHealth ();
		HandleHurt ();
		if (shop.isopen == false && !PlayerDied && !anim.animCompletedLevel)
		{
			if (!cantmovehor && !CJC_InGameXboxUISelector.hastoshowcontrols && !CJC_ButtonPressFIX.nocontrols) {
				handlemovement ();
			}
			HandleColors ();
			//HandleHealth ();

			if (SprintKillSwitch == false && !player2.IsStarving)
			{
				HandleSprinting ();
				sprintjump.GetComponent<TrailRenderer> ().time = 0;
				if (IsSprinting) {
					sprintjump.GetComponent<TrailRenderer> ().time = 1.25f;
				}
				else
				{
					sprintjump.GetComponent<TrailRenderer> ().time -= Time.deltaTime*3;

					if (sprintjump.GetComponent<TrailRenderer> ().time <= 0)
						sprintjump.GetComponent<TrailRenderer> ().time = 0;
				}
			}
		}

		if (checkpiintPFI.activeInHierarchy) {
			checkpointtimer += Time.deltaTime;
			if (checkpointtimer >= 3f) {
				checkpiintPFI.SetActive (false);
				cpPFI = false;
				itsfirsttime = false;
				checkpointtimer = 0;
			}
		}

		if (cpPFI && itsfirsttime) {
			checkpiintPFI.SetActive (true);
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "checkpoint" && !PlayerDied) {
			//checkpiintPFI.SetActive (true);
			cpPFI = true;
		}

		if (other.tag == "Fire")
		{
			playerBurning = true;
		}

		if (other.tag == "resumeCP") {
			itsfirsttime = true;
			other.gameObject.SetActive (false);
		}
	}


	void OnTriggerStay(Collider other){
		if (other.name == "Ladder" && !PlayerDied) {
			cantmovehor = true;
		}
	}

	void OnTriggerExit(Collider other){
		if (other.name == "Ladder" && !PlayerDied) {
			cantmovehor = false;
		}

		if (other.tag == "Fire")
		{
			playerBurning = false;
		}
	}


	void handlemovement()
	{ if (!PlayerDied)
		{
		//transform.Translate (Input.GetAxis ("Horizontal") * Time.deltaTime * NormalMoveSpeed, 0, 0);
		transform.position = new Vector3 (transform.position.x, transform.position.y, 0);
		//movement.x = Input.GetAxis ("Horizontal") * Time.deltaTime * NormalMoveSpeed;
		//gameObject.transform.Translate (movement);
		}
	}

	void HandleHurt()
	{
		if (PlayerHurt && !PlayerDied)
		{
			playerhurttimer += Time.deltaTime;
			if (playerhurttimer >= playerhurtmaxtimer)
			{
				playerhurttimer = 0;
				PlayerHurt = false;
			}
		}
	}



	void HandleSprinting()
	{
		if (!PlayerDied)
		{
			ExhaustionTimerMax = MaxStamina / 4;

			if (SprintStamina >= MaxStamina)
			{
				SprintStamina = MaxStamina;
			} else if (SprintStamina < 0)
			{
				SprintExhausted = true;
				SprintStamina = 0;
			}

			GameObject starvation = GameObject.FindWithTag ("Player");
			CJC_Starvation StarvinMarvin = starvation.GetComponent<CJC_Starvation> ();

			GameObject jumpin = GameObject.FindWithTag ("Player");
			CJC_tryjumping jumper = jumpin.GetComponent<CJC_tryjumping> ();

			if (jumper.PlayerInWater)
			{
				IsSprinting = false;
			}

			StaminaBar.transform.localScale = new Vector3 ((SprintStamina / MaxStamina) * 2.3f, .2f, .01f);

			if (jumper.AlreadyInAir == false)
			{

				if (Input.GetKey (KeyCode.LeftShift) && SprintStamina > 0 && SprintExhausted == false)
				{
					IsSprinting = true;
				} 
			//else if (Input.GetButton ("360_XButton") && SprintStamina > 0 && SprintExhausted == false)
			else if (Input.GetAxis ("360_Triggers") < 0 && SprintStamina > 0 && SprintExhausted == false)
				{
					IsSprinting = true;
				} else if (Input.GetButton ("ps4_SquareButton") && SprintStamina > 0 && SprintExhausted == false)
				{
					IsSprinting = true;
				} 
				else 
				{
					IsSprinting = false;
				}
			}

			if (IsSprinting == true && SprintExhausted == false && Input.GetAxis ("Horizontal") > 0.1f) {
				//StarvinMarvin.HungerMultiplier = 2;
				SprintStamina -= Time.deltaTime * 1.5f * grapestaminaloss;
				NormalMoveSpeed = SprintingSpeed * speedStarvingMultiplier * BannanaSpeedBuff * SpeedDebuff;

				if (SprintStamina <= 0) {
					SprintExhausted = true;
				}
				//else if (SprintStamina >= MaxStamina)
				//{
				//	SprintStamina = MaxStamina;
				//}
			} else if (IsSprinting == true && SprintExhausted == false && Input.GetAxis ("Horizontal") < 0f) {
				//StarvinMarvin.HungerMultiplier = 2;
				SprintStamina -= Time.deltaTime * 1.5f * grapestaminaloss;
				NormalMoveSpeed = SprintingSpeed * speedStarvingMultiplier * BannanaSpeedBuff * SpeedDebuff;

				if (SprintStamina <= 0) {
					SprintExhausted = true;
				}
				//	else if (SprintStamina >= MaxStamina)
				//	{
				//	SprintStamina = MaxStamina;
				//}
			} 
			else if (IsSprinting == false && !SprintExhausted)
			{
				//StarvinMarvin.HungerMultiplier = 1;
				NormalMoveSpeed = 8f * speedStarvingMultiplier * BannanaSpeedBuff * SpeedDebuff * pauseSpeedDebuff;
				SprintStamina += Time.deltaTime * staminastarvingmultiplier * grapestaminabuff;

				//if (SprintStamina >= MaxStamina)
				//{
				//	SprintStamina = MaxStamina;
				//}
			}

			if (SprintExhausted == true)
			{
				IsSprinting = false;
				exhaustedLeft.GetComponent<MeshRenderer> ().enabled = true;
				SprintStamina += Time.deltaTime * staminastarvingmultiplier * grapestaminabuff * 2;
				StarvinMarvin.HungerMultiplier = 1;
				ExhaustionTimer += Time.deltaTime * staminastarvingmultiplier * grapestaminabuff * 2;

				if (ExhaustionTimer >= ExhaustionTimerMax) {
					ExhaustionTimer = 0;
					SprintExhausted = false;
				}
			} 
			else if (SprintExhausted == false) {
				exhaustedLeft.GetComponent<MeshRenderer> ().enabled = false;
			}
		}
	}

	void FixedUpdate()
	{if (!PlayerDied) {
			if (PlayerHealth < 100)
				PlayerHealth += strawberryhealthregenbuff * Time.deltaTime;
		}
	}

	void HandleColors()
	{
		if (!PlayerDied) {
			if (IsYellow == false && IsGreen == false && IsRed == false && IsPurple == false) {
				//gameObject.GetComponent<MeshRenderer> ().material.color = Color.white;
				applejumpBuff = 1;
				BannanaSpeedBuff = 1;
				strawberryhealthregenbuff = 0;
				grapestaminabuff = 1;
				grapestaminaloss = 1;
			} else if (IsGreen == true) {
				//gameObject.GetComponent<MeshRenderer> ().material.color = Color.green;
				applejumpBuff = 1.3f;
				BannanaSpeedBuff = 1;
				strawberryhealthregenbuff = 0;
				grapestaminabuff = 1;
				grapestaminaloss = 1;
			} else if (IsRed == true) {
				//gameObject.GetComponent<MeshRenderer> ().material.color = Color.red;
				applejumpBuff = 1;
				BannanaSpeedBuff = 1;
				strawberryhealthregenbuff = 1.25f;
				grapestaminabuff = 1;
				grapestaminaloss = 1;
			} else if (IsYellow == true) {
				//gameObject.GetComponent<MeshRenderer> ().material.color = Color.yellow;
				applejumpBuff = 1;
				BannanaSpeedBuff = 1.15f;
				strawberryhealthregenbuff = 0;
				grapestaminabuff = 1;
				grapestaminaloss = 1;
			} else if (IsPurple == true) {
				//gameObject.GetComponent<MeshRenderer> ().material.color = new Color32 (128, 0, 128, 1);
				applejumpBuff = 1;
				BannanaSpeedBuff = 1;
				strawberryhealthregenbuff = 0;
				grapestaminabuff = 1.5f;
				grapestaminaloss = .75f;
			}
		}
	}

	void HandleHealth()
	{
		GameObject livess = GameObject.Find ("Lives");
		CJC_livesPFI lives = livess.GetComponent<CJC_livesPFI> ();

		HealthBar.transform.localScale = new Vector3 ((PlayerHealth / 100) * 2.3f, .2f, .01f);
		if (PlayerHealth > 100)
			PlayerHealth = 100;

		if (PlayerHealth <= 0)
		{
			PlayerHealth = 0;

			//Invoke ("DoDeath", .5f);
			PlayerDied = true;
		}
	}

	void DoDeath()
	{
		GameObject livess = GameObject.Find ("Lives");
		CJC_livesPFI lives = livess.GetComponent<CJC_livesPFI> ();
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_Starvation Starve = p1.GetComponent<CJC_Starvation> ();
		GameObject sou = GameObject.FindWithTag ("Player");
		CJC_SoundHolder sound = sou.GetComponent<CJC_SoundHolder> ();


		//if (PlayerDied == true) 
		//{  
		//lives.LiveGained = false;

			//sound.GetComponent<AudioSource> ().PlayOneShot (sound.DyingSound);
			CJC_LifeCount.PlayerLives -= 1;
			if (PlayerCoins.playerCoins % 2 == 0)
				PlayerCoins.playerCoins = PlayerCoins.playerCoins / 2;
			else 
				PlayerCoins.playerCoins = (PlayerCoins.playerCoins + 1) / 2;

		Invoke("RestartLevelAfterDeath",.5f);
		//}
	}

	void RestartLevelAfterDeath()
	{
		SceneManager.LoadScene (RestartLevel);
	}
}
