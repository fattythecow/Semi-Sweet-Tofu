using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinMe : MonoBehaviour {
	[SerializeField]
	float rotatSpeed = 45;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate (0, 0, -rotatSpeed * Time.deltaTime, Space.Self);
	}
}
