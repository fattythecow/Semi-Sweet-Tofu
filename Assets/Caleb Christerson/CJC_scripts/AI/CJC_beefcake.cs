using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_beefcake : MonoBehaviour {

	bool IsGreen = false;
	bool IsRed = false;
	bool IsYellow = false;
	bool IsPurple = false;
	bool IsDamaged = false;
	float Isdamagedtimer = 0;
	float IsDMaxtimer = .1f;
	bool Isdamagedwhite = true;
	bool IsdamagedRed = false;

	float ColorTimer = 0;
	float ColorMaxTimer = 2;

	int[] colortypes;

	int hitsleft =3;
	float Hittimer = 0;
	float maxhittimer = 1;
	bool HasBeenHit = false;

	public float health = 300;
	public GameObject hitinfo;
	public GameObject hitinfo2;
	public float timer = 0;

	[SerializeField]
	float DPS = 0;
	[SerializeField]
	float damagefromProjectile = 20;
	// Use this for initialization
	void Start () 
	{
		colortypes = new int[4];
		colortypes[0] = 0;
		colortypes[1] = 1;
		colortypes[2] = 2;
		colortypes[3] = 3;
		hitinfo.SetActive (false);
		hitinfo2.SetActive (false);
	}

	// Update is called once per frame
	void Update () 
	{
		UpdateColorTimer ();
		manageColors ();
		Checkforhits ();
		ManageHitCheck ();
		ShowIsDamaged ();
		if (hitinfo.activeInHierarchy && hitinfo2.activeInHierarchy) {
			timer += Time.deltaTime;
			if (timer >= 0.3f) {
				hitinfo.SetActive (false);
				hitinfo2.SetActive (false);
				timer = 0;
			}
		}
	}

	void Changecolors()
	{
		int randIndex = Random.Range (0, colortypes.Length);

		if (randIndex == 0) 
		{
			IsGreen = true;
			IsRed = false;
			IsPurple = false;
			IsYellow = false;
		}
		else if (randIndex == 1) 
		{
			IsGreen = false;
			IsRed = true;
			IsPurple = false;
			IsYellow = false;
		}
		if (randIndex == 2) 
		{
			IsGreen = false;
			IsRed = false;
			IsPurple = true;
			IsYellow = false;
		}
		else if (randIndex == 3) 
		{
			IsGreen = false;
			IsRed = false;
			IsPurple = false;
			IsYellow = true;
		}
	}

	void manageColors()
	{
		if (IsGreen == true) 
		{
			gameObject.GetComponent<MeshRenderer> ().material.color = Color.green;
		} 
		else if (IsRed == true) 
		{
			gameObject.GetComponent<MeshRenderer> ().material.color = Color.red;
		} 
		else if (IsPurple == true) 
		{
			gameObject.GetComponent<MeshRenderer> ().material.color = new Color32 (128, 0, 128, 1);
		} 
		else if (IsYellow == true)
		{
			gameObject.GetComponent<MeshRenderer> ().material.color = Color.yellow;
		}
	}

	void UpdateColorTimer()
	{
		ColorTimer += Time.deltaTime;

		if (ColorTimer >= ColorMaxTimer) 
		{
			Invoke ("Changecolors", 0);
			ColorTimer = 0;
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "PlayerProjectile"  && HasBeenHit == false) 
		{
			Debug.Log("damage");
			health -= damagefromProjectile;
			IsDamaged = true;
			HasBeenHit = true;
			hitinfo.SetActive (true);
			hitinfo2.SetActive (true);
		}
	}

	void OnTriggerStay (Collider other)
	{

		if (other.name == "fire(Concentrated)") {
			health -= DPS;
		}

		//if (other.name == "fire(Environment)") {
		//	Health -= (DPS / 10);
		//}

		if (other.name == "Spike Parent'") {
			health -= (DPS * 7);
		}

		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools damage = p1.GetComponent<CJC_PlayerAndBools> ();
		GameObject healthref = GameObject.Find ("Health");
		CJC_HealthPFI Health = healthref.GetComponent<CJC_HealthPFI> ();
		GameObject scoreref = GameObject.Find ("Score");
		CJC_ScorePFI Score = scoreref.GetComponent<CJC_ScorePFI> ();
		GameObject sou = GameObject.FindWithTag ("Player");
		CJC_SoundHolder sound = sou.GetComponent<CJC_SoundHolder> ();

		if (other.tag == "Player") 
		{
			if (IsPurple == true) 
			{

				if (damage.IsPurple == false && damage.IsSprinting == false && HasBeenHit == false) 
				{
					sound.GetComponent<AudioSource> ().PlayOneShot (sound.DamageFromEnemySound);
					Score.ScoreLost = true;
					damage.PlayerHealth -= 30;
					CJC_Scoring.PlayerScore -= 150;
					health -= 100;
					hitsleft--;
					IsDamaged = true;
					HasBeenHit = true;
					Health.Playerdamaged = true;
				} 
				else if (damage.IsPurple == false && damage.IsSprinting == true && HasBeenHit == false) 
				{
					sound.GetComponent<AudioSource> ().PlayOneShot (sound.DamageFromEnemySound);
					Score.ScoreLost = true;
					damage.PlayerHealth -= 50;
					CJC_Scoring.PlayerScore -= 100;
					hitsleft--;
					health -= 100;
					IsDamaged = true;
					HasBeenHit = true;
					Health.Playerdamaged = true;
				} 
				else if (damage.IsPurple == true && HasBeenHit == false)
				{
					hitsleft--;
					IsDamaged = true;
					health -= 100;
					CJC_Scoring.PlayerScore += 400;
					Score.ScoreGained = true;
					HasBeenHit = true;
				}
			}
			else if (IsGreen == true) 
			{

				if (damage.IsGreen == false && damage.IsSprinting == false && HasBeenHit == false) 
				{
					sound.GetComponent<AudioSource> ().PlayOneShot (sound.DamageFromEnemySound);
					Score.ScoreLost = true;
					damage.PlayerHealth -= 40;
					CJC_Scoring.PlayerScore -= 150;
					hitsleft--;
					IsDamaged = true;
					HasBeenHit = true;
				} 
				else if (damage.IsGreen == false && damage.IsSprinting == true && HasBeenHit == false) 
				{
					sound.GetComponent<AudioSource> ().PlayOneShot (sound.DamageFromEnemySound);
					Score.ScoreLost = true;
					damage.PlayerHealth -= 60;
					CJC_Scoring.PlayerScore -= 100;
					hitsleft--;
					health -= 100;
					IsDamaged = true;
					HasBeenHit = true;
				} 
				else if (damage.IsGreen == true && HasBeenHit == false)
				{
					Score.ScoreGained = true;
					CJC_Scoring.PlayerScore += 400;
					hitsleft--;
					health -= 100;
					IsDamaged = true;
					HasBeenHit = true;
				}
			}
			else if (IsRed == true) 
			{

				if (damage.IsRed == false && damage.IsSprinting == false && HasBeenHit == false) 
				{
					sound.GetComponent<AudioSource> ().PlayOneShot (sound.DamageFromEnemySound);
					Score.ScoreLost = true;
					damage.PlayerHealth -= 40;
					CJC_Scoring.PlayerScore -= 150;
					hitsleft--;
					health -= 100;
					IsDamaged = true;
					HasBeenHit = true;
				} 
				else if (damage.IsRed == false && damage.IsSprinting == true && HasBeenHit == false) 
				{
					sound.GetComponent<AudioSource> ().PlayOneShot (sound.DamageFromEnemySound);
					Score.ScoreLost = true;
					damage.PlayerHealth -= 60;
					CJC_Scoring.PlayerScore -= 100;
					hitsleft--;
					health -= 100;
					IsDamaged = true;
					HasBeenHit = true;
				} 
				else if (damage.IsRed == true && HasBeenHit == false)
				{
					Score.ScoreGained = true;
					hitsleft--;
					health -= 100;
					IsDamaged = true;
					CJC_Scoring.PlayerScore += 400;
					HasBeenHit = true;
				}
			}
			else if (IsYellow == true) 
			{

				if (damage.IsYellow == false && damage.IsSprinting == false && HasBeenHit == false) 
				{
					sound.GetComponent<AudioSource> ().PlayOneShot (sound.DamageFromEnemySound);
					Score.ScoreLost = true;
					hitsleft--;
					IsDamaged = true;
					damage.PlayerHealth -= 40;
					health -= 100;
					CJC_Scoring.PlayerScore -= 150;
					HasBeenHit = true;
				} 
				else if (damage.IsYellow == false && damage.IsSprinting == true && HasBeenHit == false) 
				{
					sound.GetComponent<AudioSource> ().PlayOneShot (sound.DamageFromEnemySound);
					Score.ScoreLost = true;
					hitsleft--;
					IsDamaged = true;
					damage.PlayerHealth -= 60;
					CJC_Scoring.PlayerScore -= 100;
					health -= 100;
					Debug.Log ("damage");
					HasBeenHit = true;
				} 
				else if (damage.IsYellow == true && HasBeenHit == false)
				{
					Score.ScoreGained = true;
					hitsleft--;
					IsDamaged = true;
					health -= 100;
					CJC_Scoring.PlayerScore += 450;
					HasBeenHit = true;
				}
			}
		}

	}

	void Checkforhits ()
	{
		GameObject monster = GameObject.FindWithTag ("Player");
		CJC_Scoring score = monster.GetComponent<CJC_Scoring> ();
		GameObject scoreref = GameObject.Find ("Score");
		CJC_ScorePFI Score = scoreref.GetComponent<CJC_ScorePFI> ();

		if (health <= 0)
		{
			Score.ScoreGained = true;
			CJC_Scoring.PlayerScore += 200;
			Destroy (gameObject);
		}
	}

	void ManageHitCheck()
	{
		if (HasBeenHit == true) 
		{
			Hittimer += Time.deltaTime;

		}

		if (Hittimer >= maxhittimer) 
		{
			IsDamaged = false;
			Invoke ("Changecolors", 0);
			HasBeenHit = false;
			Hittimer = 0;
		}
	}

	void ShowIsDamaged()
	{
		if (IsDamaged == true) 
		{
			IsGreen = false;
			IsRed = false;
			IsYellow = false;
			IsPurple = false;

			Isdamagedtimer += Time.deltaTime;

			if (Isdamagedwhite == true)
			{
				gameObject.GetComponent<MeshRenderer> ().material.color = Color.white;
			}
			else if (IsdamagedRed == true) 
			{
				gameObject.GetComponent<MeshRenderer> ().material.color = Color.red;
			}
				
			if (Isdamagedtimer >= IsDMaxtimer && IsdamagedRed == true)
			{
				Isdamagedwhite = true;
				Isdamagedtimer = 0;
				IsdamagedRed = false;
			}
			else if (Isdamagedtimer >= IsDMaxtimer && Isdamagedwhite == true)
			{
				IsdamagedRed = true;
				Isdamagedtimer = 0;
				Isdamagedwhite = false;
			}
		}
	}
}
