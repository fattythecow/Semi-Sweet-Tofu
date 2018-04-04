//------------------------------------------------------------------------------------------------ 
// Author:  caleb Christerson
// Date:    11/03/2016 
// Credit:  Mark Brown (course teacher for PGF2) 
// Credit:  PGF201 experiment 2 (step by step "how to")
// Purpose: controller for player and enemy shield
//------------------------------------------------------------------------------------------------

using UnityEngine;
using System.Collections;

public class CJC_LAB2_spinningshield : MonoBehaviour 
{
	[SerializeField]
	float rotatespeed = 1.0f;

	[SerializeField]
	bool rotateX = false;
	[SerializeField]
	bool rotateY = false;
	[SerializeField]
	bool rotateZ = false;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();
		if (shop.isopen == false) {
			RotateOnX ();
			RotateOnY ();
			RotateOnZ ();
		}
	}

	void RotateOnX()
	{
		float angle = rotatespeed * Time.deltaTime;

		if (rotateX == true) 
		{
			transform.Rotate (transform.up, angle);
		}
	}

	void RotateOnY()
	{
		float angle = rotatespeed * Time.deltaTime;

		if (rotateY == true) 
		{
			transform.Rotate (transform.right, angle);
		}
	}

	void RotateOnZ()
	{
		float angle = rotatespeed * Time.deltaTime;

		if (rotateZ == true) 
		{
			transform.Rotate (transform.forward, angle);
		}
	}
}
