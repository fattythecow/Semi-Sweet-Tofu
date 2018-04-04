using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pauseomg : MonoBehaviour {

	public bool pause = false;


	public GameObject monsterBoots;



	// Use this for initialization
	void Start ()
	{
		monsterBoots.SetActive (true);
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (monsterBoots.activeInHierarchy == true)
		{
			pause = true;
		} 
		else
			pause = false;
	
		if (!pause)
		{
			Time.timeScale = 1;
		} 
		else
		{
			Time.timeScale = 0;
		}



		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			if (pause == true)
			{
				pause = false;
			}
			monsterBoots.SetActive (false);
		}
	}
}
