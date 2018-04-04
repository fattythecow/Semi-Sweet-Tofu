using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_saws : MonoBehaviour
{
	[SerializeField]
	float dps = 1;
	[SerializeField]
	float rotatSpeed = 45;

	bool alreadypassedthrough = false;

	[SerializeField]
	bool IsGreen = false;
	[SerializeField]
	bool IsRed = false;
	[SerializeField]
	bool IsYellow = false;
	[SerializeField]
	bool IsPurple = false;
	[SerializeField]
	GameObject liner = null;

	[SerializeField]
	[Range (0,255)]
	byte visability = 100;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update ()
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		if (player.PlayerDied)
		{

			GetComponent<AudioSource> ().enabled = false;
		}

		CheckForClear ();
		DoRotation ();
		Changecolor ();

	}
	void DoRotation()
	{
		this.transform.Rotate (0, 0, -rotatSpeed * Time.deltaTime, Space.World);
	}

	void Changecolor()
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		if (IsYellow == false && IsGreen == false && IsRed == false && IsPurple == false) 
		{
			GetComponent<MeshRenderer> ().material.color = Color.white;
		}
		else if (IsGreen == true) 
		{
			//wallToColor.GetComponent<MeshRenderer> ().material.color = Color.green;

			if (player.IsGreen) 
			{
				GetComponent<MeshRenderer> ().material.color = new Color32 (0,255,0,visability);
				liner.GetComponent<MeshRenderer> ().enabled = true;
			}
			else if (!player.IsGreen) 
			{
				GetComponent<MeshRenderer> ().material.color = new Color32 (0, 255, 0, 255);
				liner.GetComponent<MeshRenderer> ().enabled = false;
			}
		}
		else if (IsRed == true) 
		{
			if (player.IsRed) 
			{
				GetComponent<MeshRenderer> ().material.color = new Color32 (255,0,0,visability);
				liner.GetComponent<MeshRenderer> ().enabled = true;
			}
			else if (!player.IsRed) 
			{
				GetComponent<MeshRenderer> ().material.color = new Color32 (255, 0, 0, 255);
				liner.GetComponent<MeshRenderer> ().enabled = false;
			}
		}
		else if (IsYellow == true) 
		{
			if (player.IsYellow) 
			{
				GetComponent<MeshRenderer> ().material.color = new Color32 (255,140,20,35);
				liner.GetComponent<MeshRenderer> ().enabled = true;
			}
			else if (!player.IsYellow) 
			{
				GetComponent<MeshRenderer> ().material.color = new Color32 (255,140,20,255);
				liner.GetComponent<MeshRenderer> ().enabled = false;
			}
		}
		else if (IsPurple == true) 
		{
			if (player.IsPurple) 
			{
				GetComponent<MeshRenderer> ().material.color = new Color32 (128,0,128,visability);
				liner.GetComponent<MeshRenderer> ().enabled = true;
			}
			else if (!player.IsPurple) 
			{
				GetComponent<MeshRenderer> ().material.color = new Color32 (128, 0, 128, 255);
				liner.GetComponent<MeshRenderer> ().enabled = false;
			}
		}
	}

	void CheckForClear()
	{
		if (alreadypassedthrough == true)
		{
			GetComponent<CapsuleCollider> ().enabled = false;
		} 
		else if (alreadypassedthrough == false) 
		{
			GetComponent<CapsuleCollider> ().enabled = true;
		}
	}

	void OnTriggerExit (Collider other)
	{
		alreadypassedthrough = false;
		GetComponent<AudioSource> ().enabled = false;
		//wallToColor.GetComponent<BoxCollider> ().enabled = true;
	}

	void OnTriggerStay (Collider other)
	{

		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools damage = p1.GetComponent<CJC_PlayerAndBools> ();
		GameObject healthref = GameObject.Find ("Health");
		CJC_HealthPFI Health = healthref.GetComponent<CJC_HealthPFI> ();
		GameObject sou = GameObject.FindWithTag ("Player");
		CJC_SoundHolder sound = sou.GetComponent<CJC_SoundHolder> ();

		if (other.tag == "Player" && !damage.PlayerDied)
		{
			if (!IsYellow && !IsGreen && !IsRed && !IsPurple)
			{
				if (!damage.IsGreen && !damage.IsRed && !damage.IsYellow && !damage.IsPurple) 
				{
					alreadypassedthrough = true;
					GetComponent<AudioSource> ().enabled = false;
				}
				else  if (damage.IsGreen | damage.IsRed | damage.IsYellow | damage.IsPurple)
				{ 
					damage.PlayerHurt = true;
					GetComponent<AudioSource> ().enabled = true;
					damage.PlayerHealth -= dps;
					CJC_Scoring.PlayerScore -= 1;
					Health.Playerdamaged = true;
				}
			}

			if (IsGreen == true)
			{
				if (damage.IsGreen == true) 
				{
					alreadypassedthrough = true;
					GetComponent<AudioSource> ().enabled = false;
				}
				else  if (!damage.IsGreen)
				{ 
					damage.PlayerHurt = true;
					GetComponent<AudioSource> ().enabled = true;
					damage.PlayerHealth -= dps;
					CJC_Scoring.PlayerScore -= 1;
					Health.Playerdamaged = true;
				}
			} 
			else if (IsRed == true)
			{
				if (damage.IsRed == true)
				{
					alreadypassedthrough = true;
					GetComponent<AudioSource> ().enabled = false;
				}
				else if (!damage.IsRed)
				{ 
					damage.PlayerHurt = true;
					GetComponent<AudioSource> ().enabled = true;
					damage.PlayerHealth -= dps;
					CJC_Scoring.PlayerScore -= 1;
					Health.Playerdamaged = true;
				}
			} 
			else if (IsYellow == true) 
			{
				if (damage.IsYellow == true)
				{
					alreadypassedthrough = true;
					GetComponent<AudioSource> ().enabled = false;
				}
				else  if (!damage.IsYellow)
				{ 
					damage.PlayerHurt = true;
					GetComponent<AudioSource> ().enabled = true;
					damage.PlayerHealth -= dps;
					CJC_Scoring.PlayerScore -= 1;
					Health.Playerdamaged = true;
				}
			} 
			else if (IsPurple == true)
			{
				if (damage.IsPurple == true)
				{
					alreadypassedthrough = true;
					GetComponent<AudioSource> ().enabled = false;
				}
				else  if (!damage.IsPurple)
				{ 
					damage.PlayerHurt = true;
					GetComponent<AudioSource> ().enabled = true;
					damage.PlayerHealth -= dps;
					CJC_Scoring.PlayerScore -= 1;
					Health.Playerdamaged = true;
				}
			} 
		}
	}
}
