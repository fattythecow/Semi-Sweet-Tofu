using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backgroundmusic : MonoBehaviour {

	void Awake(){
		GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
		if (objs.Length > 1)
			Destroy (this.gameObject);



		DontDestroyOnLoad (this.gameObject);

	}

	void Update(){
		Scene sceneloadf = SceneManager.GetActiveScene ();
		Debug.Log ("scenenumber " + sceneloadf.buildIndex);
		if (sceneloadf.buildIndex == 4 || sceneloadf.buildIndex == 5 || sceneloadf.buildIndex == 6 || sceneloadf.buildIndex == 7 || sceneloadf.buildIndex == 8 || sceneloadf.buildIndex == 9 || sceneloadf.buildIndex == 10 || sceneloadf.buildIndex == 12 || sceneloadf.buildIndex == 14 || sceneloadf.buildIndex == 15 || sceneloadf.buildIndex == 16 || sceneloadf.buildIndex == 17) {
			Destroy (this.gameObject);
		} else if(sceneloadf.buildIndex == 3){
			DontDestroyOnLoad (this.gameObject);
		}
	}
}
