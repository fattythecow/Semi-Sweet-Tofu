using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;

public class CJC_HUD : MonoBehaviour 
{
	public TextMesh LivesTextMesh;
	private string livesText;

	public TextMesh HealthTextMesh;
	private string healthText;

	public TextMesh HungerTextMesh;
	private string hungerText;

	public TextMesh TimeTextMesh;
	private string timeText;

	public TextMesh starTextMesh1;
	private string startext1;

	public TextMesh starTextMesh2;
	private string startext2;

	public TextMesh starTextMesh3;
	private string startext3;

	[SerializeField]
	GameObject OutOfStamina = null;

	[SerializeField]
	GameObject HungerBar = null;
	[SerializeField]
	GameObject hungerFillerBar = null;
	[SerializeField]
	GameObject hungerblackbox = null;

	[SerializeField]
	GameObject sprintbox;
	[SerializeField]
	GameObject sprint;

	// Use this for initialization
	void Start ()
	{
		livesText = LivesTextMesh.text;
		healthText = HealthTextMesh.text;
		hungerText = HungerTextMesh.text;
		timeText = TimeTextMesh.text;
		startext1 = starTextMesh1.text;
		startext2 = starTextMesh2.text;
		startext3 = starTextMesh3.text;
		//HungerBar.transform.localScale = new Vector3 (1.53f, .2f, .01f);
	}
	
	// Update is called once per frame
	void Update ()
	{
		GameObject star = GameObject.FindWithTag ("Player");
		CJC_Starvation Starve = star.GetComponent<CJC_Starvation> ();

		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		GameObject p2 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools realplayer = p2.GetComponent<CJC_PlayerAndBools> ();

		if (realplayer.SprintStamina < 10)
		{
			sprint.SetActive (true);
			sprintbox.SetActive (true);
		}
		else if (realplayer.SprintStamina >= 10)
		{
			sprint.SetActive (false);
			sprintbox.SetActive (false);
		}
		//sprint.transform.position = new Vector3 (realplayer.transform.position.x, realplayer.transform.position.y, sprint.transform.position.z);
		//sprintbox.transform.position = new Vector3 (realplayer.transform.position.x, realplayer.transform.position.y, sprintbox.transform.position.z);

		Updatestartimer ();
		//UpdateHealth (player.PlayerHealth.ToString("###",CultureInfo.InvariantCulture) + "/" + "100");

		if (Starve.IsStarving == false)
		{
			//UpdateHunger (((Starve.HungerTimer / Starve.HungerTimerMax) * 100).ToString ("###", CultureInfo.InvariantCulture) + "%");
			UpdateHunger("");
			HungerBar.SetActive(true);
			hungerFillerBar.SetActive (true);
			hungerblackbox.SetActive (true);
			HungerBar.transform.localScale = new Vector3 ((Starve.HungerTimer / 60) * 1.53f, .2f, .01f);
		}
		else if (Starve.IsStarving == true)
		{
			HungerBar.SetActive(false);
			hungerFillerBar.SetActive (false);
			hungerblackbox.SetActive (false);
			UpdateHunger ("You are Starving");
		}


		if (CJC_LifeCount.PlayerLives <= 3)
		{
			UpdateLives ("");
		}
		else if (CJC_LifeCount.PlayerLives >= 4)
		{
			UpdateLives ("x" + CJC_LifeCount.PlayerLives);
		}
		UpdateTime (countingtime.minutes + " : " + countingtime.seconds);

		if (realplayer.SprintExhausted) {
			if (Input.GetKeyDown (KeyCode.F) | Input.GetAxis ("360_Triggers") > 0.5f | Input.GetKey (KeyCode.LeftShift) | Input.GetAxis ("360_Triggers") < 0) {
				OutOfStamina.SetActive (true);
			}
		} else {
			OutOfStamina.SetActive (false);
		}
	}
		

	public void UpdateLives (string value)
	{
		LivesTextMesh.text = livesText;
		LivesTextMesh.text += value;
	}
	public void UpdateHealth (string value)
	{
		HealthTextMesh.text = healthText;
		HealthTextMesh.text += value;
	}
	public void UpdateHunger (string value)
	{
		GameObject star = GameObject.FindWithTag ("Player");
		CJC_Starvation Starve = star.GetComponent<CJC_Starvation> ();

		HungerTextMesh.text = hungerText;

		if (Starve.IsStarving == false)
		{
			HungerTextMesh.text = "" + value;
		}
		else if (Starve.IsStarving == true)
		{
			HungerTextMesh.text = "" + value;
		}
	}

	public void UpdateTime(string value){
		TimeTextMesh.text = timeText;
		TimeTextMesh.text += value;
	}

	public void Updatestartimer(){
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		starTextMesh1.text = startext1;
		starTextMesh2.text = startext2;
		starTextMesh3.text = startext3;

		if (player.RestartLevel == "PieSlice1") {
			starTextMesh1.text = " 1 : 20 ";
			starTextMesh2.text = " 2 : 20 ";
			starTextMesh3.text = " 3 : 20 ";
		} 
		else if (player.RestartLevel == "PieSlice2") {
			starTextMesh1.text = " 1 : 30 ";
			starTextMesh2.text = " 2 : 30 ";
			starTextMesh3.text = " 3 : 30 ";
		}
		else if (player.RestartLevel == "PieSlice3") {
			starTextMesh1.text = " 2 : 30 ";
			starTextMesh2.text = " 3 : 30 ";
			starTextMesh3.text = " 4 : 30 ";
		}
		else if (player.RestartLevel == "Level3") {
			starTextMesh1.text = " 1 : 30 ";
			starTextMesh2.text = " 2 : 30 ";
			starTextMesh3.text = " 3 : 30 ";
		}
		else if (player.RestartLevel == "Level4") {
			starTextMesh1.text = " 4 : 00 ";
			starTextMesh2.text = " 5 : 00 ";
			starTextMesh3.text = " 6 : 00 ";
		}
		else if (player.RestartLevel == "Level5") {
			starTextMesh1.text = " 3 : 20 ";
			starTextMesh2.text = " 4 : 20 ";
			starTextMesh3.text = " 5 : 20 ";
		}
		else if (player.RestartLevel == "Level6") {
			starTextMesh1.text = " 2 : 40 ";
			starTextMesh2.text = " 3 : 40 ";
			starTextMesh3.text = " 4 : 40 ";
		}

	}
}
