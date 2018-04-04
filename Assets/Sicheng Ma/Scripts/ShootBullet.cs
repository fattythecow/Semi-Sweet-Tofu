using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour {

	public GameObject enBullet;

	public float FireTimer = 0f;

	public float FireRate = 1.0f;

	public FuckingGUDAI toplayer;

	public GameObject warning;

	public GameObject warning2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();
		if (shop.isopen == false) {
			if (toplayer.spotted) {
				if (toplayer.reverseMove) {
					warning.SetActive (true);
					warning2.SetActive (false);
				} else {
					warning.SetActive (false);
					warning2.SetActive (true);
				}
				Firing ();
			} else {
				warning.SetActive (false);
				warning2.SetActive (false);
			}
		}
	}

	void Firing() {
		//accumualte time each frame. When the fire key is pressed, we check if enough time has passed
		FireTimer += Time.deltaTime;

		//detect of the fire button has been pressed

		//has the fire timer exceeded the amount of time between the spawning of bullets?
		if (FireTimer > FireRate) {

			//reset the timer so it will start counting from scratch for the next shot
			FireTimer = 0;

			Instantiate (enBullet, transform.position, transform.rotation);
		}

	}
}
