using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Playersalwaysmakingdecisions : MonoBehaviour {

	public GameObject[]selectableUI;
	public int SelectedUI = -1;

	public string[] selectableUIScenes;
	public int SelectedUIScenes = -1;
	[SerializeField]
	bool hasbeenmoved = false;

	private float LastSize = 1;
	private float selectedSize = 1.3f;
	[SerializeField]
	float holdTimer = 0;

	[SerializeField]
	GameObject IconCharacter = null;
	[SerializeField]
	GameObject Pos0 = null;
	[SerializeField]
	GameObject Pos1 = null;
	[SerializeField]
	GameObject Pos2 = null;
	[SerializeField]
	GameObject Pos3 = null;
	[SerializeField]
	GameObject Pos4 = null;
	[SerializeField]
	GameObject Pos5 = null;
	//[SerializeField]
	//GameObject Pos6 = null;
	[SerializeField]
	GameObject Pos7 = null;
	private Animator levelselectanim;
	private bool SelectedLevel = true;

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
	[SerializeField]
	AudioClip levelselected;


	// Use this for initialization
	void Start () 
	{
		SelectedLevel = false;
		levelselectanim = IconCharacter.GetComponent<Animator> ();
		SelectedUI = 0;
		SelectedUIScenes = 0;
		LastSize = 1;
	}

	// Update is called once per frame
	void Update () 
	{
		ManageAnimBools ();
		SelectedUIString ();
		ManageSelectedUISize ();
		testInPut ();
		ManageButtonAction ();
		changeUIimage ();
	}

	void ManageAnimBools()
	{
		if (SelectedLevel)
		{
			//Debug.Log ("animating idle");
			levelselectanim.SetBool ("LevelSelected", true);
		}
	}

	void SelectedUIString()
	{
		SelectedUIScenes = SelectedUI;

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

		if (holdTimer >= 0.3f) 
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
			//hasbeenmoved = false;
		}


		if (SelectedUI == 0&& !SelectedLevel)// if tutorial is selected
		{
			IconCharacter.transform.position = Pos0.transform.position;

			if (hasbeenmoved == false)
			{
				
				if (Input.GetKeyDown (KeyCode.S) | Input.GetKeyDown (KeyCode.A)| Input.GetAxis ("Vertical") <0 | Input.GetAxis ("Horizontal") <0)
				{
					GetComponent<AudioSource> ().PlayOneShot (buttonmoved);
					selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
					SelectedUI = 6;
					hasbeenmoved = true;
					Invoke ("ReadyUp", .25f);
				}
				else if (Input.GetKeyDown (KeyCode.D)|Input.GetAxis ("Horizontal") >.1f)// move to 1
				{
					GetComponent<AudioSource> ().PlayOneShot (buttonmoved);
					selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
					SelectedUI = 1;
					hasbeenmoved = true;
					Invoke ("ReadyUp", .25f);
				}
			}
		}
		else if (SelectedUI == 1&& !SelectedLevel)// if level 1 is selected
		{	
			IconCharacter.transform.position = Pos1.transform.position;

			if (hasbeenmoved == false)
			{
				
			if (Input.GetKeyDown (KeyCode.A)|Input.GetAxis ("Horizontal") <0f)// move to 0
				{
					GetComponent<AudioSource> ().PlayOneShot (buttonmoved);
				selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
					SelectedUI = 0;
					hasbeenmoved = true;
					Invoke ("ReadyUp", .25f);
			}
			else if (Input.GetKeyDown (KeyCode.D)|Input.GetAxis ("Horizontal") >.1f)// move to 2
				{
					GetComponent<AudioSource> ().PlayOneShot (buttonmoved);
				selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
					SelectedUI = 2;
					hasbeenmoved = true;
					Invoke ("ReadyUp", .25f);
			}
			}
		}
		else if (SelectedUI == 2&& !SelectedLevel)// if level 2 is selected
		{
			IconCharacter.transform.position = Pos2.transform.position;

			if (hasbeenmoved == false)
			{
				
			if (Input.GetKeyDown (KeyCode.A)|Input.GetAxis ("Horizontal") <0f)// move to 1
				{
					GetComponent<AudioSource> ().PlayOneShot (buttonmoved);
				selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
					SelectedUI = 1;
					hasbeenmoved = true;
					Invoke ("ReadyUp", .25f);
			}
			else if (Input.GetKeyDown (KeyCode.D)|Input.GetAxis ("Horizontal") >.1f)// move to 3
				{
					GetComponent<AudioSource> ().PlayOneShot (buttonmoved);
				selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
					SelectedUI = 3;
					hasbeenmoved = true;
					Invoke ("ReadyUp", .25f);
			}
			}
		}
		else if (SelectedUI == 3&& !SelectedLevel)// if level 3 is selected
		{
			IconCharacter.transform.position = Pos3.transform.position;

			if (hasbeenmoved == false)
			{
				
			if (Input.GetKeyDown (KeyCode.A)|Input.GetAxis ("Horizontal") <0f)// move to 2
				{
					GetComponent<AudioSource> ().PlayOneShot (buttonmoved);
				selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
					SelectedUI = 2;
					hasbeenmoved = true;
					Invoke ("ReadyUp", .25f);
			}
			else if (Input.GetKeyDown (KeyCode.S)|Input.GetAxis ("Vertical") <0)// move to 4
				{
					GetComponent<AudioSource> ().PlayOneShot (buttonmoved);
				selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
					SelectedUI = 4;
					hasbeenmoved = true;
					Invoke ("ReadyUp", .25f);
			}
			}
		}
		else if (SelectedUI == 4&& !SelectedLevel)// if level 4 is selected
		{
			IconCharacter.transform.position = Pos4.transform.position;

			if (hasbeenmoved == false)
			{
				
			if (Input.GetKeyDown (KeyCode.W)|Input.GetAxis ("Vertical") >.1f)// move to 3
				{
					GetComponent<AudioSource> ().PlayOneShot (buttonmoved);
				selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
					SelectedUI = 3;
					hasbeenmoved = true;
					Invoke ("ReadyUp", .25f);
			}
			else if (Input.GetKeyDown (KeyCode.A)|Input.GetAxis ("Horizontal") <0)// move to 5
				{
					GetComponent<AudioSource> ().PlayOneShot (buttonmoved);
				selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
					SelectedUI = 5;
					hasbeenmoved = true;
					Invoke ("ReadyUp", .25f);
			}
			}
		}
		else if (SelectedUI == 5&& !SelectedLevel)// if level 5 is selected
		{	
			IconCharacter.transform.position = Pos5.transform.position;

			if (hasbeenmoved == false)
			{
				
			if (Input.GetKeyDown (KeyCode.D)|Input.GetAxis ("Horizontal") >.1f)// move to 4
				{
					GetComponent<AudioSource> ().PlayOneShot (buttonmoved);
				selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
					SelectedUI = 4;
					hasbeenmoved = true;
					Invoke ("ReadyUp", .25f);
			}
			else if (Input.GetKeyDown (KeyCode.A)|Input.GetAxis ("Horizontal") <0)// move to 6
				{
					GetComponent<AudioSource> ().PlayOneShot (buttonmoved);
				selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
					SelectedUI = 6;
					hasbeenmoved = true;
					Invoke ("ReadyUp", .25f);
			}
			}
		}
		/*
		else if (SelectedUI == 6&& !SelectedLevel)// if tutorial is selected
		{
			IconCharacter.transform.position = Pos6.transform.position;

			if (hasbeenmoved == false)
			{
				
			if (Input.GetKeyDown (KeyCode.D)|Input.GetAxis ("Horizontal") >.1f)// move to 4
			{
				selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
					SelectedUI = 5;
					hasbeenmoved = true;
					Invoke ("ReadyUp", .25f);
			}
			else if (Input.GetKeyDown (KeyCode.A)|Input.GetAxis ("Horizontal") <0 |Input.GetKeyDown (KeyCode.S)|Input.GetAxis ("Vertical") <0)// move to 6
			{
				selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
					SelectedUI = 7;
					hasbeenmoved = true;
					Invoke ("ReadyUp", .25f);
			}
			}
		}
		*/
		else if (SelectedUI == 6&& !SelectedLevel)// if tutorial is selected
		{

			IconCharacter.transform.position = Pos7.transform.position;

			if (hasbeenmoved == false)
			{
				
			if (Input.GetKeyDown (KeyCode.D)|Input.GetAxis ("Horizontal") >.1f|Input.GetKeyDown (KeyCode.S)|Input.GetAxis ("Vertical") <0)// move to 4
				{
					GetComponent<AudioSource> ().PlayOneShot (buttonmoved);
				selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
					SelectedUI = 5;
					hasbeenmoved = true;
					Invoke ("ReadyUp", .25f);
			}
			else if (Input.GetKeyDown (KeyCode.A)|Input.GetAxis ("Horizontal") <0 |Input.GetKeyDown (KeyCode.W)|Input.GetAxis ("Vertical") >.1f)// move to 6
				{
					GetComponent<AudioSource> ().PlayOneShot (buttonmoved);
				selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
					SelectedUI = 0;
					hasbeenmoved = true;
					Invoke ("ReadyUp", .25f);
			}
			}
		}

	}

	void ManageSelectedUISize()
	{
		selectableUI [SelectedUI].transform.localScale = new Vector3 (selectedSize, selectedSize, selectedSize);
	}

	public void ManageButtonAction()
	{
		if (Input.GetButtonDown ("360_AButton") | Input.GetKeyDown (KeyCode.Return)) 
		{
			GetComponent<AudioSource> ().PlayOneShot (buttonpressed);
			if (SelectedUI != 6)
			{
				GetComponent<AudioSource> ().PlayOneShot (levelselected);
			}
			else if (SelectedUI == 6)
			{
				GetComponent<AudioSource> ().PlayOneShot (backbuttonpressed);
			}
			//SceneManager.LoadScene (selectableUIScenes [SelectedUIScenes]);
			pressed = true;
			selectableUI [SelectedUI].gameObject.GetComponent<Image> ().sprite = pressdown;
			Invoke ("realman", 0.001f);
		}
	}

	public void playlevelselect()
	{

	}

	void realman(){ 
		
		SelectedLevel = true;
	}

	void ReadyUp()
	{
		hasbeenmoved = false;
	}
}
