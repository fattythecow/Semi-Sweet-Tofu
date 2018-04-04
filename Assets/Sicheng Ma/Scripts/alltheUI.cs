using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class alltheUI : MonoBehaviour {

	public GameObject[]selectableUI;
	public int SelectedUI = -1;

	public string[] selectableUIScenes;
	public int SelectedUIScenes = -1;

	bool hasbeenmoved = false;

	private float LastSize = 1.5f;
	private float selectedSize = 2f;

	[SerializeField]
	float holdTimer = 0;

	public Sprite pressdown;
	public Sprite selected;
	public Sprite nothing;

	bool pressed = false;

	[SerializeField]
	AudioSource Source;
	[SerializeField]
	AudioClip backbuttonpressed;
	[SerializeField]
	AudioClip buttonpressed;
	[SerializeField]
	AudioClip buttonmoved;


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
		//testInPut ();
		ManageButtonAction ();
		testallinout ();
		changeUIimage ();
	}

	void changeUIimage(){
		if(!pressed)
			selectableUI [SelectedUI].gameObject.GetComponent<Image> ().sprite = selected;

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
	}

	void testallinout(){
		
		if (!pressed) {
			selectableUI [SelectedUI].gameObject.GetComponent<Image> ().sprite = nothing;
		}
		
		if (holdTimer >= 0.1f) 
		{
			hasbeenmoved = false;
			holdTimer = 0;
		}
		if (Input.GetAxisRaw ("Vertical") > 0.1f | Input.GetAxisRaw ("Vertical") < 0 |Input.GetAxisRaw ("Horizontal") > 0.1f | Input.GetAxisRaw ("Horizontal") < 0) 
		{
			holdTimer += Time.unscaledDeltaTime;
		}
		else if (Input.GetAxisRaw ("Vertical") == 0|Input.GetAxisRaw ("Horizontal") == 0) 
		{
			holdTimer = 0;

		}

		if (SelectedUI == 0)
		{
			if (hasbeenmoved == false)
			{
				 if (Input.GetKeyDown (KeyCode.D)|Input.GetAxis ("Horizontal") >.1f)
				{
					selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
					SelectedUI = 1;
					hasbeenmoved = true;
					GetComponent<AudioSource> ().PlayOneShot (buttonmoved);
				}else if (Input.GetKeyDown (KeyCode.S)|Input.GetAxis ("Vertical") <0)
				{
					selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
					SelectedUI = 2;
					hasbeenmoved = true;
					GetComponent<AudioSource> ().PlayOneShot (buttonmoved);
				}
			}
		}
		else if (SelectedUI == 1)
		{
			if (hasbeenmoved == false)
			{

				if (Input.GetKeyDown (KeyCode.A)|Input.GetAxis ("Horizontal") <0f)
				{
					selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
					SelectedUI = 0;
					hasbeenmoved = true;
					GetComponent<AudioSource> ().PlayOneShot (buttonmoved);
				}
				else if (Input.GetKeyDown (KeyCode.S)|Input.GetAxis ("Vertical") <0)
				{
					selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
					SelectedUI = 2;
					hasbeenmoved = true;
					GetComponent<AudioSource> ().PlayOneShot (buttonmoved);
				}
			}
		}
		else if (SelectedUI == 2)
		{
			if (hasbeenmoved == false)
			{
				if (Input.GetKeyDown (KeyCode.W)|Input.GetAxis ("Vertical") >.1f)
				{
					GetComponent<AudioSource> ().PlayOneShot (buttonmoved);
					selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
					SelectedUI = 0;
					hasbeenmoved = true;

				}

			}
		}

	}

	void testInPut()
	{
		if (holdTimer >= .4f) 
		{
			hasbeenmoved = false;
			holdTimer = 0;
		}

		if (Input.GetAxisRaw ("Horizontal") > 0.01f | Input.GetAxisRaw ("Horizontal") <0) 
		{
			holdTimer += Time.unscaledDeltaTime;
		}


		if (Input.GetAxisRaw ("Horizontal") <0 && hasbeenmoved == false) 
		{
			hasbeenmoved = true;

			if (SelectedUI >= 0)
			{
				if (SelectedUI == 2) {
					selectableUI [SelectedUI].transform.localScale = new Vector3 (1, 1, 1);
				} else {
					selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
				}
			}
			SelectedUI--;
			GetComponent<AudioSource> ().PlayOneShot (buttonmoved);

			if (SelectedUI < 0) 
			{
				GetComponent<AudioSource> ().PlayOneShot (buttonmoved);
				SelectedUI = selectableUI.Length-1 ;
			}


			selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);

		}
		else if (Input.GetAxisRaw ("Horizontal") > 0.01f && hasbeenmoved == false) 
		{
			hasbeenmoved = true;


			if (SelectedUI >= 0)
			{
				if (SelectedUI == 2) {
					selectableUI [SelectedUI].transform.localScale = new Vector3 (1, 1, 1);
				} else {
					selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
				}
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
		else if (Input.GetAxisRaw ("Horizontal") == 0) 
		{
			holdTimer = 0;
			hasbeenmoved = false;
		}

	}

	void ManageSelectedUISize()
	{
		selectableUI [SelectedUI].transform.localScale = new Vector3 (selectedSize, selectedSize, selectedSize);
		/*
		if (SelectedUI == 2) {
			selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
		} else {
			selectableUI [SelectedUI].transform.localScale = new Vector3 (selectedSize, selectedSize, selectedSize);
		}
		*/
	}

	void ReadyUp()
	{
		if (SelectedUIScenes == selectableUIScenes.Length - 1)
		{
			SceneManager.LoadScene (selectableUIScenes[SelectedUIScenes]);
		} 
		else if (SelectedUIScenes == selectableUIScenes.Length - 2)
		{
			SceneManager.LoadScene (selectableUIScenes[SelectedUIScenes]);
		}
		else if (SelectedUIScenes == selectableUIScenes.Length - 3)
		{
			SceneManager.LoadScene (selectableUIScenes[SelectedUIScenes]);
		}
	}

	void ManageButtonAction()
	{


		if (Input.GetButtonDown ("360_AButton") | Input.GetKeyDown(KeyCode.Return)) 
		{
			if (SelectedUIScenes == selectableUIScenes.Length - 1)
			{
				GetComponent<AudioSource> ().PlayOneShot (backbuttonpressed);
			} 
			else if (SelectedUIScenes == selectableUIScenes.Length - 2)
			{
				GetComponent<AudioSource> ().PlayOneShot (buttonpressed);
			}
			else if (SelectedUIScenes == selectableUIScenes.Length - 3)
			{
				GetComponent<AudioSource> ().PlayOneShot (buttonpressed);
			}
			pressed = true;
			selectableUI [SelectedUI].gameObject.GetComponent<Image> ().sprite = pressdown;
			Invoke ("ReadyUp", .5f);

		}
	}
}
