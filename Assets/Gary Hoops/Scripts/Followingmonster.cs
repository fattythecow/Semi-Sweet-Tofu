using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
public class Followingmonster : MonoBehaviour
{

	[SerializeField]
	GameObject MagianimHolder = null;
	private Animator MagiAnim = null;
	private bool Chase;
	public bool DeezNutz = false;

	public GameObject Player;
	//public CJC_PlayerAndBools player;

	[SerializeField]
	float MoveSpeed = 2.5f;

	[SerializeField]
	float MinDist = 1f;
	bool tutStarted = false;

	public GameObject text;

	bool GitRekt=false;
	float rotatespeed = 90;
	float magix = 3;
	float magiy = 3;

	void Start()
	{
		MagiAnim = MagianimHolder.GetComponent<Animator> ();
		Player = GameObject.FindWithTag ("Player");
	}

	void Update()
	{
		GameObject core = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools gamecore = core.GetComponent<CJC_PlayerAndBools> ();

		GameObject star = GameObject.FindWithTag ("Player");
		CJC_Starvation Starve = star.GetComponent<CJC_Starvation> ();

		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();
	

		if (shop.isopen == false) {
			FuckingRektScrub ();
			if (text.activeInHierarchy) {
			
				//jumper.PlayerCanJump = false;
				//gamecore.pauseSpeedDebuff = 0;
				//gamecore.SprintingSpeed = 0;
				//Starve.HungerTimer = Starve.HungerTimer;
				//gamecore.SprintStamina = 10;
				tutStarted = true;
			} else if (!text.activeInHierarchy && tutStarted == true) {
				Chase = true;
				MagiAnim.SetBool ("ChasingPlayer", true);
				//gamecore.pauseSpeedDebuff = 1;
				//gamecore.SprintingSpeed = 12;
				//Starve.HungerTimer -= Time.deltaTime * Starve.HungerMultiplier;
				//gamecore.SprintStamina -= Time.deltaTime;
				//jumper.PlayerCanJump = true;
				FollowingPlayer ();
			}
		}
	}

	void GetMagiAnimBools()
	{
		Chase = MagiAnim.GetBool ("ChasingPlayer");
	}

	void FollowingPlayer(){
		GameObject core = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools gamecore = core.GetComponent<CJC_PlayerAndBools> ();

		if (Vector3.Distance(transform.position, Player.transform.position) >= MinDist)
		{
			if (!gamecore.IsSprinting) {
				transform.position = Vector3.MoveTowards (transform.position, Player.transform.position, MoveSpeed * Time.deltaTime);
			} else {
				transform.position = Vector3.MoveTowards (transform.position, Player.transform.position, MoveSpeed * Time.deltaTime * 1.2f);
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		GameObject core = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools gamecore = core.GetComponent<CJC_PlayerAndBools> ();

		if (other.tag == "Player" && !gamecore.PlayerDied) {
			if (!text.activeInHierarchy && tutStarted == true) {
				gamecore.PlayerHealth -= 100;
			}
		}
		else if (other.tag == "MagiHater" && !gamecore.PlayerDied)
		{

			GetComponent<BoxCollider> ().enabled = false;
			gameObject.transform.position = other.transform.position;
			GitRekt = true;
		}
	}

	void FuckingRektScrub()
	{
		

		if (GitRekt)
		{
			DeezNutz = true;
			MoveSpeed = 0;
			gameObject.transform.Rotate (gameObject.transform.rotation.x, gameObject.transform.rotation.y, rotatespeed * Time.deltaTime * 4);
			gameObject.transform.localScale = new Vector3 (magix, magiy, gameObject.transform.localScale.z);
			MagiAnim.speed = 0;
			magix -= Time.deltaTime;
			magiy -= Time.deltaTime;
			if (gameObject.transform.localScale.x <= 0 && gameObject.transform.localScale.y <= 0)
			{

				GetComponent<MeshRenderer> ().enabled = false;
				Destroy (gameObject, .01f);
			}
		}
	}
}
