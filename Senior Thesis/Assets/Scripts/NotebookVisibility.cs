using UnityEngine;
using System.Collections;

public class NotebookVisibility : MonoBehaviour {

	public GameObject bookButton;
	

	private bool isShowing = false;
	
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update(){

	}

	void Interact () {
		isShowing = !isShowing;
		bookButton.SetActive(isShowing);
			
		bookButton.SetActive(true);
			
		Destroy(this.gameObject);
	}
}
