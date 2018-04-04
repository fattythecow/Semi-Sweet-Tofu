using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CJC_InGameXboxUISelector : MonoBehaviour {
	public GameObject[]selectableUI;
	public int SelectedUI = -1;

	public string[] selectableUIScenes;
	public int SelectedUIScenes = -1;

	[SerializeField]
	bool hasbeenmoved = false;

	private float LastSize = 1;
	private float selectedSize = 1.2f;

	[SerializeField]
	float holdTimer = 0;

	public Sprite pressdown;
	public Sprite selected;
	public Sprite nothing;
	static public bool hastoshowcontrols = false;
	bool pressed = false;

	[SerializeField]
	AudioSource Source;
	[SerializeField]
	AudioClip backbuttonpressed;
	[SerializeField]
	AudioClip buttonpressed;
	[SerializeField]
	AudioClip buttonmoved;
	[SerializeField]
	AudioClip buhbye;

	bool readiedUP;

// Use this for initialization
void Start () 
{
	SelectedUI = 0;
	SelectedUIScenes = 0;
}

// Update is called once per frame
void Update () 
{
	SelectedUIString ();
	ManageSelectedUISize ();
	testInPut ();
	ManageButtonAction ();
	changeUIimage ();
		ReadyUp ();
		if (!pressed) {
			selectableUI [SelectedUI].gameObject.GetComponent<Image> ().sprite = selected;
		}
}

void SelectedUIString()
{
	SelectedUIScenes = SelectedUI;

	if (SelectedUIScenes == selectableUIScenes.Length-1) 
	{
		Debug.Log ("Selected UI String is exit game");
	}
	else
		Debug.Log ("Selected UI String is" + selectableUIScenes.GetValue(SelectedUIScenes));
	//Debug.Log ("Selected UI piece is" + SelectedUI);
}
	void changeUIimage(){
		if(!pressed)
			selectableUI [SelectedUI].gameObject.GetComponent<Image> ().sprite = selected;

	}

void testInPut()
{
		if (!pressed) {
			selectableUI [SelectedUI].gameObject.GetComponent<Image> ().sprite = nothing;
		}

		if (holdTimer >= .4f) 
		{
			hasbeenmoved = false;
			holdTimer = 0;
		}

		if (Input.GetAxisRaw ("Vertical") > 0.01f | Input.GetAxisRaw ("Vertical") < 0) 
		{
			holdTimer += Time.unscaledDeltaTime;
		}

		if (Input.GetAxisRaw ("Vertical") > 0.01f && hasbeenmoved == false) 
	{ 
			hasbeenmoved = true;

		if (SelectedUI >= 0)
		{
			selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
		}
			SelectedUI--;
			GetComponent<AudioSource> ().PlayOneShot (buttonmoved);

		if (SelectedUI < 0) 
		{
				SelectedUI = selectableUI.Length-1 ;
				GetComponent<AudioSource> ().PlayOneShot (buttonmoved);
		}
		selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);

	}
		else if (Input.GetAxisRaw ("Vertical") <0 && hasbeenmoved == false) 
	{
	hasbeenmoved = true;

		if (SelectedUI >= 0)
		{
			selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
		}
			SelectedUI++;
			GetComponent<AudioSource> ().PlayOneShot (buttonmoved);

		if (SelectedUI >= selectableUI.Length) 
		{
				SelectedUI = 0;
				GetComponent<AudioSource> ().PlayOneShot (buttonmoved);
		}
		selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
	}
		else if (Input.GetAxisRaw ("Vertical") == 0) 
	{
		//Debug.Log ("nothing pressed");
			holdTimer = 0;
		hasbeenmoved = false;
	}




	/*if (Input.GetKey(KeyCode.S)| Input.GetKey(KeyCode.W)) 
	{
		holdTimer += Time.unscaledDeltaTime;
	}


	if (Input.GetKeyDown(KeyCode.W) && hasbeenmoved == false) 
	{
			hasbeenmoved = true;

		if (SelectedUI >= 0)
		{
			selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);

		}
		SelectedUI--;

		if (SelectedUI < 0) 
		{
			SelectedUI = selectableUI.Length-1 ;
		}
		selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);

	}
	else if (Input.GetKeyDown(KeyCode.S) && hasbeenmoved == false)
	{
			hasbeenmoved = true;

		if (SelectedUI >= 0)
		{
			selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);

		}
		SelectedUI++;

		if (SelectedUI >= selectableUI.Length) 
		{
			SelectedUI = 0;
		}
		selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
	}*/
}

