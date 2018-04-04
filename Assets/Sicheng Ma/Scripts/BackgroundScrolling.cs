using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScrolling : MonoBehaviour {

	public Vector2 ScrollSpeed = Vector2.zero;
	private Vector2 TextureOffset = Vector2.zero;

	void Start(){

	}

	void Update(){
		TextureOffset += ScrollSpeed * Time.deltaTime;
		GetComponent<Renderer> ().material.SetTextureOffset ("_MainTex", TextureOffset);
	}
}
