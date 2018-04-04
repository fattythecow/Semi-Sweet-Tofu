using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_SpikeTrap : MonoBehaviour 
{
	[SerializeField]
	GameObject SpikeTrap;
	Animator SpikeAnim;
	bool SteppedOn;

	// Use this for initialization
	void Start ()
	{
		SpikeAnim = SpikeTrap.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();
		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();

		if (!player.PlayerDied) {
			if (shop.isopen == true)
				SpikeAnim.speed = 0;
			else
				SpikeAnim.speed = 1.25f;

			SteppedOn = SpikeAnim.GetBool ("SteppedOn");
		}
	}

	void OnTriggerStay (Collider other)
	{	GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();
		if (!player.PlayerDied) {
			if (other.tag == "Player" || other.tag == "Monster") {
				SpikeAnim.SetBool ("SteppedOn", true);
			}
		}
	}

	void OnTriggerExit (Collider other)
	{	GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();
		if (!player.PlayerDied) {
			if (other.tag == "Player" || other.tag == "Monster") {
				SpikeAnim.SetBool ("SteppedOn", false);
			}
		}
	}

	public void turnoffsound ()
	{
		GetComponentInChildren<AudioSource> ().enabled = false;
	}

	public void SetToFalse()
	{
		SpikeAnim.SetBool ("SteppedOn", false);
	}

	public void SetToTrue()
	{
		SpikeAnim.SetBool ("SteppedOn", true);
	}


}
