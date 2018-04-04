using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_ColorPlatforms : MonoBehaviour {

	[SerializeField]
	bool IsGreen = false;
	[SerializeField]
	bool IsRed = false;
	[SerializeField]
	bool IsYellow = false;
	[SerializeField]
	bool IsPurple = false;

	[SerializeField]
	GameObject wallToColor = null;
	[SerializeField]
	GameObject liner = null;

	bool alreadypassedthrough = false;

	public GameObject Player;
	float KeepBackDistance = .5f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		CheckForClear ();
		manageColors ();
		Player = GameObject.FindWithTag ("Player");
	}

	void manageColors()
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		if (IsYellow == false && IsGreen == false && IsRed == false && IsPurple == false) 
		{
			wallToColor.GetComponent<MeshRenderer> ().material.color = Color.white;
		}
		else if (IsGreen == true) 
		{
			//wallToColor.GetComponent<MeshRenderer> ().material.color = Color.green;

			if (player.IsGreen) 
			{
				wallToColor.GetComponent<MeshRenderer> ().material.color = new Color32 (117,255,199,35);
				liner.GetComponent<MeshRenderer> ().enabled = true;
			}
			else if (!player.IsGreen) 
			{
				wallToColor.GetComponent<MeshRenderer> ().material.color = new Color32 (117,255,199, 255);
				liner.GetComponent<MeshRenderer> ().enabled = false;
			}
		}
		else if (IsRed == true) 
		{
			if (player.IsRed) 
			{
				wallToColor.GetComponent<MeshRenderer> ().material.color = new Color32 (232,103,106,35);
				liner.GetComponent<MeshRenderer> ().enabled = true;
			}
			else if (!player.IsRed) 
			{
				wallToColor.GetComponent<MeshRenderer> ().material.color = new Color32 (232,103,106, 255);
				liner.GetComponent<MeshRenderer> ().enabled = false;
			}
		}
		else if (IsYellow == true) 
		{
			if (player.IsYellow) 
			{
				wallToColor.GetComponent<MeshRenderer> ().material.color = new Color32 (255,140,20,35);
				liner.GetComponent<MeshRenderer> ().enabled = true;
			}
			else if (!player.IsYellow) 
			{
				wallToColor.GetComponent<MeshRenderer> ().material.color = new Color32 (255,140,20,255);
				liner.GetComponent<MeshRenderer> ().enabled = false;
			}
		}
		else if (IsPurple == true) 
		{
			if (player.IsPurple) 
			{
				wallToColor.GetComponent<MeshRenderer> ().material.color = new Color32 (233,187,255,35);
				liner.GetComponent<MeshRenderer> ().enabled = true;
			}
			else if (!player.IsPurple) 
			{
				wallToColor.GetComponent<MeshRenderer> ().material.color = new Color32 (233,187,255, 255);
				liner.GetComponent<MeshRenderer> ().enabled = false;
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();
		GameObject jj = GameObject.FindWithTag ("Player");
		CJC_tryjumping jumper = jj.GetComponent<CJC_tryjumping> ();

		if (other.tag == "Player")
		{

			if (IsGreen == true)
			{
				if (player.IsGreen == true) 
				{
					alreadypassedthrough = true;
					player.OnGround = false;
					//player.Hasjumped = true;
					//jumper.contorller.isGrounded = false;
				}
			} 
			else if (IsRed == true)
			{
				if (player.IsRed == true)
				{
					alreadypassedthrough = true;
					player.OnGround = false;
					//player.Hasjumped = true;
				//jumper.contorller.isGrounded = false;
				}
			} 
			else if (IsYellow == true) 
			{
				if (player.IsYellow == true)
				{
					alreadypassedthrough = true;
					player.OnGround = false;
					//player.Hasjumped = true;
					//jumper.contorller.isGrounded = false;
				}
			} 
			else if (IsPurple == true)
			{
				if (player.IsPurple == true)
				{
					alreadypassedthrough = true;
					player.OnGround = false;
					//player.Hasjumped = true;
					//jumper.contorller.isGrounded = false;
				}
			} 
			else if (alreadypassedthrough == false) 
			{


				if (Player.transform.position.y < gameObject.transform.position.y)
				{
					Player.transform.position = new Vector3 (Player.transform.position.x, Player.transform.position.y  - KeepBackDistance, Player.transform.position.z);
				} 
				else if (Player.transform.position.y > gameObject.transform.position.y)
				{
					Player.transform.position = new Vector3 (Player.transform.position.x, Player.transform.position.y  + KeepBackDistance, Player.transform.position.z);
				}
			}
		}
	}

	void OnTriggerStay(Collider other)
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();
		GameObject jj = GameObject.FindWithTag ("Player");
		CJC_tryjumping jumper = jj.GetComponent<CJC_tryjumping> ();

		if (other.tag == "Player")
		{

			if (IsGreen == true)
			{
				if (player.IsGreen == true) 
				{
					alreadypassedthrough = true;
					player.OnGround = false;
					//player.Hasjumped = true;
					//jumper.contorller.isGrounded = false;
				}
			} 
			else if (IsRed == true)
			{
				if (player.IsRed == true)
				{
					alreadypassedthrough = true;
					player.OnGround = false;
					//player.Hasjumped = true;
					//jumper.contorller.isGrounded = false;
				}
			} 
			else if (IsYellow == true) 
			{
				if (player.IsYellow == true)
				{
					alreadypassedthrough = true;
					player.OnGround = false;
					//player.Hasjumped = true;
					//jumper.contorller.isGrounded = false;
				}
			} 
			else if (IsPurple == true)
			{
				if (player.IsPurple == true)
				{
					alreadypassedthrough = true;
					player.OnGround = false;
					//player.Hasjumped = true;
					//jumper.contorller.isGrounded = false;
				}
			} 
			else if (alreadypassedthrough == false) 
			{

				if (Player.transform.position.y < gameObject.transform.position.y)
				{
					Player.transform.position = new Vector3 (Player.transform.position.x, Player.transform.position.y  - KeepBackDistance, Player.transform.position.z);
				} 
				else if (Player.transform.position.y > gameObject.transform.position.y)
				{
					Player.transform.position = new Vector3 (Player.transform.position.x, Player.transform.position.y  + KeepBackDistance, Player.transform.position.z);
				}
			}
		}
	}

	void CheckForClear()
	{
		if (alreadypassedthrough == true)
		{
			wallToColor.GetComponent<BoxCollider> ().enabled = false;
		} 
		else if (alreadypassedthrough == false) 
		{
			wallToColor.GetComponent<BoxCollider> ().enabled = true;
		}
	}

	void OnTriggerExit (Collider other)
	{
		alreadypassedthrough = false;
		//wallToColor.GetComponent<BoxCollider> ().enabled = true;
	}
}
