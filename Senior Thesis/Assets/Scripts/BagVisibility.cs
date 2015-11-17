using UnityEngine;
using System.Collections;

public class BagVisibility : MonoBehaviour {

	public GameObject bagButton;

	private bool isShowing;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnLook () {
		isShowing = !isShowing;
		bagButton.SetActive(isShowing);

		bagButton.SetActive(true);

		Destroy(this.gameObject);
	}
}

