using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_checkforcontrollerTUT : MonoBehaviour {

	public bool controllerConnected = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Cursor.visible = false;
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
					controllerConnected = true;
					Debug.Log ("controller " + i + " is connected using: " + temp [i]);
				} 
				else
				{
					controllerConnected = false;
					Debug.Log ("controller: " + i + "is disconnected");
				}
			}
		}
	}
}
