using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_decolorProjectile : MonoBehaviour {

	[SerializeField]
	AudioClip decolorsound;
	[SerializeField]
	AudioSource decolorsource;

	public float BulletMoveSpeed = 5f;
	[SerializeField]
	float bulletdamage;

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
		GetComponent<BoxCollider>().enabled = false;

		//start the destroy countdown
		Destroy(gameObject, timeDelay);
	}

	void OnTriggerEnter(Collider other)
	{
		GameObject sou = GameObject.FindWithTag ("Player");
		CJC_SoundHolder sound = sou.GetComponent<CJC_SoundHolder> ();

		if(other.tag == "Player")
		{
			if (player.IsGreen == true | player.IsRed == true | player.IsYellow == true | player.IsPurple == true)
			{
				sound.GetComponent<AudioSource> ().PlayOneShot (decolorsound);
				Debug.Log ("decolorizing");
				player.IsGreen = false;
				player.IsPurple = false;
				player.IsRed = false;
				player.IsYellow = false;
				Debug.Log ("decolorized the player");
			}
			else if (player.IsGreen == false && player.IsRed == false && player.IsYellow == false && player.IsPurple == false)
			{
				sound.GetComponent<AudioSource> ().PlayOneShot (sound.DamageFromEnemySound);
				player.PlayerHealth -= bulletdamage;
			}

			StartDestroy(.1f);
		}
	}
}
