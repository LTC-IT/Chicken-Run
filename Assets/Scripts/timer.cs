using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class timer : MonoBehaviour {

	private Text textField;
	private int currentTime;

	void Awake () {
		textField = GameObject.Find ("Canvas/timer").GetComponent<Text> ();
		UpdateTimerText ();
		StartCoroutine (Tick ());
	}

	// Update the GUI
	void UpdateTimerText () {
		textField.text = "Time: " + currentTime.ToString ();
	}

	IEnumerator Tick () {
		while (true) {
			Debug.Log ("Time: " + currentTime);
			yield return new WaitForSeconds (1);
			currentTime = currentTime + 1;
			UpdateTimerText ();
		}
	}
}