using UnityEngine;
using System.Collections;

public class CJC_ParenterVolume : MonoBehaviour
{
	void Start ()
	{
		
	}

	void Update()
	{
		
	}

	void OnTriggerStay (Collider other)
	{
		//did player step into volume
		if (other.tag == "Player") 
		{
			other.transform.parent = transform;
		}
		else if (other.tag == "Apple" | other.tag == "Banana" | other.tag == "Grape" | other.tag == "Strawberry" | other.tag == "Durian")
		{
			other.transform.parent = transform;
		}

	}

	void OnTriggerExit(Collider other)
	{
		//did player step out of volume
		if (other.tag == "Player") {
			//if so player has no parent
			other.transform.parent = null;
		} 
		//else if (other.tag == "Apple" | other.tag == "Banana" | other.tag == "Grape" | other.tag == "Strawberry" | other.tag == "Durian")
		//{
		//	other.transform.parent = null;
		//}
	}


}
