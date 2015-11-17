using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HandledCanvas : MonoBehaviour {

	private CanvasScaler scaler;

	// Use this for initialization
	void Start () {
		scaler = GetComponent<CanvasScaler>();

		scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
	
	}

}
