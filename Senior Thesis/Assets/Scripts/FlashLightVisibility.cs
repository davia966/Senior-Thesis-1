using UnityEngine;
using System.Collections;

public class FlashLightVisibility : MonoBehaviour {

	public GameObject lightButton;
	
	private bool isShowing;

	public bool haveLight;
	

	// Use this for initialization
	void Start () {

		haveLight = false;
	}
	
	// Update is called once per frame
	void Interact () {
		isShowing = !isShowing;
		lightButton.SetActive(isShowing);
			
		lightButton.SetActive(true);
			
		Destroy(this.gameObject);
	}

	void Update(){

		haveLight = true;
	}
}
