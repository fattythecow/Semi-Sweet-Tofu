using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monstertext2 : MonoBehaviour {

	public GameObject greenText;

	public float timer = 0;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (greenText.gameObject.activeInHierarchy)
		{
			timer += Time.deltaTime;
			if (timer >= 1.5)
			{
				greenText.SetActive(false);
				timer = 0;
			}
		}
	}


	void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.tag == "Player")
		{
			greenText.SetActive(true);
		}
	}
}
