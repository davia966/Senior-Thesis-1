using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class CursorHide : MonoBehaviour {

	bool CursorLockedVar;


	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		CursorLockedVar = true;
		GameObject.Find("Player").GetComponent<FirstPersonController>().enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Cancel") || Input.GetKeyDown (KeyCode.Tab) && CursorLockedVar == false){
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
			CursorLockedVar = true;
			GameObject.Find("Player").GetComponent<FirstPersonController>().enabled = true;

		} else if (Input.GetButtonDown ("Cancel") || Input.GetKeyDown (KeyCode.Tab) && CursorLockedVar == true) {
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
			CursorLockedVar = false;
			GameObject.Find("Player").GetComponent<FirstPersonController>().enabled = false;
		}
	}
}