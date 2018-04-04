using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_PopSmoke : MonoBehaviour {

	public GameObject AnimHolder = null;
	public bool InMagiArea = false;
	private Animator cameraanim = null;



	// Use this for initialization
	void Start () {
		cameraanim = AnimHolder.GetComponent<Animator> ();
		InMagiArea = false;
	}
	
	// Update is called once per frame
	void Update () {
		Transition ();
	}

	void Transition()
	{
		if (InMagiArea)
		{
			cameraanim.SetBool ("InMagiArea", true);
		}
		else if (!InMagiArea)
		{
			cameraanim.SetBool ("InMagiArea", false);
		}
	}
}
