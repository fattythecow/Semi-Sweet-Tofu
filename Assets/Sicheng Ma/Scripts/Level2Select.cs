using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Select : MonoBehaviour {
	
	public string level;

	public GameObject leveltext;

	public GameObject scroll;

	public float timer = 0f;
	// Use this for initialization
	void Start () {
		leveltext.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (leveltext.activeInHierarchy) {
			if (timer >= 4.0f) {
				leveltext.SetActive (false);
				timer = 0;
			}
		}
	}

	public void OnClick(){
		if (scroll.activeInHierarchy) {
			SceneManager.LoadScene (level);
		} else {
			timer = 0;
			leveltext.SetActive (true);
		}
	}
}
