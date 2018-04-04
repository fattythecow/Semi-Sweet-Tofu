using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CJC_Level : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DoTheLevelSelect()
	{
		GameObject p2 = GameObject.Find ("_Manager");
		Playersalwaysmakingdecisions  gman= p2.GetComponent<Playersalwaysmakingdecisions> ();

		SceneManager.LoadScene (gman.selectableUIScenes [gman.SelectedUIScenes]);
	}
}
