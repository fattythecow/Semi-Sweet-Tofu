using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_KeepPlayerLeft : MonoBehaviour
{
	[SerializeField]
	bool KeepScrubLeft = false;
	[SerializeField]
	bool KeepScrubRight = false;
	public GameObject Player;

	[SerializeField]
	float KeepBackDistance = 2;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		Player = GameObject.FindWithTag ("Player");

		if (KeepScrubLeft == true) 
		{
			KeepScrubRight = false;
			KeepScrubLeftFunction ();
		}
		if (KeepScrubRight == true) 
		{
			KeepScrubLeft = false;
			KeepScrubRightFunction ();
		}
	}

	void KeepScrubLeftFunction()
	{
		if (Player.transform.position.x > (gameObject.transform.position.x - KeepBackDistance)) 
		{
			Player.transform.position = new Vector3 (Player.transform.position.x - KeepBackDistance, Player.transform.position.y, Player.transform.position.z);
		}
	}

	void KeepScrubRightFunction()
	{
		if (Player.transform.position.x < (gameObject.transform.position.x + KeepBackDistance)) 
		{
			Player.transform.position = new Vector3 (Player.transform.position.x + KeepBackDistance, Player.transform.position.y, Player.transform.position.z);
		}
	}
}
