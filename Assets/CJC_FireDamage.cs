using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_FireDamage : MonoBehaviour {
	[SerializeField]
	float DPS = 0;
	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update ()
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools damage = p1.GetComponent<CJC_PlayerAndBools> ();
		if (damage.PlayerDied)
		{
			GetComponent<AudioSource>().enabled = false;
		}
	}

	void OnTriggerStay (Collider other)
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools damage = p1.GetComponent<CJC_PlayerAndBools> ();
		GameObject healthref = GameObject.Find ("Health");
		CJC_HealthPFI Health = healthref.GetComponent<CJC_HealthPFI> ();
		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();
		GameObject sou = GameObject.FindWithTag ("Player");
		CJC_SoundHolder sound = sou.GetComponent<CJC_SoundHolder> ();

		if (shop.isopen == false && !damage.PlayerDied) {

			if (other.tag == "Player") {
				damage.PlayerHurt = true;
				//sound.GetComponent<AudioSource> ().PlayOneShot (sound.damageFromFire);
				GetComponent<AudioSource>().enabled = true;
				damage.PlayerHealth -= DPS;
				Health.Playerdamaged = true;
			}
		}
	}

	void OnTriggerExit (Collider other)
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools damage = p1.GetComponent<CJC_PlayerAndBools> ();
		GameObject healthref = GameObject.Find ("Health");
		CJC_HealthPFI Health = healthref.GetComponent<CJC_HealthPFI> ();
		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();
		GameObject sou = GameObject.FindWithTag ("Player");
		CJC_SoundHolder sound = sou.GetComponent<CJC_SoundHolder> ();

		if (shop.isopen == false && !damage.PlayerDied) {

			if (other.tag == "Player") {
				GetComponent<AudioSource>().enabled = false;

			}
		}
	}
}
