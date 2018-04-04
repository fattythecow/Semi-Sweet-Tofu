using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GH_Cirque : MonoBehaviour {

	public GameObject orbitedObj;
	public float speed;




	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		OrbitAround ();
	

	}


	void OrbitAround()
	{
		transform.RotateAround (orbitedObj.transform.position, Vector3.forward, speed * Time.deltaTime);
	}
}
