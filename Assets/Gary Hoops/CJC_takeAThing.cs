using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_takeAThing : MonoBehaviour
{
	[SerializeField]
	GameObject MakeScriptLeave;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			MakeScriptLeave.GetComponent<CJC_KeepPlayerLeft> ().enabled = false;
		} 
		else if (MakeScriptLeave.GetComponent<CJC_KeepPlayerLeft>() == null) 
		{
			Debug.Log ("fucking scrub");
		}
	}
}
