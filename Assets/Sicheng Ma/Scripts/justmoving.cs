using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class justmoving : MonoBehaviour {

	[SerializeField]
	float speed = 2;

	[SerializeField]
	float sinRangeX = 0;
	[SerializeField]
	float sinRangeY = 0;
	[SerializeField]
	float sinRangeZ = 0;
	[SerializeField]
	float rotatSpeed = 45;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		DoRotation ();
		DoCoolMovement ();
	}

	void DoRotation()
	{
		this.transform.Rotate (0, rotatSpeed * Time.deltaTime, 0, Space.World);
	}

	void DoCoolMovement()
	{
		transform.position = transform.position + new Vector3 (Mathf.Sin (Time.time *speed) * sinRangeX, Mathf.Sin (Time.time * speed) * sinRangeY, Mathf.Sin (Time.time * speed) * sinRangeZ);
	}
}
