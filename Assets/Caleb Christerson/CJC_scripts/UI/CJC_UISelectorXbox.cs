using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CJC_UISelectorXbox : MonoBehaviour 
{
	public GameObject[]selectableUI;
	static public int SelectedUI = 0;

	public string[] selectableUIScenes;
	static public int SelectedUIScenes = 0;

	bool hasbeenmoved = false;

	private float LastSize = 1;
	private float selectedSize = 1.5f;

	[SerializeField]
	float holdTimer = 0;

	public Sprite pressdown;
	public Sprite selected;
	public Sprite nothing;

	private bool SelectedLevel = false;

	bool pressed = false;
	[SerializeField]
	AudioSource Source;
	[SerializeField]
	AudioClip buhbye;
	[SerializeField]
	AudioClip buttonpressed;
	[SerializeField]
	AudioClip buttonmoved;

	// Use this for initialization
	void Start () 
	{
		//SelectedUI = 0;
		//SelectedUIScenes = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		SelectedUIString ();
		ManageSelectedUISize ();
		testInPut ();
		ManageButtonAction ();
		changeUIimage ();

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

	void testInPut()
	{
		if (!pressed) {
			selectableUI [SelectedUI].gameObject.GetComponent<Image> ().sprite = nothing;
		}

		if (holdTimer >= 0.3f) 
		{
			hasbeenmoved = false;
			holdTimer = 0;
		}

		if (Input.GetAxisRaw ("Vertical") > 0.1f | Input.GetAxisRaw ("Vertical") < 0) 
		{
			holdTimer += Time.unscaledDeltaTime;
		}
		else if (Input.GetAxisRaw ("Vertical") == 0) 
		{
			holdTimer = 0;
		}


		if (Input.GetAxisRaw ("Vertical") > 0.1f && hasbeenmoved == false && !SelectedLevel) 
		{// Debug.Log ("up");
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
		else if (Input.GetAxisRaw ("Vertical") <0 && hasbeenmoved == false && !SelectedLevel) 
		{
			//Debug.Log ("down");
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
			hasbeenmoved = false;
			holdTimer = 0;
		}





		/*if (Input.GetKeyDown(KeyCode.W) && hasbeenmoved == false) 
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
		}*/
	}

	void changeUIimage(){
		if(!pressed)
			selectableUI [SelectedUI].gameObject.GetComponent<Image> ().sprite = selected;

	}

	void ManageSelectedUISize()
	{
		selectableUI [SelectedUI].transform.localScale = new Vector3 (selectedSize, selectedSize, selectedSize);
	}

	void ReadyUp()
	{
		if (SelectedUIScenes == selectableUIScenes.Length-1)
		{
			Debug.Log ("exit game");
			pressed = false;
			Application.Quit ();
			GetComponent<AudioSource> ().PlayOneShot (buhbye);
		} 
		else 
		{
			
			SceneManager.LoadScene (selectableUIScenes [SelectedUIScenes]);
			pressed = false;
		}
	}

	void ManageButtonAction()
	{
		if (Input.GetButtonDown ("360_AButton") | Input.GetKeyDown(KeyCode.Return)) 
		{
			pressed = true;
			GetComponent<AudioSource> ().PlayOneShot (buttonpressed);
			selectableUI [SelectedUI].gameObject.GetComponent<Image> ().sprite = pressdown;
			SelectedLevel = true;
			Invoke ("ReadyUp", 1f);

		}
	}
}
