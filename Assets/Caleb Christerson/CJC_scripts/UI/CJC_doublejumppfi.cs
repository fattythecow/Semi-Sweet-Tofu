using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_doublejumppfi : MonoBehaviour {

	[SerializeField]
	float timer;
	[SerializeField]
	float maxtimer = .75f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (gameObject.activeInHierarchy)
		{
			timer += Time.deltaTime;

			if (timer >= maxtimer) 
			{
				timer = 0;
				gameObject.SetActive (false);
			}
		}
	}
}
