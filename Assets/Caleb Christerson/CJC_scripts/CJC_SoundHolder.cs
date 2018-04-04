using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_SoundHolder : MonoBehaviour {

	public AudioSource soundSource = null;

	public AudioClip footstepSound = null;
	public AudioClip jumpsound = null;
	public AudioClip DropSound = null;
	public AudioClip EatSound = null;
	public AudioClip SwimmingSound = null;
	public AudioClip shootingSound = null;
	public AudioClip DyingSound = null;
	public AudioClip DamageFromEnemySound = null;
	public AudioClip DamageFromSawOrFireSound = null;
	public AudioClip damageFromFire = null;
	public AudioClip LifeGainedSound = null;
	public AudioClip ladderclimbsound = null;
	public AudioClip Coinsound = null;
	public AudioClip stunsound = null;
	public AudioClip SprintStep = null;
	public AudioClip burndeath = null;
	public AudioClip decolorsound = null;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayBurnDeathSound()
	{
		GetComponent<AudioSource> ().PlayOneShot (burndeath);
	}

	public void PlaySprintSound()
	{
		GetComponent<AudioSource> ().PlayOneShot (SprintStep);
	}

	public void PlaySwimSound()
	{
		GetComponent<AudioSource> ().PlayOneShot (SwimmingSound);
	}

	public void PlayladderSound()
	{
		GetComponent<AudioSource> ().PlayOneShot (ladderclimbsound);
	}

	public void PlayDeathSound()
	{
		//GetComponent<AudioSource> ().PlayOneShot (DyingSound);
	}


	public void PlayStepSound()
	{
		GetComponent<AudioSource> ().PlayOneShot (footstepSound);
	}
}
