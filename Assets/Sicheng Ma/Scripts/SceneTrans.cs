using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrans : MonoBehaviour {

	public void changeToScene (string sceneToChangeTo) {
		SceneManager.LoadScene (sceneToChangeTo);
	}
}
