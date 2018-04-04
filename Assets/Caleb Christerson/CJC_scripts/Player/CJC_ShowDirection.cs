using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_ShowDirection : MonoBehaviour 
{
	[SerializeField]
	GameObject leftside = null;
	[SerializeField]
	GameObject rightside = null;

	public bool facingleft = false;
	public bool facingright = false;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		if (!player.PlayerDied) {

			DoDirectionTell ();
			DoDirectionchange ();
		}
	}

	void DoDirectionTell()
	{
		if (Input.GetAxis ("Horizontal") > 0) 
		{
			facingright = true;
			facingleft = false;
		}
		else	if (Input.GetAxis ("Horizontal") <0) 
		{
			facingright = false;
			facingleft = true;
		}
	}

	void RotateOnce()
	{
		
	}

	void DoDirectionchange()
	{
		if (facingright == true) 
		{
			gameObject.transform.position = rightside.transform.position;
			gameObject.transform.Rotate (0, 0, 0, Space.World);
		}
		else if (facingleft == true) 
		{
			gameObject.transform.position = leftside.transform.position;
			gameObject.transform.Rotate (0, 180, 0, Space.World);
		}
	}
}
