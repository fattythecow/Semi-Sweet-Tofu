using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_Shootwall : MonoBehaviour {

	[SerializeField]
	GameObject shoothere;

	public GameObject Target;

	public Material shot;
	
	[SerializeField]
	GameObject[ ]objectsToTurnOPn;

	[SerializeField]
	int hitsleft = 5;

	bool isCompleted = false;
	bool isshot = false;
	[SerializeField]
	float isshottimer = 0;
	[SerializeField]
	float shotmaxtimer = .5f;

	[SerializeField]
	GameObject wall;

	[SerializeField]
	GameObject shotobj;

	[SerializeField]
	GameObject frame;

	public TextMesh ScoreTextMesh;
	private string scoreText;

	// Use this for initialization
	void Start () {
		scoreText = ScoreTextMesh.text;
	}
	
	// Update is called once per frame
	void Update ()
	{
		UpdateScore (hitsleft);
		ManageHits ();
		ManageCompletion ();
		if (wall.activeInHierarchy) {
			frame.SetActive (true);
		} else {
			frame.SetActive (false);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "PlayerProjectile") 
		{
			shotobj.transform.position = other.transform.position;
			isshot = true;
			hitsleft--;

		}
	}

	public void UpdateScore (int value)
	{
		ScoreTextMesh.text = scoreText;
		ScoreTextMesh.text += value;

	}


	void ManageHits()
	{
		if (isshot) {
			Target.GetComponent<MeshRenderer> ().material = shot;
			shotobj.GetComponent<MeshRenderer> ().enabled = true;
			shoothere.GetComponent<Renderer> ().material = shot;
			isshottimer += Time.deltaTime;
			if (isshottimer >= shotmaxtimer) {
				isshot = false;
			}
		} 
		else if (!isshot)
		{
			shotobj.GetComponent<MeshRenderer> ().enabled = false;
			isshottimer =0;
		}

		if (hitsleft <= 0)
		{
			GetComponent<MeshRenderer> ().enabled = false;
			GetComponent<SphereCollider> ().enabled = false;
			//foreach (GameObject obj in objectsToTurnOPn)
			//{
			//	obj.GetComponent<MeshRenderer> ().material.color = new Color32 (255, 0, 0, 100);
			//}
			//Destroy (gameObject, .5f);
			GetComponent<SphereCollider>().enabled = false;
			GetComponent<MeshRenderer> ().enabled = false;
			Target.SetActive (false);
			isCompleted = true;
		}
	}

	void ManageCompletion()
	{
		if (isCompleted) {
			foreach (GameObject obj in objectsToTurnOPn)
			{
				obj.GetComponent<MeshRenderer> ().material.color = new Color32 (0, 255, 0, 0);
				//obj.GetComponent<MeshRenderer> ().material.color = Color.green;
			}
			//Destroy (gameObject, .5f);
			GetComponent<SphereCollider> ().enabled = false;
			//GetComponent<MeshRenderer> ().enabled = false;
			ScoreTextMesh.GetComponent<MeshRenderer> ().enabled = false;
			shoothere.GetComponent<MeshRenderer> ().enabled = false;

			if (wall.transform.localScale.y > 0)
			{
				wall.transform.localScale = new Vector3 (wall.transform.localScale.x, wall.transform.localScale.y - Time.deltaTime*30, wall.transform.localScale.z);
			}
			else if (wall.transform.localScale.y < 0)
			{
				wall.SetActive (false);
			}
		} 
		else if (!isCompleted)
		{
			foreach (GameObject obj in objectsToTurnOPn)
			{
				obj.GetComponent<MeshRenderer> ().material.color = new Color32 (255, 0, 0, 75);
			}

		}
			
	}
}
