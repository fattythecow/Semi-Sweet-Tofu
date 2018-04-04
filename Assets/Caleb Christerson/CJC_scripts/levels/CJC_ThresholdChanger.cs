using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_ThresholdChanger : MonoBehaviour {

	[SerializeField]
	bool UsingForVerticalThreshold = false;
	[SerializeField]
	bool UsingForHorizontalThreshold = false;

	[SerializeField]
	GameObject Lefttree;
	[SerializeField]
	GameObject Righttree;
	[SerializeField]
	GameObject Uptree;
	[SerializeField]
	GameObject Downtree;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		ManageTree ();
	}

	/*void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player") 
		{
			if (Lefttree.activeInHierarchy == true) 
			{
				tree1.SetActive (false);
				Righttree.SetActive (true);
			}
			else if (Righttree.activeInHierarchy == true) 
			{
				Righttree.SetActive (false);
				tree1.SetActive (true);
			}
		}
	}*/

	void ManageTree()
	{
		GameObject soppe = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = soppe.GetComponent<CJC_PlayerAndBools> ();

		if (UsingForHorizontalThreshold == true)
		{
			if (player.transform.position.x < gameObject.transform.position.x)
			{
				Righttree.SetActive (false);
				Lefttree.SetActive (true);
			} 
			else if (player.transform.position.x > gameObject.transform.position.x)
			{
				Righttree.SetActive (true);
				Lefttree.SetActive (false);
			}
		}
		else if (UsingForVerticalThreshold == true)
		{
			if (player.transform.position.y < gameObject.transform.position.y)
			{
				Uptree.SetActive (false);
				Downtree.SetActive (true);
			} 
			else if (player.transform.position.y > gameObject.transform.position.y)
			{
				Uptree.SetActive (true);
				Downtree.SetActive (false);
			}
		}


	}
}
