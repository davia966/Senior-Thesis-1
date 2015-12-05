using UnityEngine;
using System.Collections;

public class ObjectHighlight : MonoBehaviour {

	public GUISkin gameSkin;
	public string objectName;

	private Color startColor;
	private bool displayObjectName = false;

	// Use this for initialization
	void Start () {
		startColor = GetComponent<Renderer>().material.color;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){

		GUI.skin = gameSkin;
//		DisplayName();

	}

	void OnLook(){
//		displayObjectName = true;
		if (Input.GetKeyDown(KeyCode.E)){
			GetComponent<Renderer>().material.color = startColor;
//			displayObjectName = false;
		}else{
			GetComponent<Renderer>().material.color = Color.green;
		}
	}

	void OffLook(){
		GetComponent<Renderer>().material.color = startColor;
//		displayObjectName = false;
	}

//	public void DisplayName(){
//		if (displayObjectName == true){
//			GUI.Box(new Rect(Event.current.mousePosition.x - 155, Event.current.mousePosition.x, 150, 25), objectName,"Box2 Style");
//		}
//	}
}
