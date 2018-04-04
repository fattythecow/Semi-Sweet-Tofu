using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showingstarsinlevel : MonoBehaviour {

	public GameObject nostar1;

	public GameObject nostar2;

	public GameObject nostar3;

	public GameObject star1;

	public GameObject star2;

	public GameObject star3;

	// Use this for initialization
	void Start () {
		nostar1.SetActive (false);
		nostar2.SetActive (false);
		nostar3.SetActive (false);
		star1.SetActive (true);
		star2.SetActive (true);
		star3.SetActive (true);

	}

	// Update is called once per frame
	void Update () {
		Handlestars ();
	}

	void Handlestars(){
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		if (player.RestartLevel == "PieSlice1") {
			
			if (CJC_Scoring.timeT <= 60 && CJC_Scoring.timeT > 0) {
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (false);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (true);
			} else if (CJC_Scoring.timeT <= 120 && CJC_Scoring.timeT > 60) {
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (false);
			} else if (CJC_Scoring.timeT > 120 && CJC_Scoring.timeT <= 180) {
				nostar1.SetActive (false);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (false);
				star3.SetActive (false);
			} else if (CJC_Scoring.timeT > 180) {
				nostar1.SetActive (true);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (false);
				star2.SetActive (false);
				star3.SetActive (false);
			}
		} else if (player.RestartLevel == "PieSlice2") {
			if (CJC_Scoring.time1 <= 60 && CJC_Scoring.time1 > 0) {
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (false);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (true);
			} else if (CJC_Scoring.time1 <= 120 && CJC_Scoring.time1 > 60) {
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (false);
			} else if (CJC_Scoring.time1 > 120 && CJC_Scoring.time1 <= 180) {
				nostar1.SetActive (false);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (false);
				star3.SetActive (false);
			}else if(CJC_Scoring.time1 > 180){
				nostar1.SetActive (true);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (false);
				star2.SetActive (false);
				star3.SetActive (false);
			}
		}

		else if (player.RestartLevel == "PieSlice3") {
			if (CJC_Scoring.time2 <= 80 && CJC_Scoring.time2 > 0) {
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (false);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (true);
			} else if (CJC_Scoring.time2 <= 140 && CJC_Scoring.time2 > 80) {
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (false);
			} else if (CJC_Scoring.time2 > 140 && CJC_Scoring.time2 <= 200) {
				nostar1.SetActive (false);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (false);
				star3.SetActive (false);
			} else if (CJC_Scoring.time2 > 200) {
				nostar1.SetActive (true);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (false);
				star2.SetActive (false);
				star3.SetActive (false);
			}
		}

		else if (player.RestartLevel == "Level3") {
			if (CJC_Scoring.time3 <= 60 && CJC_Scoring.time3 > 0) {
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (false);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (true);
			} else if (CJC_Scoring.time3 <= 120 && CJC_Scoring.time3 > 60) {
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (false);
			} else if (CJC_Scoring.time3 > 120 && CJC_Scoring.time3 <= 180) {
				nostar1.SetActive (false);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (false);
				star3.SetActive (false);
			} else if (CJC_Scoring.time3 > 180) {
				nostar1.SetActive (true);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (false);
				star2.SetActive (false);
				star3.SetActive (false);
			}
		}


		else if (player.RestartLevel == "Level4") {
			if (CJC_Scoring.time4 <= 240 && CJC_Scoring.time4 > 0) {
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (false);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (true);
			} else if (CJC_Scoring.time4 <= 300 && CJC_Scoring.time4 > 240) {
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (false);
			} else if (CJC_Scoring.time4 > 300 && CJC_Scoring.time4 <= 360) {
				nostar1.SetActive (false);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (false);
				star3.SetActive (false);
			} else if (CJC_Scoring.time4 > 360) {
				nostar1.SetActive (true);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (false);
				star2.SetActive (false);
				star3.SetActive (false);
			}
		}


		else if (player.RestartLevel == "Level5") {
			if (CJC_Scoring.time5 <= 100 && CJC_Scoring.time5 > 0) {
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (false);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (true);
			} else if (CJC_Scoring.time5 <= 160 && CJC_Scoring.time5 > 100) {
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (false);
			} else if (CJC_Scoring.time5 > 160 && CJC_Scoring.time5 <= 220) {
				nostar1.SetActive (false);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (false);
				star3.SetActive (false);
			} else if (CJC_Scoring.time5 > 220) {
				nostar1.SetActive (true);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (false);
				star2.SetActive (false);
				star3.SetActive (false);
			}
		}



		else if (player.RestartLevel == "Level6") {
			if (CJC_Scoring.time6 <= 80 && CJC_Scoring.time6 > 0) {
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (false);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (true);
			} else if (CJC_Scoring.time6 <= 140 && CJC_Scoring.time6 > 80) {
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (false);
			} else if (CJC_Scoring.time6 > 140 && CJC_Scoring.time6 <= 200) {
				nostar1.SetActive (false);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (false);
				star3.SetActive (false);
			}else if(CJC_Scoring.time6 > 200){
				nostar1.SetActive (true);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (false);
				star2.SetActive (false);
				star3.SetActive (false);
			}
		}

	}
}

