using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CJC_fuckingPitbull : MonoBehaviour {
	[SerializeField]
	float Timer = 0;
	[SerializeField]
	float maxtTimer = .5f;
	[SerializeField]
	bool startedcombo = false;
	bool givelives = false;

	[SerializeField]
	float comboTimer = 0;

	bool up1 =false;
	bool up2 = false;
	bool down1 =false;
	bool down2 = false;
	bool left1 =false;
	bool right1 = false;
	bool left2 =false;
	bool right2 = false;
	bool B = false;
	bool A = false;
	bool Select = false;
	bool Start1 = false;

	 bool DoOnce = false;


	[SerializeField]
	string Pitbull;

	[SerializeField]
	AudioSource Source;
	[SerializeField]
	AudioClip buttonpressed;

	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () 
	{


		if (startedcombo == true) 
		{
			Timer += Time.deltaTime;
			comboTimer += Time.deltaTime;
		}
		if (startedcombo == false) 
		{
			Timer = 0;
			comboTimer = 0;
			up1 =false;
			up2 = false;
			down1 =false;
			down2 = false;
			left1 =false;
			right1 = false;
			left2 =false;
			right2 = false;
			B = false;
			A = false;
			Select = false;
			Start1 = false;
		}

		HandleKonamiKeyboard ();
		HandleKonamiController ();
		GiveLives ();
	}

	void HandleKonamiKeyboard()
	{ 
		if (DoOnce == false) 
		{

			if (Input.GetKeyDown (KeyCode.UpArrow)) 
			{
				startedcombo = true;
				Timer = 0;
				up1 = true;
				Debug.Log ("up1");
			}

			if (Input.GetKeyDown (KeyCode.UpArrow) && Timer < maxtTimer && comboTimer > .1f && up1 == true)
			{
				Timer = 0;
				Debug.Log ("up2");
				up2 = true;
			} 
			else if (Timer > maxtTimer) 
			{
				startedcombo = false;
				Debug.Log ("failed input");
				Timer = 0;
			}


			if (Input.GetKeyDown (KeyCode.DownArrow) && Timer < maxtTimer && comboTimer > .1f && up2 == true) 
			{
				Timer = 0;
				Debug.Log ("down1");
				down1 = true;
			}
			else if (Timer > maxtTimer)
			{
				startedcombo = false;
				Debug.Log ("failed input");
				Timer = 0;
			}

			if (Input.GetKeyDown (KeyCode.DownArrow) && Timer < maxtTimer && comboTimer > .1f && down1 == true)
			{
				down2 = true;
				Timer = 0;
				Debug.Log ("down2");
			} 
			else if (Timer > maxtTimer) 
			{
				startedcombo = false;
				Debug.Log ("failed input");
				Timer = 0;
			}

			if (Input.GetKeyDown (KeyCode.LeftArrow) && Timer < maxtTimer && comboTimer > .1f && down2 == true)
			{
				left1 = true;
				Timer = 0;
				Debug.Log ("left1");
			} 
			else if (Timer > maxtTimer)
			{
				startedcombo = false;
				Debug.Log ("failed input");
				Timer = 0;
			}

			if (Input.GetKeyDown (KeyCode.RightArrow) && Timer < maxtTimer && comboTimer > .1f && left1 == true)
			{
				right1 = true;
				Timer = 0;
				Debug.Log ("right1");
			} 
			else if (Timer > maxtTimer) 
			{
				startedcombo = false;
				Debug.Log ("failed input");
				Timer = 0;
			}

			if (Input.GetKeyDown (KeyCode.LeftArrow) && Timer < maxtTimer && comboTimer > .1f && right1 == true)
			{
				left2 = true;
				Timer = 0;
				Debug.Log ("left2");
			} 
			else if (Timer > maxtTimer)
			{
				startedcombo = false;
				Debug.Log ("failed input");
				Timer = 0;
			}

			if (Input.GetKeyDown (KeyCode.RightArrow) && Timer < maxtTimer && comboTimer > .1f && left2 == true)
			{
				right2 = true;
				Timer = 0;
				Debug.Log ("right2");
			} 
			else if (Timer > maxtTimer)
			{
				startedcombo = false;
				Debug.Log ("failed input");
				Timer = 0;
			}

			if (Input.GetKeyDown (KeyCode.B) && Timer < maxtTimer && comboTimer > .1f && right2 == true)
			{
				B = true;
				Timer = 0;
				Debug.Log ("B");
			} 
			else if (Timer > maxtTimer)
			{
				startedcombo = false;
				Debug.Log ("failed input");
				Timer = 0;
			}

			if (Input.GetKeyDown (KeyCode.A) && Timer < maxtTimer && comboTimer > .1f && B == true)
			{
				A = true;
				Timer = 0;
				Debug.Log ("A");
			} 
			else if (Timer > maxtTimer)
			{
				startedcombo = false;
				Debug.Log ("failed input");
				Timer = 0;
			}

			if (Input.GetKeyDown (KeyCode.RightShift) && Timer < maxtTimer && comboTimer > .1f && A == true)
			{
				Select = true;
				Timer = 0;
				Debug.Log ("select");
			} 
			else if (Timer > maxtTimer)
			{
				startedcombo = false;
				Debug.Log ("failed input");
				Timer = 0;
			}

			if (Input.GetKeyDown (KeyCode.Return) && Timer < maxtTimer && comboTimer > .1f && Select == true) 
			{
				Start1 = true;
				Timer = 0;
				Debug.Log ("Start");
			} 
			else if (Timer > maxtTimer)
			{
				startedcombo = false;
				Debug.Log ("failed input");
				Timer = 0;
			}
		}
	}

	void HandleKonamiController()
	{ 
		if (DoOnce == false) 
		{

			if (Input.GetAxisRaw ("Vertical") > .5f) 
			{
				startedcombo = true;
				Timer = 0;
				up1 = true;
				Debug.Log ("up1");
			}

			if (Input.GetAxisRaw ("Vertical") > .5f && Timer < maxtTimer && comboTimer > .1f && up1 == true)
			{
				Timer = 0;
				Debug.Log ("up2");
				up2 = true;
			} 
			else if (Timer > maxtTimer) 
			{
				startedcombo = false;
				Debug.Log ("failed input");
				Timer = 0;
			}


			if (Input.GetAxisRaw ("Vertical") <0 && Timer < maxtTimer && comboTimer > .1f && up2 == true) 
			{
				Timer = 0;
				Debug.Log ("down1");
				down1 = true;
			}
			else if (Timer > maxtTimer)
			{
				startedcombo = false;
				Debug.Log ("failed input");
				Timer = 0;
			}

			if (Input.GetAxisRaw ("Vertical") <0 && Timer < maxtTimer && comboTimer > .1f && down1 == true)
			{
				down2 = true;
				Timer = 0;
				Debug.Log ("down2");
			} 
			else if (Timer > maxtTimer) 
			{
				startedcombo = false;
				Debug.Log ("failed input");
				Timer = 0;
			}

			if (Input.GetAxisRaw ("Horizontal") <0 && Timer < maxtTimer && comboTimer > .1f && down2 == true)
			{
				left1 = true;
				Timer = 0;
				Debug.Log ("left1");
			} 
			else if (Timer > maxtTimer)
			{
				startedcombo = false;
				Debug.Log ("failed input");
				Timer = 0;
			}

			if (Input.GetAxisRaw ("Horizontal") > 0.5f && Timer < maxtTimer && comboTimer > .1f && left1 == true)
			{
				right1 = true;
				Timer = 0;
				Debug.Log ("right1");
			} 
			else if (Timer > maxtTimer) 
			{
				startedcombo = false;
				Debug.Log ("failed input");
				Timer = 0;
			}

			if (Input.GetAxisRaw ("Horizontal") <0 && Timer < maxtTimer && comboTimer > .1f && right1 == true)
			{
				left2 = true;
				Timer = 0;
				Debug.Log ("left2");
			} 
			else if (Timer > maxtTimer)
			{
				startedcombo = false;
				Debug.Log ("failed input");
				Timer = 0;
			}

			if (Input.GetAxisRaw ("Horizontal") > 0.5f && Timer < maxtTimer && comboTimer > .1f && left2 == true)
			{
				right2 = true;
				Timer = 0;
				Debug.Log ("right2");
			} 
			else if (Timer > maxtTimer)
			{
				startedcombo = false;
				Debug.Log ("failed input");
				Timer = 0;
			}

			if (Input.GetButtonDown("360_BButton") && Timer < maxtTimer && comboTimer > .1f && right2 == true)
			{
				B = true;
				Timer = 0;
				Debug.Log ("B");
			} 
			else if (Timer > maxtTimer)
			{
				startedcombo = false;
				Debug.Log ("failed input");
				Timer = 0;
			}

			if (Input.GetButtonDown("360_AButton") && Timer < maxtTimer && comboTimer > .1f && B == true)
			{
				A = true;
				Timer = 0;
				Debug.Log ("A");
			} 
			else if (Timer > maxtTimer)
			{
				startedcombo = false;
				Debug.Log ("failed input");
				Timer = 0;
			}

			if (Input.GetButtonDown("360_BackButton") && Timer < maxtTimer && comboTimer > .1f && A == true)
			{
				Select = true;
				Timer = 0;
				Debug.Log ("select");
			} 
			else if (Timer > maxtTimer)
			{
				startedcombo = false;
				Debug.Log ("failed input");
				Timer = 0;
			}

			if (Input.GetButtonDown("360_StartButton") && Timer < maxtTimer && comboTimer > .1f && Select == true) 
			{
				Start1 = true;
				Timer = 0;
				Debug.Log ("Start");
			} 
			else if (Timer > maxtTimer)
			{
				startedcombo = false;
				Debug.Log ("failed input");
				Timer = 0;
			}
		}
	}

	void GiveLives ()
	{
		

		if (Start1 == true) 
		{
			//SceneManager.LoadScene (Pitbull);
		}
		else if (Input.GetButtonDown ("360_StartButton") || Input.GetKeyDown(KeyCode.Return))
		{

			GetComponent<AudioSource> ().PlayOneShot (buttonpressed);
			Invoke ("CheckforPitbull", .1f);
		}
	}

	void CheckforPitbull()
	{
		if (!Start1)
			SceneManager.LoadScene ("Title");
	}
}

