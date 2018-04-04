using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showingstarsleader : MonoBehaviour {
	
	public GameObject nostar1;

	public GameObject nostar2;

	public GameObject nostar3;

	public GameObject star1;

	public GameObject star2;

	public GameObject star3;

	public string levelname = "";

	// Use this for initialization
	void Start () {
		nostar1.SetActive (true);
		nostar2.SetActive (true);
		nostar3.SetActive (true);
		star1.SetActive (false);
		star2.SetActive (false);
		star3.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		Handlestars ();
	}

	void Handlestars(){
		if (levelname == "t") {
			if (CJC_Scoring.hightimeT <= 60 && CJC_Scoring.hightimeT > 0) {
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (false);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (true);
			} else if (CJC_Scoring.hightimeT <= 120 && CJC_Scoring.hightimeT > 60) {
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (false);
			} else if (CJC_Scoring.hightimeT > 120 && CJC_Scoring.hightimeT <= 180) {
				nostar1.SetActive (false);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (false);
				star3.SetActive (false);
			} else if (CJC_Scoring.hightimeT > 180) {
				nostar1.SetActive (true);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (false);
				star2.SetActive (false);
				star3.SetActive (false);
			}
		} else if (levelname == "1") {
			if (CJC_Scoring.hightime1 <= 60 && CJC_Scoring.hightime1 > 0) {
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (false);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (true);
			} else if (CJC_Scoring.hightime1 <= 120 && CJC_Scoring.hightime1 > 60) {
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (false);
			} else if (CJC_Scoring.hightime1 > 120 && CJC_Scoring.hightime1 <= 180) {
				nostar1.SetActive (false);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (false);
				star3.SetActive (false);
			}else if(CJC_Scoring.hightime1 > 180){
				nostar1.SetActive (true);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (false);
				star2.SetActive (false);
				star3.SetActive (false);
			}
		}

		else if (levelname == "2") {
			if (CJC_Scoring.hightime2 <= 80 && CJC_Scoring.hightime2 > 0) {
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (false);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (true);
			} else if (CJC_Scoring.hightime2 <= 140 && CJC_Scoring.hightime2 > 80) {
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (false);
			} else if (CJC_Scoring.hightime2 > 140 && CJC_Scoring.hightime2 <= 200) {
				nostar1.SetActive (false);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (false);
				star3.SetActive (false);
			} else if (CJC_Scoring.hightime2 > 200) {
				nostar1.SetActive (true);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (false);
				star2.SetActive (false);
				star3.SetActive (false);
			}
		}

		else if (levelname == "3") {
			if (CJC_Scoring.hightime3 <= 60 && CJC_Scoring.hightime3 > 0) {
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (false);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (true);
			} else if (CJC_Scoring.hightime3 <= 120 && CJC_Scoring.hightime3 > 60) {
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (false);
			} else if (CJC_Scoring.hightime3 > 120 && CJC_Scoring.hightime3 <= 180) {
				nostar1.SetActive (false);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (false);
				star3.SetActive (false);
			} else if (CJC_Scoring.hightime3 > 180) {
				nostar1.SetActive (true);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (false);
				star2.SetActive (false);
				star3.SetActive (false);
			}
		}


		else if (levelname == "4") {
			if (CJC_Scoring.hightime4 <= 240 && CJC_Scoring.hightime4 > 0) {
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (false);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (true);
			} else if (CJC_Scoring.hightime4 <= 300 && CJC_Scoring.hightime4 > 240) {
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (false);
			} else if (CJC_Scoring.hightime4 > 300 && CJC_Scoring.hightime4 <= 360) {
				nostar1.SetActive (false);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (false);
				star3.SetActive (false);
			} else if (CJC_Scoring.hightime4 > 360) {
				nostar1.SetActive (true);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (false);
				star2.SetActive (false);
				star3.SetActive (false);
			}
		}


		else if (levelname == "5") {
			if (CJC_Scoring.hightime5 <= 100 && CJC_Scoring.hightime5 > 0) {
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (false);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (true);
			} else if (CJC_Scoring.hightime5 <= 160 && CJC_Scoring.hightime5 > 100) {
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (false);
			} else if (CJC_Scoring.hightime5 > 160 && CJC_Scoring.hightime5 <= 220) {
				nostar1.SetActive (false);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (false);
				star3.SetActive (false);
			} else if (CJC_Scoring.hightime5 > 220) {
				nostar1.SetActive (true);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (false);
				star2.SetActive (false);
				star3.SetActive (false);
			}
		}



		else if (levelname == "6") {
			if (CJC_Scoring.hightime6 <= 80 && CJC_Scoring.hightime6 > 0) {
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (false);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (true);
			} else if (CJC_Scoring.hightime6 <= 140 && CJC_Scoring.hightime6 > 80) {
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (false);
			} else if (CJC_Scoring.hightime6 > 140 && CJC_Scoring.hightime6 <= 200) {
				nostar1.SetActive (false);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (false);
				star3.SetActive (false);
			}else if(CJC_Scoring.hightime6 > 200){
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
