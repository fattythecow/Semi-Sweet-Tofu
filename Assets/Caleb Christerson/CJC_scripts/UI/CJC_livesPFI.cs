using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_livesPFI : MonoBehaviour 
{
	public bool LiveLost = false;
	public bool LiveGained = false;

	[SerializeField]
	bool ScoreLossWhite = false;
	[SerializeField]
	bool ScoreLossRed = false;

	[SerializeField]
	bool ScoreGainWhite = false;
	[SerializeField]
	bool ScoreGainGreen = false;

	[SerializeField]
	float ScoreGaintimer = 0;
	[SerializeField]
	float ScoreGMaxtimer = 0.1f;

	[SerializeField]
	float ScoreLosstimer = 0;
	[SerializeField]
	float ScoreLMaxtimer = 0.1f;

	[SerializeField]
	float countitupLoss = 0;
	float tellItToStop = .5f;

	[SerializeField]
	float countitupGain = 0;
	float tellItToStopHeal = .5f;

	[SerializeField]
	GameObject LivesLeft1;
	[SerializeField]
	GameObject LivesLeft2;
	[SerializeField]
	GameObject LivesLeft3;
	[SerializeField]
	Material LivesMat1;
	[SerializeField]
	Material LivesMat2;
	[SerializeField]
	Material LivesMat3;

	// Use this for initialization
	void Start ()
	{
		ScoreLossWhite = true;
		ScoreGainWhite = true;
	}

	// Update is called once per frame
	void Update ()
	{
		ForceThatShitToBeWhiteLoseScore ();
		ForceThatShitToBeWhiteGainScore ();
		ChangeColorsLoseScore ();
		ChangeColorsGainScore ();
		ManageNewLives ();
	}

	void ManageNewLives()
	{
		if (CJC_LifeCount.PlayerLives >= 4)
		{
			LivesLeft1.SetActive (true);
			LivesLeft2.SetActive (false);
			LivesLeft3.SetActive (false);
			LivesLeft1.GetComponent<MeshRenderer> ().material = LivesMat3;
			LivesLeft2.GetComponent<MeshRenderer> ().material = LivesMat3;
			LivesLeft3.GetComponent<MeshRenderer> ().material = LivesMat3;
		}
		else if (CJC_LifeCount.PlayerLives == 3)
		{
			LivesLeft1.SetActive (true);
			LivesLeft2.SetActive (true);
			LivesLeft3.SetActive (true);
			LivesLeft1.GetComponent<MeshRenderer> ().material = LivesMat3;
			LivesLeft2.GetComponent<MeshRenderer> ().material = LivesMat3;
			LivesLeft3.GetComponent<MeshRenderer> ().material = LivesMat3;
		}
		else if (CJC_LifeCount.PlayerLives == 2)
		{
			LivesLeft1.SetActive (true);
			LivesLeft2.SetActive (true);
			LivesLeft3.SetActive (false);
			LivesLeft1.GetComponent<MeshRenderer> ().material = LivesMat2;
			LivesLeft2.GetComponent<MeshRenderer> ().material = LivesMat2;
			LivesLeft3.GetComponent<MeshRenderer> ().material = LivesMat2;
		}
		else if (CJC_LifeCount.PlayerLives == 1)
		{
			LivesLeft1.SetActive (true);
			LivesLeft2.SetActive (false);
			LivesLeft3.SetActive (false);
			LivesLeft1.GetComponent<MeshRenderer> ().material = LivesMat1;
			LivesLeft2.GetComponent<MeshRenderer> ().material = LivesMat1;
			LivesLeft3.GetComponent<MeshRenderer> ().material = LivesMat1;
		}
	}



	void ChangeColorsLoseScore()
	{
		if (LiveLost == true) 
		{
			ScoreGainGreen= false;
			ScoreGainWhite = false;
			ScoreLossWhite = false;
			ScoreLossRed = true;

			countitupLoss += Time.deltaTime;
			ScoreLosstimer += Time.deltaTime;



			if (ScoreLosstimer >= ScoreLMaxtimer && ScoreLossRed == true)
			{
				ScoreLossWhite = true;
				ScoreLosstimer = 0;
				ScoreLossRed = false;
			}
			else if (ScoreLosstimer >= ScoreLMaxtimer && ScoreLossWhite == true)
			{
				ScoreLossRed = true;
				ScoreLosstimer = 0;
				ScoreLossWhite = false;
			}

			if (countitupLoss >= tellItToStop) 
			{
				ScoreLossWhite = true;
				ScoreLossRed = false;
				countitupLoss = 0;
				LiveLost = false;
			}
		}
	}

	void ChangeColorsGainScore()
	{
		if (LiveGained == true) 
		{
			ScoreLossRed = false;
			ScoreLossWhite = false;
			ScoreGainWhite = false;
			ScoreGainGreen = true;

			countitupGain += Time.deltaTime;
			ScoreGaintimer += Time.deltaTime;



			if (ScoreGaintimer >= ScoreGMaxtimer && ScoreGainGreen == true)
			{
				ScoreGainWhite = true;
				ScoreGaintimer = 0;
				ScoreGainGreen = false;
			}
			else if (ScoreGaintimer >= ScoreGMaxtimer && ScoreGainWhite == true)
			{
				ScoreGainGreen = true;
				ScoreGaintimer = 0;
				ScoreGainWhite = false;
			}

			if (countitupGain >= tellItToStopHeal) 
			{
				ScoreGainWhite = true;
				ScoreGainGreen = false;
				countitupGain = 0;
				LiveGained = false;
			}
		}
	}

	void ForceThatShitToBeWhiteLoseScore()
	{
		if (ScoreLossWhite == true)
		{
			gameObject.GetComponent<MeshRenderer> ().material.color = new Color32 (128,21,21,255);
			//Debug.Log ("damaged white active");
		}
		else if (ScoreLossRed == true) 
		{
			gameObject.GetComponent<MeshRenderer> ().material.color = Color.red;
			//Debug.Log ("damaged red active");
		}
	}

	void ForceThatShitToBeWhiteGainScore()
	{
		if (ScoreGainWhite == true)
		{
			gameObject.GetComponent<MeshRenderer> ().material.color = new Color32 (128,21,21,255);
			//Debug.Log ("white healed active");
		}
		else if (ScoreGainGreen == true) 
		{
			gameObject.GetComponent<MeshRenderer> ().material.color = Color.green;
			//Debug.Log ("green healed active");
		}
	}

}
