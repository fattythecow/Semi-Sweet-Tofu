using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_ShopXBOXController : MonoBehaviour
{
	public GameObject[]selectableUI;
	public int SelectedUI = -1;

	public string[] selectableUIScenes;
	public int SelectedUIScenes = -1;

	bool hasbeenmoved = false;

	private float LastSize = 1;
	private float selectedSize = 1.25f;

	[SerializeField]
	GameObject RECBOUGHT = null;
	[SerializeField]
	GameObject DJBOUGHT = null;
	//[SerializeField]
	//GameObject TELEBOUGHT = null;

	[SerializeField]
	float holdTimer = 0;

	public GameObject nomoney;

	public GameObject nomoney2;

	public GameObject disappear;

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


		if (nomoney.activeInHierarchy) {
			if (PlayerCoins.playerCoins >= 1) {
				nomoney.SetActive (false);
			}
		}
		if (nomoney2.activeInHierarchy) {
			if (PlayerCoins.playerCoins >= 1) {
				nomoney2.SetActive (false);
			}
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
				selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);
			}
			SelectedUI--;

			if (SelectedUI < 0) 
			{
				SelectedUI = selectableUI.Length-1 ;
			}
			selectableUI [SelectedUI].transform.localScale = new Vector3 (LastSize, LastSize, LastSize);

		}
		else if (Input.GetAxisRaw ("Horizontal") > 0.01f && hasbeenmoved == false) 
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
		}
		else if (Input.GetAxisRaw ("Horizontal") == 0) 
		{
			holdTimer = 0;
			hasbeenmoved = false;
		}





		/*if (Input.GetKeyDown(KeyCode.W) && hasbeenmoved == false) 
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

	void ManageButtonAction()
	{
		GameObject p1j = GameObject.FindWithTag ("Player");
		CJC_tryjumping playerj = p1j.GetComponent<CJC_tryjumping> ();
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		GameObject p2 = GameObject.FindWithTag ("Player");
		CJC_Starvation player1 = p2.GetComponent<CJC_Starvation> ();

		GameObject coregame = GameObject.FindWithTag ("GameCore");
		CJC_pauseActions core = coregame.GetComponent<CJC_pauseActions> ();

		GameObject shopcontroller = GameObject.Find ("ShopCalling");
		ShopController shop = shopcontroller.GetComponent<ShopController> ();

	//	GameObject tele = GameObject.Find ("BuyTelep");
//		CJC_BuyTeleport teleport = tele.GetComponent<CJC_BuyTeleport> ();

		GameObject dub = GameObject.Find ("BuyDJ");
		ShopDoubleJump doublejump = dub.GetComponent<ShopDoubleJump> ();

		GameObject rec = GameObject.Find ("BuyRec");
		ShopRecover recovery = rec.GetComponent<ShopRecover> ();

		if (Input.GetButtonDown ("360_AButton") | Input.GetKeyDown(KeyCode.Return)) 
		{
			if (SelectedUIScenes == selectableUIScenes.Length - 1)
			{
				Debug.Log ("shop close");
				shop.CloseShop ();
			} 
			else if (SelectedUIScenes == selectableUIScenes.Length - 3)
			{

				if (PlayerCoins.playerCoins >= doublejump.cost) 
				{
					PlayerCoins.playerCoins -= doublejump.cost;
					Debug.Log ("Buy double");
					player1.HungerTimer = 60;
					DJBOUGHT.SetActive (true);
				}
				else if(PlayerCoins.playerCoins < recovery.cost){
					nomoney2.SetActive (true);
				}

			}
			else if (SelectedUIScenes == selectableUIScenes.Length - 2)
			{
				if (PlayerCoins.playerCoins >= recovery.cost)
				{
					PlayerCoins.playerCoins -= recovery.cost;
					Debug.Log ("Buy Recovery");
					player.PlayerHealth = 100;
					RECBOUGHT.SetActive (true);
				}
				else if(PlayerCoins.playerCoins < recovery.cost){
					nomoney.SetActive (true);
				}
			}
		}
	}
}