void ManageSelectedUISize()
{
	selectableUI [SelectedUI].transform.localScale = new Vector3 (selectedSize, selectedSize, selectedSize);
}
	void controls(){
		GameObject coregame = GameObject.FindWithTag ("GameCore");
		CJC_pauseActions core = coregame.GetComponent<CJC_pauseActions> ();

		GameObject coregame1 = GameObject.FindWithTag ("GameCore");
		CJC_PauseShit core1 = coregame1.GetComponent<CJC_PauseShit> ();

			//System.Threading.Thread.Sleep (5000);
		if (SelectedUI == 0 && core.ControllerToldMeToTurnYouOn == false) {
			core.ControllerToldMeToTurnYouOn = true;
			Debug.Log ("showing Controls");

			GetComponent<AudioSource> ().PlayOneShot (buttonpressed);
			pressed = false;
			core1.paused = true;
			hastoshowcontrols = false;

		} else if (SelectedUI == 0 && core.ControllerToldMeToTurnYouOn == true) {
			core.ControllerToldMeToTurnYouOn = false;
			Debug.Log ("closing Controls");
			//GetComponent<AudioSource> ().PlayOneShot (backbuttonpressed);
			pressed = false;
			core1.paused = true;
			hastoshowcontrols = false;
		}
	}

	void ReadyUp()
	{
		if (readiedUP) {
			GameObject coregame = GameObject.FindWithTag ("GameCore");
			CJC_pauseActions core = coregame.GetComponent<CJC_pauseActions> ();

			if (SelectedUIScenes == selectableUIScenes.Length - 1) {
				GetComponent<AudioSource> ().PlayOneShot (buhbye);
				Debug.Log ("exit game");
				Application.Quit ();
			}
		/*
		else if (SelectedUI == 0 && core.ControllerToldMeToTurnYouOn == false)
		{
			core.ControllerToldMeToTurnYouOn = true;
			Debug.Log ("showing Controls");
			pressed = false;
		}

		else if (SelectedUI == 0 && core.ControllerToldMeToTurnYouOn == true)
		{
			core.ControllerToldMeToTurnYouOn = false;
			Debug.Log ("closing Controls");
			pressed = false;
		}
		*/
		else if (SelectedUI == 1) {
				GameObject player = GameObject.FindWithTag ("Player");
				CJC_PlayerAndBools Player = player.GetComponent<CJC_PlayerAndBools> ();

				SceneManager.LoadScene (selectableUIScenes [SelectedUIScenes]);
				CJC_LifeCount.PlayerLives = 3;

				if (Player.RestartLevel == "PieSlice1") {
					Checkpoint.reachedcheckpoint25 = false;
					CJC_Scoring.timeT = 0;
					PlayerCoins.playerCoins = 0;
				} else if (Player.RestartLevel == "PieSlice2") {
					Checkpoint.reachedCheckpoint = false;
					Checkpoint.reachedCheckpoint2 = false;
					CJC_Scoring.time1 = 0;
					PlayerCoins.playerCoins = 0;
				} else if (Player.RestartLevel == "PieSlice3") {
					Checkpoint.reachedCheckpoint3 = false;
					Checkpoint.reachedcheckpoint4 = false;
					Checkpoint.reachedcheckpoint5 = false;
					Checkpoint.reachedcheckpoint6 = false;
					CJC_Scoring.time2 = 0;
					PlayerCoins.playerCoins = 0;
				} else if (Player.RestartLevel == "Level3") {
					Checkpoint.reachedcheckpoint7 = false;
					Checkpoint.reachedcheckpoint8 = false;
					Checkpoint.reachedcheckpoint9 = false;
					Checkpoint.reachedcheckpoint10 = false;
					Checkpoint.reachedcheckpoint11 = false;
					CJC_Scoring.time3 = 0;
					PlayerCoins.playerCoins = 0;
				} else if (Player.RestartLevel == "Level4") {
					Checkpoint.reachedcheckpoint16 = false;
					Checkpoint.reachedcheckpoint17 = false;
					Checkpoint.reachedcheckpoint18 = false;
					Checkpoint.reachedcheckpoint19 = false;
					Checkpoint.reachedcheckpoint20 = false;
					CJC_Scoring.time4 = 0;
					PlayerCoins.playerCoins = 0;
				} else if (Player.RestartLevel == "Level5") {
					Checkpoint.reachedcheckpoint12 = false;
					Checkpoint.reachedcheckpoint13 = false;
					Checkpoint.reachedcheckpoint14 = false;
					Checkpoint.reachedcheckpoint15 = false;
					CJC_Scoring.time5 = 0;
					PlayerCoins.playerCoins = 0;
				} else if (Player.RestartLevel == "Level6") {
					Checkpoint.reachedcheckpoint21 = false;
					Checkpoint.reachedcheckpoint22 = false;
					Checkpoint.reachedcheckpoint23 = false;
					Checkpoint.reachedcheckpoint24 = false;
					CJC_Scoring.time6 = 0;
					PlayerCoins.playerCoins = 0;
				}
			} else {
				Time.timeScale = 1;
				SceneManager.LoadScene (selectableUIScenes [SelectedUIScenes]);
			}
		}
	}

void ManageButtonAction()
{
	if (Input.GetButtonDown ("360_AButton") | Input.GetKeyDown(KeyCode.Return)) 
	{
			GameObject coregame = GameObject.FindWithTag ("GameCore");
			CJC_pauseActions core = coregame.GetComponent<CJC_pauseActions> ();

			GameObject coregame1 = GameObject.FindWithTag ("GameCore");
			CJC_PauseShit core1 = coregame1.GetComponent<CJC_PauseShit> ();

			pressed = true;
			selectableUI [SelectedUI].gameObject.GetComponent<Image> ().sprite = pressdown;


			if (SelectedUI == 0) {
				GetComponent<AudioSource> ().PlayOneShot (buttonpressed);
				Invoke ("controls", .1f);
				core1.paused = false;
				hastoshowcontrols = true;

			} else {

				GetComponent<AudioSource> ().PlayOneShot (buttonpressed);
				//ReadyUp();
				core1.paused = false;
				Invoke("callreaadyUP",.03f);
			}
	}
}

	void callreaadyUP()
	{
		readiedUP = true;
	}
}
