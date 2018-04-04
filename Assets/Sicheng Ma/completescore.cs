using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class completescore : MonoBehaviour {
	
	public TextMesh TimeTextMesh;
	private string timeText;

	// Use this for initialization
	void Start () {
		
		timeText = TimeTextMesh.text;
	}
	
	// Update is called once per frame
	void Update () {
		UpdateTime (countingtime.minutes + " : " + countingtime.seconds);
	}

	public void UpdateTime(string value){
		TimeTextMesh.text = timeText;
		TimeTextMesh.text += value;
	}
}
