using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Storycontent : MonoBehaviour {
	[SerializeField]
	string NextLevel = null;

	public GameObject storybar;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject dir = GameObject.FindWithTag ("Player");
		CJC_PlayerAnimController anim = dir.GetComponent<CJC_PlayerAnimController> ();

		if (anim.completedLevelanimation)
		{
			storybar.SetActive (true);
		}

		if (storybar.activeInHierarchy) {
			Time.timeScale = 0;
			checkforinput ();
		}
	}

	void checkforinput(){
		if (Input.GetKeyDown (KeyCode.Return) | Input.GetButtonDown ("360_AButton")) {
			
			SceneManager.LoadScene (NextLevel);
			Time.timeScale = 1;
		}
	}
}
