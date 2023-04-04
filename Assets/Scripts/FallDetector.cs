using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDetector : MonoBehaviour {

	public float maxFall = -1f;
	private GameObject whisperSounds;
	
	// Use this for initialization
	void Start () {
		 whisperSounds = GameObject.Find("WhisperSource");
	}
	
	// Update is called once per frame
	void Update () {

		// If player is below certain Y limit go to game over screen
		if (transform.position.y < maxFall) {
			Destroy(whisperSounds);
			SceneManager.LoadScene("GameOver");
		}
	}
}
