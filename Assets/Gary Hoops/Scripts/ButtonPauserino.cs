using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPauserino : MonoBehaviour {

	public bool paused = true;
		string pausestate = "";

		[SerializeField]
		GameObject monsterButton;

		// Use this for initialization
		void Start () 
		{
		HandlePause (true);
		}

		// Update is called once per frame
		void Update () 
		{
			CheckInput ();
			CheckPause ();

			if (paused) 
			{
				return;
			}

		Debug.Log ("omfg");
		}

		void CheckPause()
		{
		if (paused == true) 
			{
				pausestate = "enabled";
			}
		else if (paused == false) 
			{
				pausestate = "disabled";
			}
		}

		void CheckInput()
		{
		if (Input.GetKeyUp (KeyCode.Space) | Input.GetButtonDown ("360_AButton") | Input.GetButtonDown("ps4_XButton")) 
			{
				HandlePause (paused);
			}
		}

		void SetPaused (bool _paused)
		{
			paused = _paused;

			if (paused)
			{
				Time.timeScale = 0;
			}
			else 
			{
				Time.timeScale = 1;
			}
		}

		public static void MakeChild(GameObject _child)
		{
			GameObject coreGameObj = GameObject.FindWithTag ("GameCore");

			_child.transform.parent = coreGameObj.transform;

		Debug.Log ("Yo");
		}

		public void HandlePause (bool _pause)
		{
			paused = _pause;

			BroadcastMessage ("SetPaused", paused);

			if (paused)
			{
				Time.timeScale = 0;
			}
			else 
			{
				Time.timeScale = 1;
			}

			monsterButton.SetActive (paused);
		}
	}


