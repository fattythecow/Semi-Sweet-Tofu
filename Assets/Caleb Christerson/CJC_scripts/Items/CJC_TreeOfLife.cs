using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_TreeOfLife : MonoBehaviour {

	[SerializeField]
	float growthrate = 1.5f;
	[SerializeField]
	GameObject Spawnlocation = null;
	[SerializeField]
	GameObject FruitToSpawn = null;
	[SerializeField]
	GameObject NewFruit;

	[SerializeField]
	float spawnMultiplier;

	//[SerializeField]
	//float Spawntimer = 0;
	//[SerializeField]
	//float MaxSpawnTimer = 5;

	[SerializeField]
	bool hasBeenGrabbed = false;
	[SerializeField]
	bool hasbeenSpawned = false;
	[SerializeField]
	bool foundmynewfruit = false;

	[SerializeField]
	float FruitSizeX = 0;
	[SerializeField]
	float MaxFruitSizeX;
	[SerializeField]
	float FruitSizeY = 0;
	[SerializeField]
	float MaxFruitSizeY;

	// Use this for initialization
	void Start ()
	{
		MaxFruitSizeX = FruitToSpawn.transform.localScale.x;
		FruitToSpawn.GetComponent<BoxCollider> ().enabled = false;
		MaxFruitSizeY = FruitToSpawn.transform.localScale.y;
	}
	
	// Update is called once per frame
	void Update ()
	{
		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();
		if (shop.isopen == false)
		{

			FruitToSpawn.GetComponent<BoxCollider> ().enabled = false;
			FruitToSpawn.GetComponent<pitbullcalling> ().enabled = false;
			Spawner ();
			FruitToSpawn.GetComponent<BoxCollider> ().enabled = false;
			CheckIfSpawned ();
			FruitToSpawn.GetComponent<BoxCollider> ().enabled = false;
			CheckIfGrabbed ();
			FruitToSpawn.GetComponent<BoxCollider> ().enabled = false;
		}
	}

	void Spawner()
	{
		if (hasBeenGrabbed == true)
		{
			hasbeenSpawned = false;

			if (hasBeenGrabbed == true && hasbeenSpawned == false)
			{
				FruitToSpawn.GetComponent<BoxCollider> ().enabled = false;
				FruitToSpawn.transform.localScale = new Vector3 (FruitSizeX, FruitSizeY, .01f);
				FruitToSpawn.GetComponent<BoxCollider> ().enabled = false;
				//Spawntimer += Time.deltaTime;
				FruitToSpawn.GetComponent<BoxCollider> ().enabled = false;
				FruitSizeX += Time.deltaTime/spawnMultiplier*growthrate;
				FruitToSpawn.GetComponent<BoxCollider> ().enabled = false;
				FruitSizeY += Time.deltaTime/spawnMultiplier*growthrate;
				FruitToSpawn.GetComponent<BoxCollider> ().enabled = false;
				//Debug.Log ("growing a new fruit");

				/*if (Spawntimer >= MaxSpawnTimer)
				{
					NewFruit = FruitToSpawn;
					Instantiate (NewFruit, Spawnlocation.transform.position, Spawnlocation.transform.rotation);
					Debug.Log ("fruit has been spawned");
				}*/
				if (FruitSizeX >= MaxFruitSizeX && FruitSizeY >= MaxFruitSizeY)
				{
					FruitToSpawn.GetComponent<BoxCollider> ().enabled = false;
					FruitSizeX = MaxFruitSizeX;
					FruitToSpawn.GetComponent<BoxCollider> ().enabled = false;
					FruitSizeY = MaxFruitSizeY;
					FruitToSpawn.GetComponent<BoxCollider> ().enabled = false;
					NewFruit = FruitToSpawn;
					FruitToSpawn.GetComponent<BoxCollider> ().enabled = false;
					Instantiate (NewFruit, Spawnlocation.transform.position, Spawnlocation.transform.rotation);
					FruitToSpawn.GetComponent<BoxCollider> ().enabled = false;
					//Debug.Log ("fruit has been spawned");
				}
			}
		}
	}

	void CheckIfSpawned()
	{
		if (hasbeenSpawned == true && foundmynewfruit == false) 
		{
			FruitToSpawn.GetComponent<BoxCollider> ().enabled = false;
			FruitToSpawn.GetComponent<MeshRenderer> ().enabled = false;
			FruitSizeX = 0;
			FruitToSpawn.GetComponent<BoxCollider> ().enabled = false;
			FruitSizeY = 0;
			FruitToSpawn.GetComponent<BoxCollider> ().enabled = false;
			NewFruit = GameObject.Find (FruitToSpawn.name + "(Clone)");
			FruitToSpawn.GetComponent<BoxCollider> ().enabled = false;
			foundmynewfruit = true;
			FruitToSpawn.GetComponent<BoxCollider> ().enabled = false;
		}

	
	}

	void CheckIfGrabbed()
	{	
		if (NewFruit != null) 
		{
			FruitToSpawn.GetComponent<BoxCollider> ().enabled = false;
			hasbeenSpawned = true;
			hasBeenGrabbed = false;
			FruitToSpawn.GetComponent<BoxCollider> ().enabled = false;
			FruitToSpawn.GetComponent<MeshRenderer> ().enabled = false;
			NewFruit.GetComponent<MeshRenderer> ().enabled = true;
			//NewFruit.GetComponent<BoxCollider> ().enabled = true;
			FruitToSpawn.GetComponent<BoxCollider> ().enabled = false;
			NewFruit.transform.parent = FruitToSpawn.transform.parent;
			FruitToSpawn.GetComponent<BoxCollider> ().enabled = false;
			NewFruit.transform.localScale = FruitToSpawn.transform.localScale;
			FruitToSpawn.GetComponent<BoxCollider> ().enabled = false;
			NewFruit.GetComponent<BoxCollider> ().enabled = true;
			FruitToSpawn.GetComponent<BoxCollider> ().enabled = false;
			NewFruit.name = FruitToSpawn.name;
		}
		else if (NewFruit == null) 
		{
			FruitToSpawn.GetComponent<BoxCollider> ().enabled = false;
			FruitToSpawn.GetComponent<MeshRenderer> ().enabled = true;
			//Debug.Log ("fruit has been grabbed");
			foundmynewfruit = false;
			hasBeenGrabbed = true;
			hasbeenSpawned = false;
			FruitToSpawn.GetComponent<BoxCollider> ().enabled = false;
		}
	}
}
