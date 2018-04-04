using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibratingPlatform : MonoBehaviour {

	public float fallTime = 2;
	public float destroyTime = 2;
	private Rigidbody platform;
	// Use this for initialization
	void Start () {
		platform = GetComponent<Rigidbody> ();

	}

	IEnumerator plattyShake(float fallTime)
	{
		while (fallTime > 0) {
			platform.position = new Vector3 (platform.position.x + (Random.insideUnitCircle.x * 0.07f), platform.position.y);
			yield return new WaitForSeconds (0.0001f);
			fallTime -= Time.deltaTime;
		}

		platform.isKinematic = false;
	}

		void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == ("Player")) {
			StartCoroutine (plattyShake (fallTime));
			Destroy (gameObject, destroyTime);
		}
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}

