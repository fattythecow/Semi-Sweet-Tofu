using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Purple_Monster : MonoBehaviour {
	[SerializeField]
	GameObject ColorChangerAnimHolder = null;
	private Animator ColorAnim = null;
	public float Health = 100;
	//[SerializeField]
	//float damagefromProjectile = 20;
	[SerializeField]
	float DPS = 0;
	public GameObject hitinfo;
	public GameObject hitinfo2;
	public float timer = 0;

	bool Stunned = false;
	float MaxStunTimer = 1f;
	float CurStunTimer = 0;
	[SerializeField]
	GameObject StunnedOBJ = null;

	// Use this for initialization
	void Start () {
		hitinfo.SetActive (false);
		hitinfo2.SetActive (false);
		ColorAnim = ColorChangerAnimHolder.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		ManageStunned ();
		DestroyMonster ();

		//if (hitinfo.activeInHierarchy && hitinfo2.activeInHierarchy) {
		//	timer += Time.deltaTime;
			//if (timer >= 0.3f) {
			//	hitinfo.SetActive (false);
			//	hitinfo2.SetActive (false);
			//	timer = 0;
			//}
		//}
	}

	void ManageStunned()
	{
		if (Stunned)
		{
			ColorAnim.speed = 0;
			StunnedOBJ.SetActive (true);
			CurStunTimer += Time.deltaTime;
			if (CurStunTimer >= MaxStunTimer)
			{
				Stunned = false;
				CurStunTimer = 0;
			}
		}
		else if (!Stunned)
		{
			ColorAnim.speed = 1;
			StunnedOBJ.SetActive (false);
			CurStunTimer = 0;
		}


	}

	void DestroyMonster(){
		if (Health <= 0) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter (Collider other)
	{
		GameObject sou = GameObject.FindWithTag ("Player");
		CJC_SoundHolder sound = sou.GetComponent<CJC_SoundHolder> ();
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools damage = p1.GetComponent<CJC_PlayerAndBools> ();
		GameObject healthref = GameObject.Find ("Health");
		CJC_HealthPFI health = healthref.GetComponent<CJC_HealthPFI> ();


		if (other.tag == "Player") {

			if (damage.IsPurple == false && damage.IsSprinting == false)
			{
				sound.GetComponent<AudioSource> ().PlayOneShot (sound.DamageFromEnemySound);
				damage.PlayerHurt = true;
				damage.PlayerHealth -= 20;
				CJC_Scoring.PlayerScore -= 150;
				Health -= 100;
				health.Playerdamaged = true;
			}
			else if (damage.IsPurple == false && damage.IsSprinting == true)
			{
				sound.GetComponent<AudioSource> ().PlayOneShot (sound.DamageFromEnemySound);
				damage.PlayerHurt = true;
				damage.PlayerHealth -= 30;
				CJC_Scoring.PlayerScore -= 150;
				Health -= 100;
				health.Playerdamaged = true;
			}

			else if (damage.IsPurple == true)
			{
				Health -= 100;
				CJC_Scoring.PlayerScore += 150;

			}
		}
		else if (other.tag == "PlayerProjectile") 
		{Stunned = true;
			//Health -= damagefromProjectile;
			//hitinfo.SetActive (true);
			//hitinfo2.SetActive (true);
		}

	}

	void OnTriggerStay(Collider other){
		if (other.name == "fire(Concentrated)") {
			Health -= DPS;
		}

		//if (other.name == "fire(Environment)") {
		//	Health -= (DPS / 10);
		//}

		if (other.name == "Spike Parent'") {
			Health -= (DPS * 7);
		}
	}
}
	

