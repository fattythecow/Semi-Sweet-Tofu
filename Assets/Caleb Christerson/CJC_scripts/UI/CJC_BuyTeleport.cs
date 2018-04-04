using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_BuyTeleport : MonoBehaviour {

	public CJC_PlayerAndBools player;

	public int cost = 1;

	public bool BoughtOnce = false;
	[SerializeField]
	GameObject TELEBOUGHT = null;

	public GameObject nomoney;

	public float timer = 0;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update ()
	{
		timer += Time.deltaTime;
		if (nomoney.activeInHierarchy) {
			if (timer >= 3) {
				timer = 0;
				nomoney.SetActive (false);
			}
		}
	}

	public void OnClick()
	{
		if (PlayerCoins.playerCoins >= cost) 
		{
			PlayerCoins.playerCoins -= cost;
			BoughtOnce = true;
			Invoke ("PayTele", 0);
		}else {
			nomoney.SetActive (true);
			timer = 0;
		}
	}

	public void PayTele()
	{
		GameObject p1 = GameObject.Find ("TeleportSpot");
		CJC_manageTeleport tele = p1.GetComponent<CJC_manageTeleport> ();

		if (BoughtOnce) 
		{
			CJC_manageTeleport.KnowsTeleport = true;
			TELEBOUGHT.SetActive (true);
			BoughtOnce = false;
		}
	}
}
