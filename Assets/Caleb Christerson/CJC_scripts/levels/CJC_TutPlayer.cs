using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CJC_TutPlayer : MonoBehaviour {

	[SerializeField]
	GameObject videoToPlay = null;
	public bool VideoOn = false;
	//[SerializeField]
	//GameObject backdrop;




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();
		GameObject core = GameObject.Find ("CoreGameController");
		CJC_PauseShit pitbull = core.GetComponent<CJC_PauseShit> ();

		if (Time.timeScale == 0)
		{
			videoToPlay.GetComponent<VideoPlayer> ().playbackSpeed = 0;
		}
		else if (VideoOn && !shop.isopen && !pitbull.paused) 
		{
			//videoToPlay.SetActive (true);
			//backdrop.GetComponent<SpriteRenderer>().enabled = true;
			videoToPlay.GetComponent<MeshRenderer> ().enabled = true;
			videoToPlay.GetComponent<VideoPlayer> ().playbackSpeed = 1;
		}
		else if (!VideoOn) 
		{
			//videoToPlay.SetActive (false);
			//backdrop.GetComponent<SpriteRenderer>().enabled = false;
			videoToPlay.GetComponent<MeshRenderer> ().enabled = false;
			videoToPlay.GetComponent<VideoPlayer> ().playbackSpeed = 0;
		}
		else if (pitbull.paused | shop.isopen) 
		{
			videoToPlay.GetComponent<VideoPlayer> ().playbackSpeed = 0;
		}

	}

	void OnTriggerStay(Collider other)
	{
		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();
		GameObject core = GameObject.Find ("CoreGameController");
		CJC_PauseShit pitbull = core.GetComponent<CJC_PauseShit> ();

		if (other.tag == "Player"  && !shop.isopen  && !pitbull.paused) 
		{
			VideoOn = true;
		}
		else if (other.tag == "Player"  && shop.isopen | pitbull.paused) 
		{
			videoToPlay.GetComponent<VideoPlayer> ().playbackSpeed = 0;
		}
	}
	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player") 
		{
			VideoOn = false;
		}
	}
}
