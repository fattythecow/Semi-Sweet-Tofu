using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_DoToTips : MonoBehaviour {

	[SerializeField]
	GameObject tooltip = null;

	public bool CanPress=false;
	[SerializeField]
	GameObject readme = null;
	//public static bool AReadableOpen = false;
	bool turnonTip = false;
	//public static bool readableOpen = false;

	GameObject CanvasParent;
	GameObject OriginParent;

	// Use this for initialization
	void Awake()
	{
		OriginParent = gameObject;
		CanvasParent= GameObject.Find ("ShopCanvas");
		tooltip.transform.parent = CanvasParent.transform;
	}

	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		GameObject coregame = GameObject.FindWithTag ("GameCore");
		CJC_PauseShit core = coregame.GetComponent<CJC_PauseShit> ();

		if (turnonTip)
		{
			if (CanPress)
			{
				core.paused = true;
				readme.SetActive (false);
				tooltip.SetActive (true);
				//tooltip.transform.parent = CanvasParent.transform;
			}
		}
		else if (!turnonTip)
		{
			if (CanPress)
			{
			//tooltip.transform.parent = OriginParent.transform;
			//Debug.Log ("blah");
			//core.paused = false;
			tooltip.SetActive (false);
			//Time.timeScale = 1;
			}
		}
		ManagePressing ();
	}

	void ManagePressing()
	{
		GameObject coregame = GameObject.FindWithTag ("GameCore");
		CJC_PauseShit core = coregame.GetComponent<CJC_PauseShit> ();

		if (CanPress)
		{
			if (Input.GetKeyDown (KeyCode.X) || Input.GetButtonDown ("360_XButton"))
			{
				if (!turnonTip && !core.paused)
				{
					turnonTip = true;
					Debug.Log ("CanPress False");
					CanPress = false;

				}
				else if (turnonTip && core.paused)
				{
					turnonTip = false;
					Debug.Log ("CanPress True");
					CanPress = true;
					core.paused = false;

				}
			}
		}
	}

	void OnTriggerStay(Collider other)
	{
		if (other.tag == "Player")
		{
			//turnonTip = true;
			readme.SetActive (true);
			CanPress = true;
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player")
		{
			turnonTip = false;
			//turnonTip = false;
			readme.SetActive (false);
			CanPress = false;
		}
	}
}
