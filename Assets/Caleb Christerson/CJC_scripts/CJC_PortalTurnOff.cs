using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_PortalTurnOff : MonoBehaviour {

	[SerializeField]
	GameObject text;

	bool weebnutz = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		GameObject core = GameObject.FindWithTag ("Magician");
		Followingmonster gamecore = core.GetComponent<Followingmonster> ();
		


		if (gamecore.DeezNutz && gamecore != null) {
			weebnutz = true;
		}
		if (weebnutz)
		{
			text.SetActive (true);
			Destroy (text, 3);
			Destroy (gameObject, 3.01f);
		}

		
	}
}
