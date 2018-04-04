using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_InWater : MonoBehaviour {

	[SerializeField]
	float draglevel = 4;
	[SerializeField]
	float Yvelocity = 1;
	//[SerializeField]
	//float Xvelocity = 1;
	public bool inwater;

	[SerializeField]
	AudioClip enterwater;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnTriggerEnter(Collider other)
	{

		if (other.tag == "Player") 
		{
			GetComponent<AudioSource> ().PlayOneShot (enterwater);
		}

	}

	void OnTriggerStay(Collider other)
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();
		GameObject pj = GameObject.FindWithTag ("Player");
		CJC_tryjumping jump = pj.GetComponent<CJC_tryjumping> ();

		GameObject p2 = GameObject.Find ("shooter");
		CJC_ShootProjectile shot = p2.GetComponent<CJC_ShootProjectile> ();

		if (other.tag == "Player") 
		{
			jump.PlayerInWater = true;
			//player.GetComponent<Rigidbody> ().velocity = new Vector3 (0,Yvelocity,0);
			//jump.movedirection.y -= jump.grsvity * Time.deltaTime * Yvelocity;
			jump.movedirection.y = Input.GetAxis("Vertical") * jump.jumpspeed *jump.JumpForce * player.starvingjumpheightmultipleer * player.applejumpBuff;
			//player.GetComponent<Rigidbody> ().useGravity = true;
			//player.GetComponent<Rigidbody> ().drag = draglevel;
			jump.jumpspeed = 4f;
			jump.NormaldoubleJumpHeight = 8f;
			shot.AllowPlayerToShoot = false;
			inwater = true;
		}
			
	}

	void OnTriggerExit(Collider other)
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();
		GameObject pj = GameObject.FindWithTag ("Player");
		CJC_tryjumping jump = pj.GetComponent<CJC_tryjumping> ();

		GameObject p2 = GameObject.Find ("shooter");
		CJC_ShootProjectile shot = p2.GetComponent<CJC_ShootProjectile> ();

		if (other.tag == "Player") 
		{
			GetComponent<AudioSource> ().PlayOneShot (enterwater);
			jump.PlayerInWater = false;
			player.NormalMoveSpeed = 8f;
			//player.GetComponent<Rigidbody> ().useGravity = false;
			//player.GetComponent<Rigidbody> ().drag = 0;
			jump.jumpspeed = 11f;
			jump.NormaldoubleJumpHeight =13;
			shot.AllowPlayerToShoot = true;
			inwater = false;
		}
	}

}
