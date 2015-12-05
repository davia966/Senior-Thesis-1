using UnityEngine;
using System.Collections;

public class ObjectInteract : MonoBehaviour {

	//bool mousePressed;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

		//mousePressed = (Input.GetMouseButtonDown(0) ? true : false);

	
	}

	void Interact (){
		Destroy(this.gameObject);
		}
	}
