using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour 
{
	public static bool willClimb = false;
	public float speed = 4.0f;
	[SerializeField]
	GameObject floor;

	/*
	[SerializeField]
	GameObject UpperLimit = null;

	[SerializeField]
	GameObject LowerLimit = null;
	*/

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();
		GameObject pj = GameObject.FindWithTag ("Player");
		CJC_tryjumping jump = pj.GetComponent<CJC_tryjumping> ();

		if(willClimb == true)
		
		{
			
			player.transform.Translate (0, Input.GetAxis ("Vertical") * Time.deltaTime * speed, p1.transform.position.z);

			if (Input.GetAxis ("Vertical") == 0)
			{
				jump.movedirection.y = 0;
			}
	
		}

	}

	void OnTriggerStay(Collider other)
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();
		GameObject pj = GameObject.FindWithTag ("Player");
		CJC_tryjumping jump = pj.GetComponent<CJC_tryjumping> ();


		if (other.gameObject.tag == "Player")
		{
			player.transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, 0);
			jump.jumpspeed = 0;
			jump.NormaldoubleJumpHeight = 0;
			willClimb = true;
			floor.GetComponent<BoxCollider> ().enabled = false;
			if (Input.GetAxis ("Vertical") == 0)
			{
				jump.movedirection.y = 0;
			}
			else if (Input.GetAxis ("Vertical") != 0)
			{
				jump.movedirection.y = Input.GetAxis("Vertical") * Time.deltaTime * speed;
			}
				
			player.IsSprinting = false;
		}

	}

	void OnTriggerExit(Collider other)
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();
		GameObject pj = GameObject.FindWithTag ("Player");
		CJC_tryjumping jump = pj.GetComponent<CJC_tryjumping> ();

		if (other.gameObject.tag == "Player")
		{
			floor.GetComponent<BoxCollider> ().enabled = true;
			jump.jumpspeed = 13;
			jump.NormaldoubleJumpHeight = 8;
			willClimb = false;

		}
	}
}
