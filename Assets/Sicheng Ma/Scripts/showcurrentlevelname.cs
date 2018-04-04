using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showcurrentlevelname : MonoBehaviour {

	public GameObject levelT;
	public GameObject level1;
	public GameObject level2;
	public GameObject level3;
	public GameObject level4;
	public GameObject level5;

	// Use this for initialization
	void Start () {
		levelT.SetActive (false);
		level1.SetActive (false);
		level2.SetActive (false);
		level3.SetActive (false);
		level4.SetActive (false);
		level5.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		if (player.RestartLevel == "PieSlice1") {
			levelT.SetActive (true);
			level1.SetActive (false);
			level2.SetActive (false);
			level3.SetActive (false);
			level4.SetActive (false);
			level5.SetActive (false);
		} 
		else if (player.RestartLevel == "PieSlice2") {
			levelT.SetActive (false);
			level1.SetActive (true);
			level2.SetActive (false);
			level3.SetActive (false);
			level4.SetActive (false);
			level5.SetActive (false);
		}
		else if (player.RestartLevel == "PieSlice3") {
			levelT.SetActive (false);
			level1.SetActive (false);
			level2.SetActive (true);
			level3.SetActive (false);
			level4.SetActive (false);
			level5.SetActive (false);
		}
		else if (player.RestartLevel == "Level3") {
			levelT.SetActive (false);
			level1.SetActive (false);
			level2.SetActive (false);
			level3.SetActive (true);
			level4.SetActive (false);
			level5.SetActive (false);
		}
		else if (player.RestartLevel == "Level5") {
			levelT.SetActive (false);
			level1.SetActive (false);
			level2.SetActive (false);
			level3.SetActive (false);
			level4.SetActive (true);
			level5.SetActive (false);
		}
		else if (player.RestartLevel == "Level6") {
			levelT.SetActive (false);
			level1.SetActive (false);
			level2.SetActive (false);
			level3.SetActive (false);
			level4.SetActive (false);
			level5.SetActive (true);
		}

	}

}
