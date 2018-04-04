using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundfollowing : MonoBehaviour {

	public GameObject target;

	[SerializeField]
	float Y;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		target = GameObject.FindWithTag ("Player");
		gameObject.transform.position = new Vector3(target.transform.position.x + 2, target.transform.position.y + Y, transform.position.z);
	}
}
