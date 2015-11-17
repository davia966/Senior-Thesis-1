using UnityEngine;
using System.Collections;

public class Flashlight : MonoBehaviour {




	// Use this for initialization
	void Start () {
		GetComponent<Light>().enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Alpha1) && (GameObject.Find("Flashlight1").GetComponent<FlashLightVisibility>().haveLight)){
			if (GetComponent<Light>().enabled == false){
				GetComponent<Light>().enabled = true;
			} else {
				GetComponent<Light>().enabled = false;
			}
		}
	}
}
