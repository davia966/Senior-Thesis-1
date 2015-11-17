using UnityEngine;
using System.Collections;

public class CursorHide : MonoBehaviour {

	bool CursorLockedVar;

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		CursorLockedVar = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Cancel") && !CursorLockedVar){
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
			CursorLockedVar = true;
		} else if (Input.GetButtonDown ("Cancel") && !CursorLockedVar) {
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
			CursorLockedVar = false;
		}
	}
}
