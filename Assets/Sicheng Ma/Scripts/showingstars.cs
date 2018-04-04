using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showingstars : MonoBehaviour {

	public GameObject nostar1;

	public GameObject nostar2;

	public GameObject nostar3;

	public GameObject star1;

	public GameObject star2;

	public GameObject star3;

	public string levelname = "";

	bool nostarswon;
	bool starswon1;
	bool starswon2;
	bool starswon3;
	[SerializeField]
	GameObject Tofuboi;
	[SerializeField]
	Material nostartofu;
	[SerializeField]
	Material startofu1;
	[SerializeField]
	Material startofu2;
	[SerializeField]
	Material startofu3;

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
		managetofus ();
	}


	void managetofus()
	{
		if (nostarswon)
		{
			Tofuboi.GetComponent<MeshRenderer> ().material = nostartofu;
		} 
		else if (starswon1)
		{
			Tofuboi.GetComponent<MeshRenderer> ().material = startofu1;
		}
		else if (starswon2)
		{
			Tofuboi.GetComponent<MeshRenderer> ().material = startofu2;
		}
		else if (starswon3)
		{
			Tofuboi.GetComponent<MeshRenderer> ().material = startofu3;
		}
	}

	void Handlestars(){
		

		if (levelname == "t") {
			Debug.Log (CJC_Scoring.timeT);
			if (CJC_Scoring.timeT <= 60 && CJC_Scoring.timeT > 0) {
				nostarswon = false;
				starswon1 = false;
				starswon2 = false;
				starswon3 = true;
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (false);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (true);
			} else if (CJC_Scoring.timeT <= 120 && CJC_Scoring.timeT > 60) {
				nostarswon = false;
				starswon1 = false;
				starswon2 = true;
				starswon3 = false;
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (false);
			} else if (CJC_Scoring.timeT > 120 && CJC_Scoring.timeT <= 180) {
				nostarswon = false;
				starswon1 = true;
				starswon2 = false;
				starswon3 = false;
				
				nostar1.SetActive (false);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (false);
				star3.SetActive (false);
			} else if (CJC_Scoring.timeT > 180) {
				nostarswon = true;
				starswon1 = false;
				starswon2 = false;
				starswon3 = false;
				nostar1.SetActive (true);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (false);
				star2.SetActive (false);
				star3.SetActive (false);
			}
		} else if (levelname == "1") {
			if (CJC_Scoring.time1 <= 60 && CJC_Scoring.time1 > 0) {
				nostarswon = false;
				starswon1 = false;
				starswon2 = false;
				starswon3 = true;
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (false);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (true);
			} else if (CJC_Scoring.time1 <= 120 && CJC_Scoring.time1 > 60) {
				nostarswon = false;
				starswon1 = false;
				starswon2 = true;
				starswon3 = false;
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (false);
			} else if (CJC_Scoring.time1 > 120 && CJC_Scoring.time1 <= 180) {
				nostarswon = false;
				starswon1 = true;
				starswon2 = false;
				starswon3 = false;
				nostar1.SetActive (false);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (false);
				star3.SetActive (false);
			}else if(CJC_Scoring.time1 > 180){
				nostarswon = true;
				starswon1 = false;
				starswon2 = false;
				starswon3 = false;
				nostar1.SetActive (true);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (false);
				star2.SetActive (false);
				star3.SetActive (false);
			}
		}

		else if (levelname == "2") {
			if (CJC_Scoring.time2 <= 80 && CJC_Scoring.time2 > 0) {
				nostarswon = false;
				starswon1 = false;
				starswon2 = false;
				starswon3 = true;
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (false);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (true);
			} else if (CJC_Scoring.time2 <= 140 && CJC_Scoring.time2 > 80) {
				nostarswon = false;
				starswon1 = false;
				starswon2 = true;
				starswon3 = false;
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (false);
			} else if (CJC_Scoring.time2 > 140 && CJC_Scoring.time2 <= 200) {
				nostarswon = false;
				starswon1 = true;
				starswon2 = false;
				starswon3 = false;
				nostar1.SetActive (false);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (false);
				star3.SetActive (false);
			} else if (CJC_Scoring.time2 > 200) {
				nostarswon = true;
				starswon1 = false;
				starswon2 = false;
				starswon3 = false;
				nostar1.SetActive (true);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (false);
				star2.SetActive (false);
				star3.SetActive (false);
			}
		}

		else if (levelname == "3") {
			if (CJC_Scoring.time3 <= 60 && CJC_Scoring.time3 > 0) {
				nostarswon = false;
				starswon1 = false;
				starswon2 = false;
				starswon3 = true;
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (false);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (true);
			} else if (CJC_Scoring.time3 <= 120 && CJC_Scoring.time3 > 60) {
				nostarswon = false;
				starswon1 = false;
				starswon2 = true;
				starswon3 = false;
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (false);
			} else if (CJC_Scoring.time3 > 120 && CJC_Scoring.time3 <= 180) {
				nostarswon = false;
				starswon1 = true;
				starswon2 = false;
				starswon3 = false;
				nostar1.SetActive (false);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (false);
				star3.SetActive (false);
			} else if (CJC_Scoring.time3 > 180) {
				nostarswon = true;
				starswon1 = false;
				starswon2 = false;
				starswon3 = false;
				nostar1.SetActive (true);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (false);
				star2.SetActive (false);
				star3.SetActive (false);
			}
		}


		else if (levelname == "4") {
			if (CJC_Scoring.time4 <= 240 && CJC_Scoring.time4 > 0) {
				nostarswon = false;
				starswon1 = false;
				starswon2 = false;
				starswon3 = true;
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (false);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (true);
			} else if (CJC_Scoring.time4 <= 300 && CJC_Scoring.time4 > 240) {
				nostarswon = false;
				starswon1 = false;
				starswon2 = true;
				starswon3 = false;
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (false);
			} else if (CJC_Scoring.time4 > 300 && CJC_Scoring.time4 <= 360) {
				nostarswon = false;
				starswon1 = true;
				starswon2 = false;
				starswon3 = false;
				nostar1.SetActive (false);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (false);
				star3.SetActive (false);
			} else if (CJC_Scoring.time4 > 360) {
				nostarswon = true;
				starswon1 = false;
				starswon2 = false;
				starswon3 = false;
				nostar1.SetActive (true);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (false);
				star2.SetActive (false);
				star3.SetActive (false);
			}
		}


		else if (levelname == "5") {
			if (CJC_Scoring.time5 <= 100 && CJC_Scoring.time5 > 0) {
				nostarswon = false;
				starswon1 = false;
				starswon2 = false;
				starswon3 = true;
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (false);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (true);
			} else if (CJC_Scoring.time5 <= 160 && CJC_Scoring.time5 > 100) {
				nostarswon = false;
				starswon1 = false;
				starswon2 = true;
				starswon3 = false;
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (false);
			} else if (CJC_Scoring.time5 > 160 && CJC_Scoring.time5 <= 220) {
				nostarswon = false;
				starswon1 = true;
				starswon2 = false;
				starswon3 = false;
				nostar1.SetActive (false);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (false);
				star3.SetActive (false);
			} else if (CJC_Scoring.time5 > 220) {
				nostarswon = true;
				starswon1 = false;
				starswon2 = false;
				starswon3 = false;
				nostar1.SetActive (true);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (false);
				star2.SetActive (false);
				star3.SetActive (false);
			}
		}



		else if (levelname == "6") {
			if (CJC_Scoring.time6 <= 80 && CJC_Scoring.time6 > 0) {
				nostarswon = false;
				starswon1 = false;
				starswon2 = false;
				starswon3 = true;
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (false);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (true);
			} else if (CJC_Scoring.time6 <= 140 && CJC_Scoring.time6 > 80) {
				nostarswon = false;
				starswon1 = false;
				starswon2 = true;
				starswon3 = false;
				nostar1.SetActive (false);
				nostar2.SetActive (false);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (true);
				star3.SetActive (false);
			} else if (CJC_Scoring.time6 > 140 && CJC_Scoring.time6 <= 200) {
				nostarswon = false;
				starswon1 = true;
				starswon2 = false;
				starswon3 = false;
				nostar1.SetActive (false);
				nostar2.SetActive (true);
				nostar3.SetActive (true);
				star1.SetActive (true);
				star2.SetActive (false);
				star3.SetActive (false);
			}else if(CJC_Scoring.time6 > 200){
				nostarswon = true;
				starswon1 = false;
				starswon2 = false;
				starswon3 = false;
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
