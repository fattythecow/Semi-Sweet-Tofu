using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_FruitRename : MonoBehaviour {

	[SerializeField]
	bool IsApple = false;
	[SerializeField]
	bool IsStrawberry = false;
	[SerializeField]
	bool IsGrape = false;
	[SerializeField]
	bool IsBanana = false;
	[SerializeField]
	bool IsDurian = false;
	[SerializeField]
	bool IsGrapeFruit = false;

	// Use this for initialization
	void Start ()
	{
		if (IsApple) 
		{
			gameObject.name = "Apple";
		}
		else if (IsGrape) 
		{
			gameObject.name = "Grape";
		}
		else if (IsGrapeFruit) 
		{
			gameObject.name = "Grapefruit";
		}
		else if (IsBanana) 
		{
			gameObject.name = "Banana";
		}
		else if (IsStrawberry) 
		{
			gameObject.name = "StrawBerry";
		}
		else if (IsDurian) 
		{
			gameObject.name = "Durian";
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
