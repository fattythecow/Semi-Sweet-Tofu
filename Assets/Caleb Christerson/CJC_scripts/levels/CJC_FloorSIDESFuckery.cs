using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_FloorSIDESFuckery : MonoBehaviour {

	public GameObject Player;
	[SerializeField]
	float KeepBackDistance = 2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Player = GameObject.FindWithTag ("Player");
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{

			if (Player.transform.position.x < gameObject.transform.position.x)
			{
				Player.transform.position = new Vector3 (Player.transform.position.x - KeepBackDistance, Player.transform.position.y, Player.transform.position.z);
			} 
			else if (Player.transform.position.x > gameObject.transform.position.x)
			{
				Player.transform.position = new Vector3 (Player.transform.position.x + KeepBackDistance, Player.transform.position.y, Player.transform.position.z);
			}

		}
	}

	void OnTriggerStay(Collider other)
	{
		if (other.tag == "Player")
		{

			if (Player.transform.position.x < gameObject.transform.position.x)
			{
				Player.transform.position = new Vector3 (Player.transform.position.x - KeepBackDistance, Player.transform.position.y, Player.transform.position.z);
			} 
			else if (Player.transform.position.x > gameObject.transform.position.x)
			{
				Player.transform.position = new Vector3 (Player.transform.position.x + KeepBackDistance, Player.transform.position.y, Player.transform.position.z);
			}

		}
	}
}
