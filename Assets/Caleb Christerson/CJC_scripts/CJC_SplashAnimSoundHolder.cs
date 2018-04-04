using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_SplashAnimSoundHolder : MonoBehaviour {

	[SerializeField]
	AudioClip stepsound;
	[SerializeField]
	AudioClip jumpsound;
	[SerializeField]
	AudioClip decolorsound;
	[SerializeField]
	AudioClip squishsound;
	[SerializeField]
	AudioClip swingsound;
	[SerializeField]
	AudioClip thudsound;
	[SerializeField]
	AudioClip wooshsound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void playsquishsound()
	{
		GetComponent<AudioSource> ().PlayOneShot (squishsound);
	}public void playjumpsound()
	{
		GetComponent<AudioSource> ().PlayOneShot (jumpsound);
	}public void playstepsound()
	{
		GetComponent<AudioSource> ().PlayOneShot (stepsound);
	}public void playdecolorsound()
	{
		GetComponent<AudioSource> ().PlayOneShot (decolorsound);
	}
	public void playswingsound()
	{
		GetComponent<AudioSource> ().PlayOneShot (swingsound);
	}
	public void playthudsound()
	{
		GetComponent<AudioSource> ().PlayOneShot (thudsound);
	}
	public void playwooshsound()
	{
		GetComponent<AudioSource> ().PlayOneShot (wooshsound);
	}
}
