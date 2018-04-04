using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_Scoring : MonoBehaviour
{
	/*
	public static bool Addlife1 = false;
	public static bool Addlife2 = false;
	public static bool Addlife3 = false;
	public static bool Addlife4 = false;
	public static bool Addlife5 = false;
	public static bool Addlife6 = false;
	public static bool Addlife7 = false;
	public static bool Addlife8 = false;
	public static bool Addlife9 = false;
	public static bool Addlife10 = false;
	*/

	static public int PlayerScore = 0;

	public int scoreT = 0;
	public static float timeT;
	public static bool hasbeenscoredT = false;

	public static bool hasstartedlevelT = false;

	public int score1 = 0;
	public static float time1;
	public static bool hasbeenscored1 = false;
	public static bool hasstartedlevel1 = false;
	public int score2 = 0;
	public static float time2;
	public static bool hasbeenscored2 = false;
	public static bool hasstartedlevel2 = false;
	public int score3 = 0;
	public static float time3;
	public static bool hasbeenscored3 = false;
	public static bool hasstartedlevel3 = false;
	public int score4 = 0;
	public static float time4;
	public static bool hasbeenscored4 = false;
	public static bool hasstartedlevel4 = false;
	public int score5 = 0;
	public static float time5;
	public static bool hasbeenscored5 = false;
	public static bool hasstartedlevel5 = false;
	public int score6 = 0;
	public static float time6;
	public static bool hasbeenscored6 = false;
	public static bool hasstartedlevel6 = false;
	public static int highT = 0;

	public static int high1 = 0;

	public static int high2 = 0;

	public static int high3 = 0;

	public static int high4 = 0;

	public static int high5 = 0;

	public static int high6 = 0;

	public static float hightimeT = 0;
	public static float hightime1 = 0;
	public static float hightime2 = 0;
	public static float hightime3 = 0;
	public static float hightime4 = 0;
	public static float hightime5 = 0;
	public static float hightime6 = 0;

	// Use this for initialization
	void Start ()
	{
		
		dothetime ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		//HandleScore ();
		highestscore ();

	}

	void highestscore(){
		GameObject p2 = GameObject.Find ("starttime");
		countingtime time = p2.GetComponent<countingtime> ();

		if (CJC_LevelTranSition.finishLevel && hasbeenscoredT == true) // when finishing tutorial
		{
			scoreT = PlayerScore;
			timeT = time.leveltimer;
			if (scoreT >= highT)
				highT = scoreT;
			if (timeT >= hightimeT)
				hightimeT = timeT;
			hasbeenscoredT = false;
		}
		if(exitLevel1.finishLevel && hasbeenscored1 == true) // when finishing level 1
		{
			score1 = PlayerScore;
			time1 = time.leveltimer;
			if (score1 >= high1)
				high1 = score1;
			if (time1 >= hightime1)
				hightime1 = time1;
			hasbeenscored1 = false;
		}
		if(exitlevel2.finishLevel && hasbeenscored2 == true) // when finishing level 2
		{
			score2 = PlayerScore;
			time2 = time.leveltimer;
			if (score2 >= high2)
				high2 = score2;
			if (time2 >= hightime2)
				hightime2 = time2;
			hasbeenscored2 = false;
		}
		if (exitlevelagain.finishLevel && hasbeenscored3 == true) {
			score3 = PlayerScore;
			time3 = time.leveltimer;
			if (score3 >= high3)
				high3 = score3;
			if (time3 >= hightime3)
				hightime3 = time3;
			hasbeenscored3 = false;
		}
		if (exitlevel4.finishLevel && hasbeenscored4 == true) {
			score4 = PlayerScore;
			time4 = time.leveltimer;
			if (score4 >= high4)
				high4 = score4;
			if (time4 >= hightime4)
				hightime4 = time4;
			hasbeenscored4 = false;
		}
		if (exitlevel5.finishLevel && hasbeenscored5 == true) {
			score5 = PlayerScore;
			time5 = time.leveltimer;
			if (score5 >= high5)
				high5 = score5;
			if (time5 >= hightime5)
				hightime5 = time5;
			hasbeenscored5 = false;
		}
		if (exitlevel6.finishLevel && hasbeenscored6 == true) {
			score6 = PlayerScore;
			time6 = time.leveltimer;
			if (score6 >= high6)
				high6 = score6;
			if (time6 >= hightime6)
				hightime6 = time6;
			hasbeenscored6 = false;
		}
	}

	void dothetime(){
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		GameObject p2 = GameObject.Find ("starttime");
		countingtime time = p2.GetComponent<countingtime> ();


		if (player.RestartLevel == "PieSlice1") {
			//if(!hasstartedlevelT || hasbeenscoredT)
			//		time.leveltimer = 0;
		}

		else if (player.RestartLevel == "PieSlice2") {
		//	if(!hasstartedlevel1 || hasbeenscored1)
			//		time.leveltimer = 0;
		}
		else if (player.RestartLevel == "PieSlice3") {
			//if(!hasstartedlevel2 || hasbeenscored2)
			//	time.leveltimer = 0;
		}
		else if (player.RestartLevel == "Level3") {
			//if(!hasstartedlevel3 || hasbeenscored3)
			//	time.leveltimer = 0;
		}
		else if (player.RestartLevel == "Level4") {
			//if(!hasstartedlevel4 || hasbeenscored4)
			//	time.leveltimer = 0;
		}
		else if (player.RestartLevel == "Level5") {
			//if(!hasstartedlevel5 || hasbeenscored5)
			//	time.leveltimer = 0;
		}
		else if (player.RestartLevel == "Level6") {
			//if(!hasstartedlevel6 || hasbeenscored6)
			//	time.leveltimer = 0;
		}
	}



	void HandleScore()
	{
		GameObject livess = GameObject.Find ("Lives");
		CJC_livesPFI lives = livess.GetComponent<CJC_livesPFI> ();
		
		if (PlayerScore >= 3000) 
		{
			lives.LiveGained = true;
			Invoke ("AddLife", 0);

		}
		else if (PlayerScore >= 6000 ) 
		{
			lives.LiveGained = true;
			Invoke ("AddLife", 0);

		}
		else if (PlayerScore >= 9000 ) 
		{
			lives.LiveGained = true;
			Invoke ("AddLife", 0);

		}
		else if (PlayerScore >= 12000) 
		{
			lives.LiveGained = true;
			Invoke ("AddLife", 0);

		}
		else if (PlayerScore >= 15000) 
		{
			lives.LiveGained = true;
			Invoke ("AddLife", 0);

		}
		if (PlayerScore >= 18000) 
		{
			lives.LiveGained = true;
			Invoke ("AddLife", 0);

		}
		else if (PlayerScore >= 21000) 
		{
			lives.LiveGained = true;
			Invoke ("AddLife", 0);

		}
		else if (PlayerScore >= 24000) 
		{
			lives.LiveGained = true;
			Invoke ("AddLife", 0);

		}
		else if (PlayerScore >= 27000) 
		{
			lives.LiveGained = true;
			Invoke ("AddLife", 0);

		}
		else if (PlayerScore >= 30000) 
		{
			lives.LiveGained = true;
			Invoke ("AddLife", 0);

		}

		if (PlayerScore < 0) 
		{
			PlayerScore = 0;
		}

	}
	/*
	void AddLife()
	{
		CJC_LifeCount.PlayerLives++;
	}
	*/
}
