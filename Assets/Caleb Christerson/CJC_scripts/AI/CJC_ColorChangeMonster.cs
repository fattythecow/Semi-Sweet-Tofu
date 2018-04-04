using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_ColorChangeMonster : MonoBehaviour
{
	[SerializeField]
	GameObject ColorChangerAnimHolder = null;
	private Animator ColorAnim = null;

	bool Stunned = false;
	float MaxStunTimer = 1f;
	float CurStunTimer = 0;
	[SerializeField]
	GameObject StunnedOBJ = null;

	bool IsGreen = false;
	bool IsRed = false;
	bool IsYellow = false;
	bool IsPurple = false;

	float ColorTimer = 0;
	float ColorMaxTimer = 1f;

	int[] colortypes;
	bool colorchanged = false;

	public float health = 100;

	[SerializeField]
	GameObject foot1;
	[SerializeField]
	GameObject foot2;

	[SerializeField]
	float DPS = 0;
	//[SerializeField]
	//float damagefromProjectile = 20;
	// Use this for initialization
	void Start () 
	{
		ColorAnim = ColorChangerAnimHolder.GetComponent<Animator> ();

		colortypes = new int[4];
		colortypes[0] = 0;
		colortypes[1] = 1;
		colortypes[2] = 2;
		colortypes[3] = 3;
	}
	
	// Update is called once per frame
	void Update () 
	{
		ManageStunned ();
		//ManageAnimBools ();
		UpdateColorTimer ();
		//manageColors ();
		DestroyMonster ();
		feetprep ();
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

	void ManageAnimBools()
	{
		if (IsGreen)
		{
			ColorAnim.SetBool ("IsGreen", true);
			ColorAnim.SetBool ("IsRed", false);
			ColorAnim.SetBool ("IsPurple", false);
			ColorAnim.SetBool ("IsYellow", false);
			ColorTimer = 0;
			colorchanged = false;
		} 
		else if (IsRed)
		{
			ColorAnim.SetBool ("IsGreen", false);
			ColorAnim.SetBool ("IsRed", true);
			ColorAnim.SetBool ("IsPurple", false);
			ColorAnim.SetBool ("IsYellow", false);
			ColorTimer = 0;
			colorchanged = false;
		} 
		else if (IsYellow)
		{
			ColorAnim.SetBool ("IsGreen", false);
			ColorAnim.SetBool ("IsRed", false);
			ColorAnim.SetBool ("IsPurple", false);
			ColorAnim.SetBool ("IsYellow", true);
			ColorTimer = 0;
			colorchanged = false;
		} 
		else if (IsPurple)
		{
			ColorAnim.SetBool ("IsGreen", false);
			ColorAnim.SetBool ("IsRed", false);
			ColorAnim.SetBool ("IsPurple", true);
			ColorAnim.SetBool ("IsYellow", false);
			ColorTimer = 0;
			colorchanged = false;
		}
	}

	void DestroyMonster(){
		if (health <= 0) {
			Destroy (gameObject);
		}
	}

	void feetprep()
	{
		if (colorchanged)
		{
			if (IsGreen == true) 
			{
				foot1.GetComponent<SpriteRenderer> ().material.color = Color.green;
				foot2.GetComponent<SpriteRenderer> ().material.color = Color.green;
				Invoke ("ManageAnimBools", 1);
			
			} 
			else if (IsRed == true) 
			{
				foot1.GetComponent<SpriteRenderer> ().material.color = Color.red;
				foot2.GetComponent<SpriteRenderer> ().material.color = Color.red;
				Invoke ("ManageAnimBools", 1);
			} 
			else if (IsPurple == true) 
			{
				foot1.GetComponent<SpriteRenderer> ().material.color = new Color32 (128, 0, 128, 255);
				foot2.GetComponent<SpriteRenderer> ().material.color = new Color32 (128, 0, 128, 255);
				Invoke ("ManageAnimBools", 1);
			} 
			else if (IsYellow == true)
			{
				foot1.GetComponent<SpriteRenderer> ().material.color = Color.yellow;
				foot2.GetComponent<SpriteRenderer> ().material.color = Color.yellow;
				Invoke ("ManageAnimBools", 1);
			}

		}
		else if (!colorchanged)
		{
			if (IsGreen == true) 
			{
				foot1.GetComponent<SpriteRenderer> ().material.color = Color.green;
				foot2.GetComponent<SpriteRenderer> ().material.color = Color.green;

			} 
			else if (IsRed == true) 
			{
				foot1.GetComponent<SpriteRenderer> ().material.color = Color.red;
				foot2.GetComponent<SpriteRenderer> ().material.color = Color.red;
			} 
			else if (IsPurple == true) 
			{
				foot1.GetComponent<SpriteRenderer> ().material.color = new Color32 (128, 0, 128, 255);
				foot2.GetComponent<SpriteRenderer> ().material.color = new Color32 (128, 0, 128, 255);
			} 
			else if (IsYellow == true)
			{
				foot1.GetComponent<SpriteRenderer> ().material.color = Color.yellow;
				foot2.GetComponent<SpriteRenderer> ().material.color = Color.yellow;
			}

		}
	}


	void Changecolors()
	{
		if (!colorchanged) {
			int randIndex = Random.Range (0, colortypes.Length);

			if (randIndex == 0) {
				IsGreen = true;
				IsRed = false;
				IsPurple = false;
				IsYellow = false;
				colorchanged = true;
			} else if (randIndex == 1) {
				IsGreen = false;
				IsRed = true;
				IsPurple = false;
				IsYellow = false;
				colorchanged = true;
			}
			if (randIndex == 2) {
				IsGreen = false;
				IsRed = false;
				IsPurple = true;
				IsYellow = false;
				colorchanged = true;
			} else if (randIndex == 3) {
				IsGreen = false;
				IsRed = false;
				IsPurple = false;
				IsYellow = true;
				colorchanged = true;
			}
		}

	}

	void UpdateColorTimer()
	{
		if (!colorchanged) {
			ColorTimer += Time.deltaTime;

			if (ColorTimer >= ColorMaxTimer) {
				Invoke ("Changecolors", 0);
				ColorTimer = 0;
			}
		}
	}


	void OnTriggerStay(Collider other){
		if (other.name == "fire(Concentrated)") {
			health -= DPS;
		}

		//if (other.name == "fire(Environment)") {
		//	Health -= (DPS / 10);
		//}

		if (other.name == "Spike Parent'") {
			health -= (DPS * 7);
		}
	}

	void OnTriggerEnter (Collider other)
	{

		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools damage = p1.GetComponent<CJC_PlayerAndBools> ();
		GameObject healthref = GameObject.Find ("Health");
		CJC_HealthPFI Health = healthref.GetComponent<CJC_HealthPFI> ();

		GameObject sou = GameObject.FindWithTag ("Player");
		CJC_SoundHolder sound = sou.GetComponent<CJC_SoundHolder> ();

		if (other.tag == "Player") 
		{
			if (IsPurple == true) 
			{

				if (damage.IsPurple == false && damage.IsSprinting == false) 
				{
					sound.GetComponent<AudioSource> ().PlayOneShot (sound.DamageFromEnemySound);
					damage.PlayerHurt = true;
					damage.PlayerHealth -= 20;
					CJC_Scoring.PlayerScore -= 150;
					Health.Playerdamaged = true;
					health -= 100;
				} 
				else if (damage.IsPurple == false && damage.IsSprinting == true) 
				{
					sound.GetComponent<AudioSource> ().PlayOneShot (sound.DamageFromEnemySound);
					damage.PlayerHurt = true;
					damage.PlayerHealth -= 30;
					CJC_Scoring.PlayerScore -= 100;
					Health.Playerdamaged = true;
					health -= 100;
				} 
				else if (damage.IsPurple == true)
				{
					
					CJC_Scoring.PlayerScore += 400;
					health -= 100;
				}
			}
			else if (IsGreen == true) 
			{

				if (damage.IsGreen == false && damage.IsSprinting == false) 
				{
					sound.GetComponent<AudioSource> ().PlayOneShot (sound.DamageFromEnemySound);
					damage.PlayerHurt = true;
					damage.PlayerHealth -= 20;
					CJC_Scoring.PlayerScore -= 150;
					Debug.Log ("damage");
					health -= 100;
				} 
				else if (damage.IsGreen == false && damage.IsSprinting == true) 
				{
					sound.GetComponent<AudioSource> ().PlayOneShot (sound.DamageFromEnemySound);
					damage.PlayerHurt = true;
					damage.PlayerHealth -= 30;
					CJC_Scoring.PlayerScore -= 100;
					Debug.Log ("damage");
					health -= 100;
				} 
				else if (damage.IsGreen == true)
				{
					
					CJC_Scoring.PlayerScore += 400;
					health -= 100;
				}
			}
			else if (IsRed == true) 
			{

				if (damage.IsRed == false && damage.IsRed == false) 
				{damage.PlayerHurt = true;
					sound.GetComponent<AudioSource> ().PlayOneShot (sound.DamageFromEnemySound);
					damage.PlayerHealth -= 20;
					CJC_Scoring.PlayerScore -= 150;
					Debug.Log ("damage");
					health -= 100;
				} 
				else if (damage.IsRed == false && damage.IsRed == true) 
				{sound.GetComponent<AudioSource> ().PlayOneShot (sound.DamageFromEnemySound);
					damage.PlayerHurt = true;
					damage.PlayerHealth -= 30;
					CJC_Scoring.PlayerScore -= 100;
					Debug.Log ("damage");
					health -= 100;
				} 
				else if (damage.IsRed == true)
				{
					
					CJC_Scoring.PlayerScore += 400;
					health -= 100;
				}
			}
			else if (IsYellow == true) 
			{

				if (damage.IsYellow == false && damage.IsYellow == false) 
				{sound.GetComponent<AudioSource> ().PlayOneShot (sound.DamageFromEnemySound);
					damage.PlayerHurt = true;
					damage.PlayerHealth -= 20;
					CJC_Scoring.PlayerScore -= 150;
					Debug.Log ("damage");
					health -= 100;
				} 
				else if (damage.IsYellow == false && damage.IsYellow == true) 
				{sound.GetComponent<AudioSource> ().PlayOneShot (sound.DamageFromEnemySound);
					damage.PlayerHurt = true;
					damage.PlayerHealth -= 30;
					CJC_Scoring.PlayerScore -= 100;
					Debug.Log ("damage");
					health -= 100;
				} 
				else if (damage.IsYellow == true)
				{
					
					CJC_Scoring.PlayerScore += 450;
					health -= 100;
				}
			}
   


		}
		else if (other.tag == "PlayerProjectile") 
		{
			Stunned = true;
			//health -= damagefromProjectile;
		}
	}
}
