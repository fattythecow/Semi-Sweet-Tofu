using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerPFI : MonoBehaviour {

	public bool isreduced = false;
	public bool Playerhealed = false;

	[SerializeField]
	bool IsDamagedWhite = false;
	[SerializeField]
	bool IsdamagedRed = false;

	[SerializeField]
	bool IshealedWhite = false;
	[SerializeField]
	bool IshealedGreen = false;

	[SerializeField]
	float Ishealedtimer = 0;
	[SerializeField]
	float IsHMaxtimer = 0.1f;

	[SerializeField]
	float Isdamagedtimer = 0;
	[SerializeField]
	float IsDMaxtimer = 0.1f;

	[SerializeField]
	float countitup = 0;
	float tellItToStop = .5f;

	[SerializeField]
	float countitupHeal = 0;
	float tellItToStopHeal = .5f;

	// Use this for initialization
	void Start ()
	{
		IsDamagedWhite = true;
		IshealedWhite = true;
	}

	// Update is called once per frame
	void Update ()
	{
		ForceThatShitToBeWhiteLoseHealth ();
		ForceThatShitToBeWhiteGainHealth ();
		ChangeColorsLoseHealth ();
		ChangeColorsGainHealth ();
	}

	void ChangeColorsLoseHealth()
	{
		if (isreduced == true) 
		{
			IshealedGreen= false;
			IshealedWhite = false;
			IsDamagedWhite = false;
			IsdamagedRed = true;

			countitup += Time.deltaTime;
			Isdamagedtimer += Time.deltaTime;



			if (Isdamagedtimer >= IsDMaxtimer && IsdamagedRed == true)
			{
				IsDamagedWhite = true;
				Isdamagedtimer = 0;
				IsdamagedRed = false;
			}
			else if (Isdamagedtimer >= IsDMaxtimer && IsDamagedWhite == true)
			{
				IsdamagedRed = true;
				Isdamagedtimer = 0;
				IsDamagedWhite = false;
			}

			if (countitup >= tellItToStop) 
			{
				IsDamagedWhite = true;
				IsdamagedRed = false;
				countitup = 0;
				isreduced = false;
			}
		}
	}

	void ChangeColorsGainHealth()
	{
		if (Playerhealed == true) 
		{
			IsdamagedRed = false;
			IsDamagedWhite = false;
			IshealedWhite = false;
			IshealedGreen = true;

			countitupHeal += Time.deltaTime;
			Ishealedtimer += Time.deltaTime;



			if (Ishealedtimer >= IsHMaxtimer && IshealedGreen == true)
			{
				IshealedWhite = true;
				Ishealedtimer = 0;
				IshealedGreen = false;
			}
			else if (Ishealedtimer >= IsHMaxtimer && IshealedWhite == true)
			{
				IshealedGreen = true;
				Ishealedtimer = 0;
				IshealedWhite = false;
			}

			if (countitupHeal >= tellItToStopHeal) 
			{
				IshealedWhite = true;
				IshealedGreen = false;
				countitupHeal = 0;
				Playerhealed = false;
			}
		}
	}

	void ForceThatShitToBeWhiteLoseHealth()
	{
		if (IsDamagedWhite == true)
		{
			gameObject.GetComponent<MeshRenderer> ().material.color = Color.white;
			//Debug.Log ("damaged white active");
		}
		else if (IsdamagedRed == true) 
		{
			gameObject.GetComponent<MeshRenderer> ().material.color = Color.green;
			//Debug.Log ("damaged red active");
		}
	}

	void ForceThatShitToBeWhiteGainHealth()
	{
		if (IshealedWhite == true)
		{
			gameObject.GetComponent<MeshRenderer> ().material.color = Color.white;
			//Debug.Log ("white healed active");
		}
		else if (IshealedGreen == true) 
		{
			gameObject.GetComponent<MeshRenderer> ().material.color = Color.green;
			//Debug.Log ("green healed active");
		}
	}

}
