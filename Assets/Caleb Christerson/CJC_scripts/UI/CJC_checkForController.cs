using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_checkForController : MonoBehaviour
{

	[SerializeField]
	GameObject Controller = null;
	[SerializeField]
	GameObject Keyboard = null;

	// Use this for initialization
	void Start ()
	{
		Keyboard.SetActive (true);
		Controller.SetActive (false);
	}
	
	// Update is called once per frame
	void Update ()
	{
		/*if (Input.GetJoystickNames ().Length > 0) 
		{
			Debug.Log (Input.GetJoystickNames ().Length);
			//Debug.Log ("controller plugged in");
		}
		else if (Input.GetJoystickNames () == null) 
		{
			Debug.Log (Input.GetJoystickNames ().Length);
		}*/

		TestForControllers ();

	}

	void TestForControllers()
	{
		string[] temp = Input.GetJoystickNames ();

		if (temp.Length > 0) 
		{
			for (int i = 0; i < temp.Length; i++) 
			{
				if (!string.IsNullOrEmpty (temp [i]))
				{
					Controller.SetActive (true);
					Keyboard.SetActive (false);
					Debug.Log ("controller " + i + " is connected using: " + temp [i]);
				} 
				else
				{
					Controller.SetActive (false);
					Keyboard.SetActive (true);
					Debug.Log ("controller: " + i + "is disconnected");
				}
			}
		}
	}
}
