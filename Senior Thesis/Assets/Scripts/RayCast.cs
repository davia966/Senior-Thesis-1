using UnityEngine;
using System.Collections;

public class RayCast : MonoBehaviour {

	public string functionToCallOnLook = "OnLook";

	public float dist = 25f;
//	public float power = 500;

	float x = Screen.width/2;
	float y = Screen.height/2;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	//if left mouse button is clicked
	//create a ray cast that originates from the center of the screen

		if(Input.GetMouseButtonDown(0)){
			//Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition); //draws the ray
			Ray rayOrigin = Camera.main.ScreenPointToRay(new Vector3(x, y, 0));
			RaycastHit hitInfo; //records the ray data

			if(Physics.Raycast(rayOrigin, out hitInfo, dist)){
				Debug.Log ("You are casting a ray!");
				Debug.DrawLine(rayOrigin.direction, hitInfo.point);

				if(hitInfo.rigidbody != null){
					//hitInfo.rigidbody.AddForceAtPosition(rayOrigin.direction * power, hitInfo.point);
					Debug.Log("This is a clickable object");
					hitInfo.transform.SendMessage (functionToCallOnLook, SendMessageOptions.DontRequireReceiver);
				}
			}
		}
	}
}
