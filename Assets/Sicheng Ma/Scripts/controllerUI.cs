using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controllerUI : MonoBehaviour {

	public GameObject[]selectableUI;
	public int SelectedUI = -1;

	public string[] selectableUIScenes;
	public int SelectedUIScenes = -1;

	bool hasbeenmoved = false;

	private float LastSize = 1;
	private float selectedSize = 1.5f;
	public GameObject leveltext;
	public GameObject leveltext2;
	public GameObject leveltext3;
	public float timer = 0f;
	public float timer2 = 0f;
	public float timer3 = 0f;

	// Use this for initialization
	void Start () 
	{
		SelectedUI = 0;
		SelectedUIScenes = 0;
		leveltext.SetActive (false);
		leveltext2.SetActive(false);
		leveltext3.SetActive (false);
	}

	// Update is called once per frame
	void Update () 
	{
		SelectedUIString ();
		ManageSelectedUISize ();
		testInPut ();
		ManageButtonAction ();
		timer += Time.deltaTime;
		timer2 += Time.deltaTime;
		timer3 += Time.deltaTime;
		if (leveltext.activeInHierarchy) {
			if (timer >= 4.0f) {
				leveltext.SetActive (false);
				timer = 0;
			}
		}

		if (leveltext2.activeInHierarchy) {
			if (timer2 >= 4.0f) {
				leveltext2.SetActive (false);
				timer2 = 0;
			}
		}

		if (leveltext3.activeInHierarchy) {
			if (timer3 >= 4.0f) {
				leveltext3.SetActive (false);
				timer3 = 0;
			}
		}
	}

	void SelectedUIString()
	{
		SelectedUIScenes = SelectedUI;

		Debug.Log ("Selected UI String is" + selectableUIScenes.GetValue(SelectedUIScenes));
		//Debug.Log ("Selected UI piece is" + SelectedUI);
	}

	void testInPut()
	{


		if (Input.GetAxis ("Vertical") > 0.01f && hasbeenmoved == false) 
		{// Debug.Log ("up");
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
		else if (Input.GetAxis ("Vertical") <0 && hasbeenmoved == false) 
		{
			//Debug.Log ("down");
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
		}
		else if (Input.GetAxis ("Vertical") == 0) 
		{
			//Debug.Log ("nothing pressed");
			hasbeenmoved = false;
		}


		if (Input.GetKeyDown(KeyCode.W) && hasbeenmoved == false) 
		{
			//Debug.Log ("up");
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
			//Debug.Log ("down");
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
		}
	}

	void ManageSelectedUISize()
	{
		selectableUI [SelectedUI].transform.localScale = new Vector3 (selectedSize, selectedSize, selectedSize);
	}

	void ManageButtonAction()
	{
		if (Input.GetButtonDown ("360_AButton") | Input.GetKeyDown (KeyCode.Return)) 
		{
			if (SelectedUIScenes == 1) {
				if (Scroll.scrollPickedup) {
					Debug.Log ("shit");
					SceneManager.LoadScene (selectableUIScenes [SelectedUIScenes]);
				} else {
					timer = 0;
					leveltext.SetActive (true);
				}
			} else if (SelectedUIScenes == 2) {
				if (Scroll.scrollPickedup && scroll2.scroll2Pickedup) {
					Debug.Log ("shit2");
					SceneManager.LoadScene (selectableUIScenes [SelectedUIScenes]);
				} else {
					timer2 = 0;
					leveltext2.SetActive (true);
				}
			} 
			else if (SelectedUIScenes == 3) {
				if (Scroll.scrollPickedup && scroll2.scroll2Pickedup && Scroll3.scroll3Pickedup) {
					Debug.Log ("shit2");
					SceneManager.LoadScene (selectableUIScenes [SelectedUIScenes]);
				} else {
					timer3 = 0;
					leveltext3.SetActive (true);
				}
			}
			else
			{
				SceneManager.LoadScene (selectableUIScenes [SelectedUIScenes]);
			}
		}
	}
}
