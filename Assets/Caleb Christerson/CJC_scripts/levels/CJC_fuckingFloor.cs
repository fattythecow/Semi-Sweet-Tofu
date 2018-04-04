using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_fuckingFloor : MonoBehaviour 
{
	[SerializeField]
	bool playerin = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{

		
	}

	void OnTriggerStay(Collider other)
	{
		if (other.tag == "Player")
		{
			playerin = true;

			GameObject p1 = GameObject.FindWithTag ("Player");
			CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

			if (playerin == true)
			{
				if (player.transform.position.y -1 < gameObject.transform.position.y)
				{
					//player.transform.position = new Vector3 (player.transform.position.x, player.transform.position.y+1);
					player.transform.position = new Vector3 (player.transform.position.x-.1f, player.transform.position.y);
					player.transform.position = new Vector3 (player.transform.position.x-.1f, player.transform.position.y);
					player.transform.position = new Vector3 (player.transform.position.x-.1f, player.transform.position.y);
					Debug.Log ("saved players ass");
				} 
				else
					player.transform.position = player.transform.position;
			}
		}
	}
	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player")
		playerin = false;
	}
}
