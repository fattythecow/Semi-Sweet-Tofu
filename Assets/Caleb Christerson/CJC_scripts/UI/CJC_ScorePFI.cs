using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_ScorePFI : MonoBehaviour {
public bool ScoreLost = false;
public bool ScoreGained = false;

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
}

	void ChangeColorsLoseScore()
{
		if (ScoreLost == true) 
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
				ScoreLost = false;
		}
	}
}

	void ChangeColorsGainScore()
{
		if (ScoreGained == true) 
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
				ScoreGained = false;
		}
	}
}

void ForceThatShitToBeWhiteLoseScore()
{
		if (ScoreLossWhite == true)
	{
		gameObject.GetComponent<MeshRenderer> ().material.color = Color.white;
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
		gameObject.GetComponent<MeshRenderer> ().material.color = Color.white;
		//Debug.Log ("white healed active");
	}
		else if (ScoreGainGreen == true) 
	{
		gameObject.GetComponent<MeshRenderer> ().material.color = Color.green;
		//Debug.Log ("green healed active");
	}
}

}