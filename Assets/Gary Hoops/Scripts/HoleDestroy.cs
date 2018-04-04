using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleDestroy : MonoBehaviour {

	[SerializeField]
	bool Botfloor = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools death = p1.GetComponent<CJC_PlayerAndBools> ();

		if (Botfloor && !death.PlayerDied) 
		{
			if (GameObject.FindWithTag ("Player").transform.position.y < gameObject.transform.position.y) 
			{
				death.PlayerHealth = 0;
			}
		}
		else if (!Botfloor && !death.PlayerDied) 
		{
			if (GameObject.FindWithTag ("Player").transform.position.y > gameObject.transform.position.y) 
			{
				death.PlayerHealth = 0;
			}
		}
	}

	void OnTriggerEnter (Collider other)
	{GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools death = p1.GetComponent<CJC_PlayerAndBools> ();
		if (other.tag == "Player" && !death.PlayerDied) {
			

			death.PlayerHealth = 0;
		}

		if (other.tag == "Monster") {
			Destroy (other.gameObject);
		}
	}

}
