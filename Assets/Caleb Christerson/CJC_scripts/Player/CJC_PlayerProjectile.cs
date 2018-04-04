using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_PlayerProjectile : MonoBehaviour {

	[SerializeField]
	float destroytime;
	[SerializeField]
	float projectileSpeed;
	//[SerializeField]
	//float Damage = 100;

	[SerializeField]
	float turnOnCol = 0;

	[SerializeField]
	bool shootleft = false;
	[SerializeField]
	bool shootright = false;

	// Use this for initialization
	void Start () 
	{
		GameObject no = GameObject.Find ("nose");
		CJC_ShowDirection nose = no.GetComponent<CJC_ShowDirection> ();
		if (nose.facingleft == true)
		{
			shootleft = true;
			shootright = false;
		} 
		else if (nose.facingright == true)
		{
			shootright = true;
			shootleft = false;
		} 
		else if (nose.facingright == false && nose.facingleft == false)
		{
			shootright = true;
			shootleft = false;
		}

	}
	
	// Update is called once per frame
	void Update () 
	{
		turnOnCol += Time.deltaTime;
		if (turnOnCol >= .025f) 
		{
			GetComponent<SphereCollider> ().enabled = true;
		}

		HandleMovement ();
		HandleSelfKill ();
	}

	void HandleMovement()
	{
		if (shootright == true)
		{
			transform.position += transform.right * Time.deltaTime * projectileSpeed;
		} 
		else if (shootleft == true) 
		{
			transform.position -= transform.right * Time.deltaTime * projectileSpeed;
		}
	}

	void HandleSelfKill()
	{

		Destroy (gameObject, destroytime);
	}

	void OnTriggerEnter(Collider other)
	{
		GameObject sou = GameObject.FindWithTag ("Player");
		CJC_SoundHolder sound = sou.GetComponent<CJC_SoundHolder> ();

		if (other.tag == "Monster" | other.tag == "Wall" | other.tag == "Floor")
		{
			if (other.tag == "Monster")
			{
				sound.GetComponent<AudioSource> ().PlayOneShot (sound.stunsound);
			}
			GetComponent<MeshRenderer> ().enabled = false;
			GetComponent<SphereCollider> ().enabled = false;
			Destroy (gameObject);
		}
	}
}
