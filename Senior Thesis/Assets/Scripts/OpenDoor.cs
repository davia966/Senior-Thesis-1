using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour {

	private bool doorIsOpen = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void OnLook () {

		if (doorIsOpen == false) {
			transform.Rotate (transform.rotation.x, -90, transform.rotation.z);
			doorIsOpen = true;
		} else if (doorIsOpen == true) {
			transform.Rotate (transform.rotation.x, 90, transform.rotation.z);
			doorIsOpen = false;
		}
	}
}
