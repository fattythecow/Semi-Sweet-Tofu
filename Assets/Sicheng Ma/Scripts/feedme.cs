using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feedme : MonoBehaviour {

	public int feedtime = 0;

	public int maxfeedtime = 3;

	public GameObject text1;

	public GameObject text2;

	public GameObject text3;

	public bool isGreen;

	public bool isYellow;

	public bool isRed;

	public bool isPurple;

	public GameObject neededfruit;

	public Material fruitr;
	public Material fruitg;
	public Material fruity;
	public Material fruitp;

	public float fedtimer = 0;
	public GameObject timess;
	public TextMesh TimerTextMesh;
	private string timerText;

	public bool isfed = false;

	public byte alplha = 255;

	// Use this for initialization
	void Start () {
		text1.SetActive (true);
		text2.SetActive (false);
		text3.SetActive (false);
		timerText = TimerTextMesh.text;
	}
	
	// Update is called once per frame
	void Update () {
		gottenfed ();
		UpdateTime ("   " + fedtimer.ToString("0"));

		if (feedtime != 0) {
			timess.SetActive (true);
		} else {
			timess.SetActive (false);
		}

		if (fedtimer <= 0 && feedtime != 0) {

			goback ();
		}

		if (!isfed) {
			fedtimer -= Time.deltaTime;
		}

		if (maxfeedtime == 3) {
			if (feedtime == 1) {
				text1.SetActive (false);
				text2.SetActive (true);
				text3.SetActive (false);
			} else if (feedtime == 2) {
				text1.SetActive (false);
				text2.SetActive (false);
				text3.SetActive (true);
			} else if (feedtime == maxfeedtime) {
				isfed = true;
			}
		} else if (maxfeedtime == 2) {
			if (feedtime == 1) {
				text1.SetActive (false);
				text2.SetActive (false);
				text3.SetActive (true);
			} else if (feedtime == maxfeedtime) {
				//Destroy (gameObject);
				isfed = true;
			}
		} else if (maxfeedtime == 1) {
			if (feedtime == maxfeedtime) {
				isfed = true;
				//Destroy (gameObject);
			}
		}

		changefruitmaterial ();
	}

	public void UpdateTime(string value){
		TimerTextMesh.text = timerText;
		TimerTextMesh.text += value;
	}

	void gottenfed()
	{
		

		if (isfed)
		{
			alplha--;
			alplha--;
			alplha--;
			GetComponent<MeshRenderer> ().material.color = new Color32 (255, 255, 255, alplha);
		}

		if (alplha <= 15)
		{
			alplha = 0;
			Destroy (gameObject, 0);
		}
	}


	public void changefruitmaterial(){
		if (isPurple) {
			neededfruit.GetComponent<MeshRenderer> ().material = fruitp;
		} 
		else if (isRed) {
			neededfruit.GetComponent<MeshRenderer> ().material = fruitr;
		} 
		else if (isYellow) {
			neededfruit.GetComponent<MeshRenderer> ().material = fruity;
		} 
		else if (isGreen) {
			neededfruit.GetComponent<MeshRenderer> ().material = fruitg;
		}
	}

	void goback(){

		fedtimer = 12;
		if (text3.activeInHierarchy) {
			feedtime = 0;
			text1.SetActive (true);
			text2.SetActive (false);
			text3.SetActive (false);
		}

	}

	void OnTriggerEnter(Collider other){
		if (isGreen) {
			if (other.tag == "Apple") {
				feedtime++;
				fedtimer = 12;
			}
			Destroy (other.gameObject);

		} 
		if (isYellow) {
			if (other.tag == "Banana") {
				feedtime++;
				fedtimer = 12;
			} 
			Destroy (other.gameObject);
		}
		if (isRed) {
			if (other.tag == "Strawberry") {
				feedtime++;
				fedtimer = 12;
			} 
			Destroy (other.gameObject);
		}
		if (isPurple) {
			if (other.tag == "Grape") {
				feedtime++;
				fedtimer = 12;
			}
			Destroy (other.gameObject);
		}
	}
}
