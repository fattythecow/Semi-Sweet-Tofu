using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_platformStopper : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();

		if (shop.isopen)
		{
			GetComponent<MultipointMover> ().enabled = false;
		}
		else if (!shop.isopen)
		{
			GetComponent<MultipointMover> ().enabled = true;
		}

	}
}
