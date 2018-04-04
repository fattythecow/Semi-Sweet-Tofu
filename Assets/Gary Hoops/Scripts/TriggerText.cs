using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class TriggerText : MonoBehaviour {

	public GameObject greenText;

	public float timer = 0;

	[SerializeField]
	float maxtimer = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (greenText.gameObject.activeInHierarchy){
			timer += Time.deltaTime;
			if (timer >= maxtimer) {
				greenText.SetActive (false);
				timer = 0;
			}
		}
	}


	void OnTriggerEnter(Collider other) {

		if (other.gameObject.tag == "Player") {
			greenText.SetActive (true);
		}
	}
}
