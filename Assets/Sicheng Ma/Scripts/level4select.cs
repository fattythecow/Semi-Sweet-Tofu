using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level4select : MonoBehaviour {

	public string level;

	public GameObject leveltext;

	public float timer = 0f;

	public GameObject scroll1;

	public GameObject scroll2;

	public GameObject scroll3;

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
		if (scroll1.activeInHierarchy && scroll2.activeInHierarchy && scroll3.activeInHierarchy) {
			SceneManager.LoadScene (level);
		} else {
			timer = 0;
			leveltext.SetActive (true);
		}
	}
}
