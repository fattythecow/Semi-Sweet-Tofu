using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CJC_FromCredsToMain : MonoBehaviour {


	[SerializeField]
	string Scene;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void PressFuckingButtonsAndShit()
	{ 

		SceneManager.LoadScene (Scene);
	}

}
