using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GH_Colorless : MonoBehaviour {

	[SerializeField]
	GameObject wallToColor = null;
	[SerializeField]
	GameObject liner = null;

	bool alreadypassedthrough = false;

	[SerializeField]
	float KeepBackDistance = .25f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		CheckForClear ();
		manageColors ();
	}

	void manageColors()
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		if (player.IsPurple | player.IsGreen | player.IsRed | player.IsYellow) 
			{
				wallToColor.GetComponent<MeshRenderer> ().material.color = new Color32 (255,255,255,255);
				liner.GetComponent<MeshRenderer> ().enabled = false;
			}
		else if (!player.IsPurple && !player.IsGreen && !player.IsRed && !player.IsYellow) 
			{
				wallToColor.GetComponent<MeshRenderer> ().material.color = new Color32 (255, 255, 255, 12);
				liner.GetComponent<MeshRenderer> ().enabled = true;
			}
	}

	void OnTriggerStay(Collider other)
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		if (other.tag == "Player")
		{

			if (player.IsPurple | player.IsGreen | player.IsRed | player.IsYellow) 
			{
				alreadypassedthrough = false;
			}
			else if (!player.IsPurple && !player.IsGreen && !player.IsRed && !player.IsYellow) 
			{
				alreadypassedthrough = true;
			}
			else if (alreadypassedthrough == false) 
			{
				if (player.transform.position.x < gameObject.transform.position.x)
				{
					player.transform.position = new Vector3 (player.transform.position.x - KeepBackDistance, player.transform.position.y, player.transform.position.z);
				} 
				else if (player.transform.position.x > gameObject.transform.position.x)
				{
					player.transform.position = new Vector3 (player.transform.position.x + KeepBackDistance, player.transform.position.y, player.transform.position.z);
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

