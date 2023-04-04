using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Text))]
public class LevelCounter : MonoBehaviour {

	Scene lastScene;
	Scene currentScene;
	public static int level = 0;
	private Text text;

	// Use this for initialization
	void Start () {

		//Using current scene name to determine action
		lastScene = SceneManager.GetActiveScene ();
	}
	
	// Update is called once per frame
	void Update () {
		//Get current scene
		currentScene = SceneManager.GetActiveScene ();
		Debug.Log(currentScene.name);

		if (currentScene.name != lastScene.name) {
			lastScene = currentScene;

			// Increase level when starting level
			if (currentScene.name == "Play") {
				GetComponent<Text>().enabled = true;
				level += 1;
				GetComponent<Text>().text = "Level " + level.ToString();
			}
			//Restart when loosing or initial screen
			else {
				level = 0;
				GetComponent<Text>().enabled = false;
			}
		}	
	}
}
