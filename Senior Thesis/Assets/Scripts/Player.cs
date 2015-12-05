using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed;
	public Inventory inventory;
	GameObject itemAdd;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		crouch();
	
	}

	private void crouch(){
		if (Input.GetKeyDown(KeyCode.C)){
			GetComponent<CharacterController>().height = 0.7f;
		} else if (Input.GetKeyUp(KeyCode.C)){
			GetComponent<CharacterController>().height = 1.8f;
		}
	}

	private void OnTriggerEnter (Collider other){
//		if (other.tag == "Item"){
//			if (Input.GetMouseButtonDown(3)){
//				inventory.AddItem(other.GetComponent<Item>());
//				Debug.Log ("ROCKS!!!!");
//			}
//		}
		if (other.tag == "Item"){
			inventory.AddItem(other.GetComponent<Item>());
			Debug.Log ("Rock it bitch!");
		}
	}
}
