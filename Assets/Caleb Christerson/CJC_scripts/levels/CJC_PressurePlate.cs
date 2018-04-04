using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_PressurePlate : MonoBehaviour 
{
	public TextMesh FruitTextmesh;
	private string FruitText;

	 byte purpletone = 255;

	[SerializeField]
	bool IsGreen = false;
	[SerializeField]
	bool IsRed = false;
	[SerializeField]
	bool IsYellow = false;
	[SerializeField]
	bool IsPurple = false;

	public float waitTime= 0.0f;

	public float maxwaitTime = 2.0f;

	public bool alreadydropped;
	[SerializeField]
	GameObject bowcolor = null;
	[SerializeField]
	GameObject fruitToColor;
	[SerializeField]
	Material Lychee;
	[SerializeField]
	Material Persimmon;
	[SerializeField]
	Material Melon;
	[SerializeField]
	Material Taro;
	//[SerializeField]
	//GameObject wallToColor = null;
	//[SerializeField]
	//GameObject wall2 = null;
	//[SerializeField]
	//GameObject wall3 = null;

	[SerializeField]
	GameObject WallBarrier = null;

	[SerializeField]
	int FruitNeeded;


	public int CurFruitNumber;

	[SerializeField]
	string FruitNeededTag = null;
	[SerializeField]
	string FruitNewTag = null;


	bool doOnce = false;
	public GameObject Player;

	// Use this for initialization
	void Start ()
	{
		
		FruitText = FruitTextmesh.text;

		bool alreadyDropped = false;
	}

	// Update is called once per frame
	void Update ()
	{
		CheckForNumberOfFruit ();
		manageColors ();
		Player = GameObject.FindWithTag ("Player");

	}

	public void Updatefruit (string value)
	{
		FruitTextmesh.text = FruitText;
		FruitTextmesh.text += value;
	}

	void CheckForNumberOfFruit()
	{
		if (CurFruitNumber < FruitNeeded)
		{
			if (IsYellow | IsGreen | IsRed | IsPurple)
			{
				Updatefruit ("           " + CurFruitNumber + "/" + FruitNeeded);
			}
			else if (IsYellow == false && IsGreen == false && IsRed == false && IsPurple == false)
			{
				Updatefruit ("");
			}
			WallBarrier.SetActive (true);
		} 
		else if (CurFruitNumber >= FruitNeeded)
		{
			WallBarrier.SetActive (false);
			Updatefruit ("");
		}
	}

	void manageColors()
	{
		if (IsYellow == false && IsGreen == false && IsRed == false && IsPurple == false) 
		{
			fruitToColor.GetComponent<MeshRenderer> ().material = null;
			bowcolor.GetComponent<SpriteRenderer> ().material.color = Color.white;
			//wallToColor.GetComponent<MeshRenderer> ().material.color = Color.white;
			//wall2.GetComponent<MeshRenderer> ().material.color = Color.white;
			//wall3.GetComponent<MeshRenderer> ().material.color = Color.white;
			FruitNeededTag = "";
		}
		else if (IsGreen == true) 
		{
			fruitToColor.GetComponent<MeshRenderer> ().material = Melon;
			bowcolor.GetComponent<SpriteRenderer> ().material.color =  new Color32 (117,255,199, 255);
			//wallToColor.GetComponent<MeshRenderer> ().material.color = new Color32 (117,255,199, 255);
			//wall2.GetComponent<MeshRenderer> ().material.color = new Color32 (117,255,199, 255);
			//wall3.GetComponent<MeshRenderer> ().material.color = new Color32 (117,255,199, 255);
			FruitNeededTag = "Apple";
			FruitNewTag = "Melon";
			IsRed = false;
			IsYellow = false;
			IsPurple = false;
		}
		else if (IsRed == true) 
		{
			fruitToColor.GetComponent<MeshRenderer> ().material = Lychee;
			bowcolor.GetComponent<SpriteRenderer> ().material.color =  new Color32 (232,50,50, 255);
			//wallToColor.GetComponent<MeshRenderer> ().material.color = new Color32 (232,50,50, 255);
			//wall2.GetComponent<MeshRenderer> ().material.color = new Color32 (232,50,50, 255);
			//wall3.GetComponent<MeshRenderer> ().material.color = new Color32 (232,50,50, 255);
			FruitNeededTag = "Strawberry";
			FruitNewTag = "Lychee";
			IsGreen = false;
			IsYellow = false;
			IsPurple = false;
		}
		else if (IsYellow == true) 
		{
			fruitToColor.GetComponent<MeshRenderer> ().material = Persimmon;
			bowcolor.GetComponent<SpriteRenderer> ().material.color =  new Color32 (255,140,20,255);
			//wallToColor.GetComponent<MeshRenderer> ().material.color = new Color32 (255,140,20,255);
			//wall2.GetComponent<MeshRenderer> ().material.color = new Color32 (255,140,20,255);
			//wall3.GetComponent<MeshRenderer> ().material.color = new Color32 (255,140,20,255);
			FruitNeededTag = "Banana";
			FruitNewTag = "Persimmon";
			IsRed = false;
			IsGreen = false;
			IsPurple = false;
		}
		else if (IsPurple == true) 
		{
			fruitToColor.GetComponent<MeshRenderer> ().material = Taro;
			bowcolor.GetComponent<SpriteRenderer> ().material.color =  new Color32 (233,187,255, 255);
			//wallToColor.GetComponent<MeshRenderer> ().material.color = new Color32 (233,187,255, 255);
			//wall2.GetComponent<MeshRenderer> ().material.color = new Color32 (233,187,255, 255);
			//wall3.GetComponent<MeshRenderer> ().material.color = new Color32 (233,187,255, 255);
			FruitNeededTag = "Grape";
			FruitNewTag = "Taro";
			IsRed = false;
			IsYellow = false;
			IsGreen = false;
		}
	}

	void OnTriggerEnter(Collider other)
	{
		BoxCollider[] myColliders = other.GetComponents<BoxCollider>();

		if (other.tag == FruitNeededTag && alreadydropped == false) {
			other.transform.parent = transform;
			other.GetComponent<Rigidbody> ().isKinematic = true;
			other.GetComponent<BoxCollider> ().enabled = false;
			foreach(BoxCollider bc in myColliders) bc.enabled = false;
			other.name = FruitNeededTag;
			CurFruitNumber++;
			 
			Debug.Log ("Hit");

			alreadydropped = true;
			StartCoroutine (myCoroutine ());



		}

		}


	IEnumerator myCoroutine ()
	{
		yield return new WaitForSeconds (0.5f);
		alreadydropped = false;


	//void timerCount (){

		//waitTime -= Time.deltaTime;









		
}
}





