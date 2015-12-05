using UnityEngine;
using System.Collections;

public class cardboardBox : MonoBehaviour {

	public string functionToCallOnLook = "getABox";
	public float rayDistance = 5f;
	public Vector3 playerPos;
	public GameObject boxPrefab;
	public GameObject yourPlayer;
	//public int numBoxes;

	float x = Screen.width / 2;
	float y = Screen.height / 2;

	// Use this for initialization
	void Start () {

		//numBoxes = 0;

		playerPos = yourPlayer.transform.position;

	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.E)){

			Ray rayOrigin = Camera.main.ScreenPointToRay(new Vector3 (x, y, 0));
			RaycastHit hit;

			if (Physics.Raycast(rayOrigin, out hit, rayDistance)){
				cardboardBox c = hit.collider.GetComponent<cardboardBox>();
				if (hit.rigidbody != null){
					hit.transform.SendMessage (functionToCallOnLook, SendMessageOptions.DontRequireReceiver);
					//Debug.Log ("GIVE ME A BOX PLEASE!!!");
				}
				if (c != null){
					Instantiate (boxPrefab, new Vector3(playerPos.x + 5, playerPos.y, playerPos.z), Quaternion.identity);
					Debug.Log ("GIVE ME A BOX PLEASE!!!");
//					for (int i = 0; i > numBoxes; i++){
//						Instantiate (boxPrefab, new Vector3(playerPos.x + 5, playerPos.y, playerPos.z), Quaternion.identity);
//						Debug.Log ("GIVE ME A BOX PLEASE!!!");
//					}
				}
			}
		}
	}
}
