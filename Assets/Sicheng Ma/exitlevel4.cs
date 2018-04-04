using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitlevel4 : MonoBehaviour {

	[SerializeField]
	string NextLevel = null;

	public GameObject scroll;

	static public bool finishLevel;

	// Use this for initialization
	void Start () {
		finishLevel = false;
	}

	// Update is called once per frame
	void Update () {
		GameObject dir = GameObject.FindWithTag ("Player");
		CJC_PlayerAnimController anim = dir.GetComponent<CJC_PlayerAnimController> ();

		if (anim.completedLevelanimation)
		{
			SceneManager.LoadScene (NextLevel);
		}
	}

	void OnTriggerEnter (Collider other)
	{GameObject dir = GameObject.FindWithTag ("Player");
		CJC_PlayerAnimController anim = dir.GetComponent<CJC_PlayerAnimController> ();
		if (other.tag == "Player") 
		{
			if (scroll == null) {anim.animCompletedLevel = true;
			//	SceneManager.LoadScene (NextLevel);
				finishLevel = true;
				CJC_Scoring.PlayerScore += 1000;
				CJC_Scoring.hasbeenscored4 = true;
				countingtime.startcounting = false;
			}
		}
	}
}
