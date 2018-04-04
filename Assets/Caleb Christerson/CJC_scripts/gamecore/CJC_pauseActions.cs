using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CJC_pauseActions : MonoBehaviour
{
	public bool ControllerToldMeToTurnYouOn = false;
	public GameObject controls = null;

	public GameObject pausemenu;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		ControlsForController ();
		if (controls.activeInHierarchy) {
			pausemenu.SetActive (false);
		}
	}

	public void unpause()
	{
		GameObject core = GameObject.FindWithTag ("GameCore");
		CJC_PauseShit gamecore = core.GetComponent<CJC_PauseShit> ();

		gamecore.HandlePause (false);
	}

	public void MainMenu()
	{
		SceneManager.LoadScene (1);
		Time.timeScale = 1;
	}

	public void QuitGame()
	{
		Application.Quit ();
	}

	public void ShowControls()
	{
		ControllerToldMeToTurnYouOn = true;
		controls.SetActive (true);
	}

	public void ControlsForController()
	{
		GameObject ui = GameObject.FindWithTag ("InGameControllerUI");
		if (ui != null) {
			CJC_InGameXboxUISelector xbox = ui.GetComponent<CJC_InGameXboxUISelector> ();
		

			if (ControllerToldMeToTurnYouOn == true) {
				controls.SetActive (true);
				xbox.SelectedUI = 0;
			} else if (ControllerToldMeToTurnYouOn == false) {
				controls.SetActive (false);
			}
		} else
			return;
	}

	public void closeControls()
	{
		GameObject coregame = GameObject.FindWithTag ("GameCore");
		CJC_PauseShit core = coregame.GetComponent<CJC_PauseShit> ();

		ControllerToldMeToTurnYouOn = false;
		controls.SetActive (false);
		pausemenu.SetActive (true);
		core.paused = true;
	}
}
