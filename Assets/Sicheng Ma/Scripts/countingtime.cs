using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countingtime : MonoBehaviour {

	public float leveltimer;

	static public bool startcounting = false;

	static public string minutes;

	static public string seconds;

	/*
	public GameObject showtimerstar;

	public float destroyTime = 3.0f;

	public float destroyTimer = 0.0f;

	private bool transparent = false;

	public float currentAlpha = 1.0f;

	public float maxAlpha = 1.0f;

	public float minAlpha = 0;

	public float FlickerRate = 20f;

	public float starblink = 0;
	*/

	// Use this for initialization
	void Start ()
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		GameObject p2 = GameObject.FindWithTag ("Player");
		CJC_Scoring score = p2.GetComponent<CJC_Scoring> ();

		if (player.RestartLevel == "PieSlice1") {
			leveltimer = CJC_Scoring.timeT;
			CJC_Scoring.time1 = 0;
			CJC_Scoring.time2 = 0;
			CJC_Scoring.time3 = 0;
			CJC_Scoring.time4 = 0;
			CJC_Scoring.time5 = 0;

			CJC_Scoring.time6 = 0;
		}

		else if (player.RestartLevel == "PieSlice2") {
			leveltimer = CJC_Scoring.time1;
			CJC_Scoring.timeT = 0;
			CJC_Scoring.time2 = 0;
			CJC_Scoring.time3 = 0;
			CJC_Scoring.time4 = 0;
			CJC_Scoring.time5 = 0;

			CJC_Scoring.time6 = 0;
		}
		else if (player.RestartLevel == "PieSlice3") {
			leveltimer = CJC_Scoring.time2;
			CJC_Scoring.time1 = 0;
			CJC_Scoring.timeT = 0;
			CJC_Scoring.time3 = 0;
			CJC_Scoring.time4 = 0;
			CJC_Scoring.time5 = 0;

			CJC_Scoring.time6 = 0;
		}
		else if (player.RestartLevel == "Level3") {
			leveltimer = CJC_Scoring.time3;
			CJC_Scoring.time1 = 0;
			CJC_Scoring.time2 = 0;
			CJC_Scoring.timeT = 0;
			CJC_Scoring.time4 = 0;
			CJC_Scoring.time5 = 0;

			CJC_Scoring.time6 = 0;
		}
		else if (player.RestartLevel == "Level4") {
			leveltimer = CJC_Scoring.time4;
			CJC_Scoring.time1 = 0;
			CJC_Scoring.time2 = 0;
			CJC_Scoring.time3 = 0;
			CJC_Scoring.timeT = 0;
			CJC_Scoring.time5 = 0;

			CJC_Scoring.time6 = 0;
		}
		else if (player.RestartLevel == "Level5") {
			leveltimer = CJC_Scoring.time5;
			CJC_Scoring.time1 = 0;
			CJC_Scoring.time2 = 0;
			CJC_Scoring.time3 = 0;
			CJC_Scoring.time4 = 0;
			CJC_Scoring.timeT = 0;

			CJC_Scoring.time6 = 0;
		}
		else if (player.RestartLevel == "Level6") {
			leveltimer = CJC_Scoring.time6;
			CJC_Scoring.time1 = 0;
			CJC_Scoring.time2 = 0;
			CJC_Scoring.time3 = 0;
			CJC_Scoring.time4 = 0;
			CJC_Scoring.time5 = 0;

			CJC_Scoring.timeT = 0;
		}

	}
	
	// Update is called once per frame
	void Update () {
		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();
		GameObject core = GameObject.FindWithTag ("GameCore");
		CJC_PauseShit gamecore = core.GetComponent<CJC_PauseShit> ();
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		GameObject p2 = GameObject.FindWithTag ("Player");
		CJC_Scoring score = p2.GetComponent<CJC_Scoring> ();

		/*
		destroyTimer += Time.deltaTime;

		if (startcounting) {
			Flicker ();
			starblink += Time.deltaTime;
			if (starblink >= 2f) {
				showtimerstar.SetActive (false);
				starblink = 0;
			}
		}
		*/

		if (leveltimer <= 0) {
			leveltimer = 0;
		}

		if (player.RestartLevel == "PieSlice1" && !player.PlayerDied) {
			CJC_Scoring.timeT = leveltimer;
		}

		else if (player.RestartLevel == "PieSlice2" && !player.PlayerDied) {
			CJC_Scoring.time1 = leveltimer;
		}
		else if (player.RestartLevel == "PieSlice3" && !player.PlayerDied) {
			CJC_Scoring.time2 = leveltimer;
		}
		else if (player.RestartLevel == "Level3"  && !player.PlayerDied) {
			CJC_Scoring.time3 = leveltimer;
		}
		else if (player.RestartLevel == "Level4" && !player.PlayerDied) {
			CJC_Scoring.time4 = leveltimer;
		}
		else if (player.RestartLevel == "Level5" && !player.PlayerDied) {
			CJC_Scoring.time5 = leveltimer;
		}
		else if (player.RestartLevel == "Level6" && !player.PlayerDied) {
			CJC_Scoring.time6 = leveltimer;
		}

		if (startcounting) {
			if (!shop.isopen && !gamecore.paused&& !player.PlayerDied)
			{
				if (player.RestartLevel == "PieSlice1" && CJC_Scoring.hasstartedlevelT)
				{
					leveltimer +=Time.deltaTime;
				} 
				else if (player.RestartLevel == "PieSlice2" && CJC_Scoring.hasstartedlevel1)
				{
					leveltimer +=Time.deltaTime;
				} 
				else if (player.RestartLevel == "PieSlice3" && CJC_Scoring.hasstartedlevel2)
				{
					leveltimer +=Time.deltaTime;
				} 
				else if (player.RestartLevel == "Level3" && CJC_Scoring.hasstartedlevel3)
				{
					leveltimer +=Time.deltaTime;
				} 
				else if (player.RestartLevel == "Level4" && CJC_Scoring.hasstartedlevel4)
				{
					leveltimer +=Time.deltaTime;
				} 
				else if (player.RestartLevel == "Level5" && CJC_Scoring.hasstartedlevel5)
				{
					leveltimer += Time.deltaTime;
				} 
				else if (player.RestartLevel == "Level6" && CJC_Scoring.hasstartedlevel6)
				{
					leveltimer +=Time.deltaTime;
				}
			}
		}

		minutes = Mathf.Floor (leveltimer / 60).ToString ("00"); 
		seconds = Mathf.Floor (leveltimer % 60).ToString ("00"); 

	}

	/*
	void Flicker () {
		Debug.Log ("starting flicker");
		if (destroyTimer >= destroyTime - 10f) {
			if (transparent == true)
				currentAlpha -= Time.time / FlickerRate;

			if (transparent == false)
				currentAlpha += Time.time / FlickerRate;

			if (currentAlpha >= maxAlpha && transparent == false) {
				currentAlpha = maxAlpha;
				transparent = true;
			}

			if (currentAlpha <= minAlpha && transparent == true) {
				currentAlpha = minAlpha;
				transparent = false;
			}
		}
		if (transparent == true)
			showtimerstar.GetComponent<Renderer> ().enabled = false;

		if (transparent == false)
			showtimerstar.GetComponent<Renderer> ().enabled = true;
	}
	*/


	void OnTriggerExit(Collider other){
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		if (other.tag == "Player") {
			startcounting = true;
			if (player.RestartLevel == "PieSlice1") {
				CJC_Scoring.hasstartedlevelT = true;
			}
			else if (player.RestartLevel == "PieSlice2") {
				CJC_Scoring.hasstartedlevel1 = true;
			}
			else if (player.RestartLevel == "PieSlice3") {
				CJC_Scoring.hasstartedlevel2 = true;
			}
			else if (player.RestartLevel == "Level3") {
				CJC_Scoring.hasstartedlevel3 = true;
			}
			else if (player.RestartLevel == "Level4") {
				CJC_Scoring.hasstartedlevel4 = true;
			}
			else if (player.RestartLevel == "Level5") {
				CJC_Scoring.hasstartedlevel5 = true;
			}
			else if (player.RestartLevel == "Level6") {
				CJC_Scoring.hasstartedlevel6 = true;
			}
		}
	}
	/*
	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			showtimerstar.SetActive (true);
		}
	}
	*/
}
