using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestShake : MonoBehaviour {

	public float positiveShakeValue = 0.0025f;
	public float negativeShakeValue = -0.0025f;

	public Transform shakingObject;




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		var xAxisShake = Random.Range (positiveShakeValue, negativeShakeValue);
		var yAxisShake = Random.Range (positiveShakeValue, negativeShakeValue);
		var zAxisShake = Random.Range (positiveShakeValue, negativeShakeValue);

		shakingObject.transform.position += new Vector3 (xAxisShake, yAxisShake, zAxisShake);

	}
}
