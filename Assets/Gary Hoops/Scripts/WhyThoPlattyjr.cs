using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhyThoPlattyjr : MonoBehaviour {

	[SerializeField]
	GameObject Platty;
	Animator anim;
	bool isOn;

	// Use this for initialization
	void Start ()
	{
		anim = Platty.GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () 
	{
		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();
		if (shop.isopen == true)
			anim.speed = 0;
		else
			anim.speed = 1;

		isOn = anim.GetBool ("isOn");
	}

	void OnTriggerStay (Collider other)
	{
		if (other.tag == "Player") 
		{
			anim.SetBool ("isOn", true);
		}
	}

	void OnTriggerExit (Collider other)
	{
		if (other.tag == "Player") 
		{
			anim.SetBool ("isOn", false);
		}
	}

	public void SetToFalse()
	{
		anim.SetBool ("isOn", false);
	}

	public void SetToTrue()
	{
		anim.SetBool ("isOn", true);
	}


}
