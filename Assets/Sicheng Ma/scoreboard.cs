using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreboard : MonoBehaviour {
	
	public TextMesh ScoreTextMeshT;
	private string scoreTextT;

	public TextMesh ScoreTextMesh1;
	private string scoreText1;

	public TextMesh ScoreTextMesh2;
	private string scoreText2;

	public TextMesh ScoreTextMesh3;
	private string scoreText3;

	public TextMesh ScoreTextMesh5;
	private string scoreText5;

	public TextMesh ScoreTextMesh6;
	private string scoreText6;

	// Use this for initialization
	void Start () {
		scoreTextT = ScoreTextMeshT.text;
		scoreText1 = ScoreTextMesh1.text;
		scoreText2 = ScoreTextMesh2.text;
		scoreText3 = ScoreTextMesh3.text;
		scoreText5 = ScoreTextMesh5.text;
		scoreText6 = ScoreTextMesh6.text;
	}
	
	// Update is called once per frame
	void Update () {
		UpdateScoreT (Mathf.Floor (CJC_Scoring.hightimeT / 60).ToString ("00") + " : " + Mathf.Floor (CJC_Scoring.hightimeT % 60).ToString ("00"));
		UpdateScore1 (Mathf.Floor (CJC_Scoring.hightime1 / 60).ToString ("00") + " : " + Mathf.Floor (CJC_Scoring.hightime1 % 60).ToString ("00"));
		UpdateScore2 (Mathf.Floor (CJC_Scoring.hightime2 / 60).ToString ("00") + " : " + Mathf.Floor (CJC_Scoring.hightime2 % 60).ToString ("00"));
		UpdateScore3 (Mathf.Floor (CJC_Scoring.hightime3 / 60).ToString ("00") + " : " + Mathf.Floor (CJC_Scoring.hightime3 % 60).ToString ("00"));
		UpdateScore5 (Mathf.Floor (CJC_Scoring.hightime5 / 60).ToString ("00") + " : " + Mathf.Floor (CJC_Scoring.hightime5 % 60).ToString ("00"));
		UpdateScore6 (Mathf.Floor (CJC_Scoring.hightime6 / 60).ToString ("00") + " : " + Mathf.Floor (CJC_Scoring.hightime6 % 60).ToString ("00"));
	}

	public void UpdateScoreT (string value)
	{
		ScoreTextMeshT.text = scoreTextT;
		ScoreTextMeshT.text += value;
	}

	public void UpdateScore1 (string value)
	{
		ScoreTextMesh1.text = scoreText1;
		ScoreTextMesh1.text += value;
	}

	public void UpdateScore2 (string value)
	{
		ScoreTextMesh2.text = scoreText2;
		ScoreTextMesh2.text += value;
	}

	public void UpdateScore3 (string value)
	{
		ScoreTextMesh3.text = scoreText3;
		ScoreTextMesh3.text += value;
	}

	public void UpdateScore5 (string value)
	{
		ScoreTextMesh5.text = scoreText5;
		ScoreTextMesh5.text += value;
	}
	public void UpdateScore6 (string value)
	{
		ScoreTextMesh6.text = scoreText6;
		ScoreTextMesh6.text += value;
	}
}
