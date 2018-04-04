using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_ThresholdActivate : MonoBehaviour {

	[SerializeField]
	GameObject[] objToTurnON;

	[SerializeField]
	GameObject[] objToTurnOff;

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player") 
		{
			if (objToTurnON != null)
			{
				foreach (GameObject obj in objToTurnON)
					obj.SetActive (true);
			}

			if (objToTurnOff != null)
			{
				foreach (GameObject objF in objToTurnOff)
					objF.SetActive (false);
			}
		}
	}

}
