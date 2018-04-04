using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class frednadolikethis : MonoBehaviour {

	public GameObject[]selectableUI;
	public int SelectedUI = 0;

	public string[] selectableUIScenes;
	public int SelectedUIScenes = 0;

	bool hasbeenmoved = false;

	private float LastSize = 1;
	private float selectedSize = 1.5f;

	[SerializeField]
	float holdTimer = 0;

	// Use this for initialization
	void Start () 
	{
		SelectedUI = 0;
		SelectedUIScenes = 0;
		Time.timeScale = 1;
	}

	// Update is called once per frame
	void Update () 
	{
		SelectedUIString ();
		ManageSelectedUISize ();
		testInPut ();
		ManageButtonAction ();
	}

	void SelectedUIString()
	{
		SelectedUIScenes = SelectedUI;
		Debug.Log ("Selected UI String is" + selectableUIScenes.GetValue(SelectedUIScenes));
	}

	void testInPut()
	{
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
		else if (Input.GetAxisRaw ("Vertical") <0 && hasbeenmoved == false) 
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
		else if (Input.GetAxisRaw ("Vertical") == 0) 
		{
			//Debug.Log ("nothing pressed");
			hasbeenmoved = false;
			holdTimer = 0;
		}
	}

	void ManageSelectedUISize()
	{
		selectableUI [SelectedUI].transform.localScale = new Vector3 (selectedSize, selectedSize, selectedSize);
	}

	void ManageButtonAction()
	{
		if (Input.GetButtonDown ("360_AButton") | Input.GetKeyDown(KeyCode.Return)) 
		{
			SceneManager.LoadScene (selectableUIScenes[SelectedUIScenes]);
		}
	}
}
