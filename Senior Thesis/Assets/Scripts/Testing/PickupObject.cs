using UnityEngine;
using System.Collections;

public class PickupObject : MonoBehaviour {

	public string functionToCallOnLook = "Interact";
	GameObject mainCamera;
	bool carrying;
	GameObject carriedObject;
	GameObject throwableObject;
	public float distance;
	public float smooth;
	public float rayDistance = 5f;
	public Inventory inventory;
	public float speed = 1000f;

	// Use this for initialization
	void Start () {
		mainCamera = GameObject.FindWithTag("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
		if (carrying){
			carry(carriedObject);
			if (Input.GetKeyDown(KeyCode.Q)){
				throwObject();
				Debug.Log ("THREWW!");
			}
			checkDrop();
		}else{
			pickup();
		}
	}

	void carry (GameObject o){
		o.transform.position = Vector3.Lerp (o.transform.position, mainCamera.transform.position + mainCamera.transform.forward * distance, Time.deltaTime * smooth);
	}

	void pickup(){
		if (Input.GetKeyDown(KeyCode.E)){
			int x = Screen.width / 2;
			int y = Screen.height / 2;

			Ray rayOrigin = Camera.main.ScreenPointToRay(new Vector3 (x, y, 0));
			RaycastHit hit;

			if (Physics.Raycast(rayOrigin, out hit, rayDistance)){
				Pickupable p = hit.collider.GetComponent<Pickupable>();
				if (hit.rigidbody != null){
					hit.transform.SendMessage (functionToCallOnLook, SendMessageOptions.DontRequireReceiver);
				}
				if (p != null){
					carrying = true;
					carriedObject = p.gameObject;
					p.gameObject.GetComponent<Rigidbody>().isKinematic = true;
					p.gameObject.GetComponent<BoxCollider>().isTrigger = true;
				}
			}
		}
	}

	void checkDrop(){
		if (Input.GetKeyDown(KeyCode.E)){
			dropObject();
		}
	}

	void dropObject(){
		carrying = false;
		carriedObject.GetComponent<Rigidbody>().isKinematic = false;
		carriedObject.GetComponent<BoxCollider>().isTrigger = false;
		carriedObject = null;
	}

	void throwObject(){
		throwableObject = carriedObject;
		dropObject();
		throwableObject.GetComponent<Rigidbody>().AddForce(transform.forward * speed);
	}
}
