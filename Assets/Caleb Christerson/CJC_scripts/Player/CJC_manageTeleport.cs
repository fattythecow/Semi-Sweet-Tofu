using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_manageTeleport : MonoBehaviour 
{
	bool currentlyTeleporting = false;
	public static bool KnowsTeleport = false;
	public bool CanTeleport = false;
	[SerializeField]
	int TeleportDistance = 10;
	public float TeleportTimer = 4;
	public float MaxTeleportTimer = 4;

	public float teleportSpeed = 1;

	[SerializeField]
	GameObject TrailEffect = null;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();
		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();

		if (shop.isopen == false) {
			TrailEffect.transform.position = player.transform.position;

			BuyTelePortoBro ();
			ManageTeleportSpot ();
			DoYouEvenTeleBro ();
		}
	}

	void BuyTelePortoBro()
	{
		

		if (KnowsTeleport == true) 
		{
			TeleportTimer += Time.deltaTime;


			if (TeleportTimer >= MaxTeleportTimer) 
			{
				TeleportTimer = MaxTeleportTimer;

				CanTeleport = true;
			}
			else if (TeleportTimer < MaxTeleportTimer)
			{
				CanTeleport = false;
			}


			//boughtTeleport = false;
		}
	}

	void ManageTeleportSpot()
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();
		GameObject no = GameObject.Find ("nose");
		CJC_ShowDirection nose = no.GetComponent<CJC_ShowDirection> ();
		GameObject core = GameObject.FindWithTag ("GameCore");
		CJC_PauseShit gamecore = core.GetComponent<CJC_PauseShit> ();

		if (gamecore.paused == true) 
		{
			TrailEffect.GetComponent<TrailRenderer> ().enabled = false;
		} 
		else if (gamecore.paused == false)
		{
			TrailEffect.GetComponent<TrailRenderer> ().enabled = true;
		}


		if (currentlyTeleporting == false)
		{
			if (nose.facingright == true) 
			{
				gameObject.transform.position = new Vector3 (player.transform.position.x + TeleportDistance, player.transform.position.y + .5f, player.transform.position.z);
			} 
			else if (nose.facingleft == true) 
			{
				gameObject.transform.position = new Vector3 (player.transform.position.x - TeleportDistance, player.transform.position.y + .5f, player.transform.position.z);
			}
				//TrailEffect.GetComponent<TrailRenderer> ().enabled = false;
			TrailEffect.GetComponent<TrailRenderer> ().time = 0;
		}
		else if (currentlyTeleporting == true) 
		{
			gameObject.GetComponent<BoxCollider> ().enabled = true;
			gameObject.transform.position = gameObject.transform.position;
			//TrailEffect.GetComponent<TrailRenderer> ().enabled = true;
			TrailEffect.GetComponent<TrailRenderer> ().time = 1;
			player.transform.position = Vector3.Lerp (player.transform.position, gameObject.transform.position, teleportSpeed);
			Debug.Log ("mutha fucking teleport and shit");
		}
	}

	void DoYouEvenTeleBro()
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		if (CanTeleport == true) 
		{
			if (Input.GetKeyDown (KeyCode.Tab) | Input.GetButtonDown ("360_LeftBumper")) 
			{
				
				TeleportTimer = 0;
				CanTeleport = false;
				currentlyTeleporting = true;
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") 
		{
			currentlyTeleporting = false;
			gameObject.GetComponent<BoxCollider> ().enabled = false;
		}
	}
}
