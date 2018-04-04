using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_TofuPickup : MonoBehaviour 
{
	[SerializeField]
	float sinRangeX = 0;
	[SerializeField]
	float sinRangeY = 0;
	[SerializeField]
	float sinRangeZ = 0;
	[SerializeField]
	float rotatSpeed = 45;


	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		GameObject starvation = GameObject.FindWithTag ("GameCore");
		CJC_PauseShit gamecore = starvation.GetComponent<CJC_PauseShit> ();
		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();

		if (gamecore.paused != true && !shop.isopen)
		{
			DoRotation ();
			DoCoolMovement ();
		}
	}

	void OnTriggerEnter(Collider other)
	{
		GameObject livess = GameObject.Find ("Lives");
		CJC_livesPFI lives = livess.GetComponent<CJC_livesPFI> ();

		GameObject sou = GameObject.FindWithTag ("Player");
		CJC_SoundHolder sound = sou.GetComponent<CJC_SoundHolder> ();

		if (other.tag == "Player") 
		{
			sound.GetComponent<AudioSource> ().PlayOneShot (sound.LifeGainedSound);
			lives.LiveGained = true;
			CJC_LifeCount.PlayerLives++;
			Destroy (gameObject);
		}
	}

	void DoRotation()
	{
		this.transform.Rotate (0, rotatSpeed * Time.deltaTime, 0, Space.World);
	}

	void DoCoolMovement()
	{
		transform.position = transform.position + new Vector3 (Mathf.Sin (Time.time *2) * sinRangeX, Mathf.Sin (Time.time * 2) * sinRangeY, Mathf.Sin (Time.time * 2) * sinRangeZ);
	}
}
