using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterProjectile : MonoBehaviour {

	public float BulletMoveSpeed = 5f;

	private CJC_PlayerAndBools player;


	void Start(){
		GameObject p1 = GameObject.FindWithTag ("Player");

		player = p1.GetComponent<CJC_PlayerAndBools>();
	}

	void Update(){
		transform.position += transform.forward * Time.deltaTime * BulletMoveSpeed;

	}

	void OnBecameInvisible()
	{
		Destroy(gameObject);
	}

	void StartDestroy(float timeDelay)
	{

		//turn off drawing and colliding
		GetComponent<Renderer>().enabled = false;
		GetComponent<Collider>().enabled = false;

		//start the destroy countdown
		Destroy(gameObject, timeDelay);
	}

	void OnTriggerEnter(Collider other)
	{
		GameObject sou = GameObject.FindWithTag ("Player");
		CJC_SoundHolder sound = sou.GetComponent<CJC_SoundHolder> ();

		if(other.tag == "Player")
		{
			StartDestroy(0.3f);
			sound.GetComponent<AudioSource> ().PlayOneShot (sound.DamageFromEnemySound);
			player.PlayerHealth -= 20;
		}

		if (other.tag == "Wall") {
			Destroy (gameObject);
		}
	}
}
