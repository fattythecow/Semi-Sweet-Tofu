using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showingstarsbeginning : MonoBehaviour {
	
	public GameObject showtimerstar;

	bool doneintro = false;

	public float starblink = 0;
	float maxblink = .75f;

	bool blinkon = true;

	[SerializeField]
	int blinkcounts = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (countingtime.startcounting && !doneintro)
		{
			Flicker ();
			starblink += Time.deltaTime;


			if (blinkon)
			{
				showtimerstar.SetActive (true);
			}
			else if (!blinkon)
			{
				showtimerstar.SetActive (false);
				if (blinkcounts >= 2)
				{
					showtimerstar.SetActive (false);
					doneintro = true;
				}
			}
		}

	}

	void Flicker ()
	{
		if (starblink >= maxblink && !blinkon)
		{
			starblink = 0;
			blinkon = true;
			blinkcounts++;
		}
		else if (starblink >= maxblink && blinkon)
		{
			starblink = 0;
			blinkon = false;
		}
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			showtimerstar.SetActive (true);

		}
	}
}
