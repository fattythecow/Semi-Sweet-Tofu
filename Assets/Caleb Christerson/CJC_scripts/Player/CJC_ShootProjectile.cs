using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_ShootProjectile : MonoBehaviour 
{

	bool CanShoot = false;
	[SerializeField]
	float MaxTimer = 10;
	[SerializeField]
	float ShootTimer = 0;
	[SerializeField]
	GameObject Projectile = null;
	[SerializeField]
	GameObject nose = null;
	public bool AllowPlayerToShoot = true; // this will be used to control players being able to shoot at specific times/level
									//to control difficulty of game (have this false in early levels)

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();

		GameObject p1 = GameObject.Find ("Water");
		CJC_InWater player = p1.GetComponent<CJC_InWater> ();

		GameObject p2 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools playeragain = p2.GetComponent<CJC_PlayerAndBools> ();

		if (!playeragain.PlayerDied) {
			if (shop.isopen == false) {

				gameObject.transform.position = nose.transform.position;

				if (AllowPlayerToShoot == true) {
					HandleRecharge ();
					HandleShooting ();
				}
			}
			if (player.inwater) {
				AllowPlayerToShoot = false;
			} else {
				AllowPlayerToShoot = true;
		
			}
		}
	}

	void HandleRecharge()
	{
		ShootTimer += Time.deltaTime;

		if (ShootTimer >= MaxTimer)
		{
			ShootTimer = MaxTimer;
			CanShoot = true;
		} 
		else
			CanShoot = false;
	}

	void HandleShooting()
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_Starvation player = p1.GetComponent<CJC_Starvation> ();
		GameObject p2 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools realplayer = p2.GetComponent<CJC_PlayerAndBools> ();


		GameObject a1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAnimController sauce = a1.GetComponent<CJC_PlayerAnimController> ();
		GameObject sou = GameObject.FindWithTag ("Player");
		CJC_SoundHolder sound = sou.GetComponent<CJC_SoundHolder> ();

		if (CanShoot == true && realplayer.SprintStamina > 0 && !realplayer.SprintExhausted) 
		{
			if (Input.GetKeyDown (KeyCode.F) | Input.GetAxis("360_Triggers") > 0.5f) 
			{
				realplayer.GetComponent<AudioSource> ().PlayOneShot (sound.shootingSound);
				sauce.isshooting = true;
				Instantiate (Projectile, gameObject.transform.position, gameObject.transform.rotation);
				Debug.Log ("shot a mutha fucking fireball, mario up in this bitch");
				ShootTimer = 0;
				realplayer.SprintStamina -= 2 * realplayer.grapestaminaloss;
			}
		}
	}
}
