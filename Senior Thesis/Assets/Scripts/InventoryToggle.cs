using UnityEngine;
using System.Collections;

public class InventoryToggle : MonoBehaviour {

	public GameObject menu;
	public GameObject slots;
	private bool isShowing;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Tab)) {
			isShowing = !isShowing;
			menu.SetActive (isShowing);
			slots.SetActive (isShowing);
		}
	}
}
