using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MRKEYVAN : MonoBehaviour {

	[SerializeField]
	string Scene;

	public string level;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update ()
	{
		PressFuckingButtonsAndShit ();
	}

	void PressFuckingButtonsAndShit()
	{ 
		if (Input.GetButtonDown ("360_BButton")) //| Input.GetKeyDown(KeyCode.Escape)) 
		{
			SceneManager.LoadScene (Scene);
		}
	}

	public void OnClick(){
		SceneManager.LoadScene (level);
	}
}
