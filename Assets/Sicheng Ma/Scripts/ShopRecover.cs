using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopRecover : MonoBehaviour {

	public CJC_PlayerAndBools player;

	public int cost;

	[SerializeField]
	GameObject RECBOUGHT = null;

	public GameObject nomoney;

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
		
		if (PlayerCoins.playerCoins >= cost) {
			PlayerCoins.playerCoins -= cost;
			RECBOUGHT.SetActive (true);
			player.PlayerHealth = 100;
			nomoney.SetActive (false);
		} else if(PlayerCoins.playerCoins < cost){
			nomoney.SetActive (true);
		}
	}
}
