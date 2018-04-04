using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_HungerPFI : MonoBehaviour {

	public float sizecurrent = 1;

	[SerializeField]
	float sizemax = 1.15f;
	[SerializeField]
	float sizemin = .75f;
	bool big = false;

	[SerializeField]
	GameObject starvingSound;
	[SerializeField]
	AudioClip hungry;

	bool hungerset;
	float soundtimer =0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		changesize ();
		ChangeColor ();
		managehunger ();
		managemakinghungrysoundhappen ();
	}

	void managehunger()
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_Starvation Starve = p1.GetComponent<CJC_Starvation> ();

		if (Starve.HungerTimer > 30)
		{
			hungerset = false;
			starvingSound.SetActive (false);
		}
		else if (Starve.HungerTimer <= 30 && Starve.HungerTimer > 0)
		{
			hungerset = true;
			starvingSound.SetActive (false);
		} 
		else if (Starve.HungerTimer <= 0)
		{
			hungerset = false;
			starvingSound.SetActive (true);
		}
	}

	void managemakinghungrysoundhappen()
	{
		if (hungerset)
		{
			soundtimer += Time.deltaTime;
			if (soundtimer >= 5)
			{
				Invoke ("callhungrysound", 5);
				soundtimer = 0;
			}
		}
	}

	void callhungrysound()
	{
		GetComponent<AudioSource> ().PlayOneShot (hungry);
	}

	void ChangeColor ()
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_Starvation Starve = p1.GetComponent<CJC_Starvation> ();

		if (Starve.HungerTimer >= 31) 
		{
			gameObject.GetComponent<TextMesh> ().color = Color.green;
		}
		else if (Starve.HungerTimer <= 30 && Starve.HungerTimer > 10) 
		{
			gameObject.GetComponent<TextMesh> ().color = Color.yellow;
		}
		else if (Starve.HungerTimer < 10) 
		{
			gameObject.GetComponent<TextMesh> ().color = Color.red;
		}

	}

	void changesize()
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_Starvation Starve = p1.GetComponent<CJC_Starvation> ();

		if (Starve.HungerTimer >= 1) 
		{
			gameObject.transform.localScale = new Vector3 (1, 1, 1);
		}
		else if (Starve.HungerTimer <= 0) 
		{
			gameObject.transform.localScale = new Vector3 (sizecurrent, sizecurrent, sizecurrent);

			if (big == true)
				sizecurrent -= Time.deltaTime /3;
			else if 
				(big == false)
				sizecurrent += Time.deltaTime / 3;

			if (sizecurrent >= sizemax && big == false) {
				sizecurrent = sizemax;
				big = true;
			} else if (sizecurrent <= sizemin && big == true) 
			{
				sizecurrent = sizemin;
				big = false;
			}
		}

	}
}
