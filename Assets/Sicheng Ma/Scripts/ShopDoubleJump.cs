using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopDoubleJump : MonoBehaviour {

	public CJC_Starvation player;

	public int cost;
	[SerializeField]
	GameObject DJBOUGHT = null;

	public GameObject nomoney;

	public GameObject hasboughttext;

	// Use this for initialization
	void Start () {
		cost = 1;
	}

	// Update is called once per frame
	void Update () {
		
		if (nomoney.activeInHierarchy) {
			if (PlayerCoins.playerCoins >= cost) {
				nomoney.SetActive (false);
			}
		}
	}

	public void OnClick()
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player1 = p1.GetComponent<CJC_PlayerAndBools> ();

		if (PlayerCoins.playerCoins >= cost)
		{
			PlayerCoins.playerCoins -= cost;
			DJBOUGHT.SetActive (true);
			player.HungerTimer = 60;
		}
		else if(PlayerCoins.playerCoins < cost){
			nomoney.SetActive (true);
		}
	}
}
