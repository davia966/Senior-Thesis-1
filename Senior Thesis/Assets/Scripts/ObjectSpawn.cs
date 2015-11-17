using UnityEngine;
using System.Collections;

public class ObjectSpawn : MonoBehaviour {

	public Transform rock;
	public int numRocks;

	// Use this for initialization
	void Start () {
		PlaceRocks();
	}

	void PlaceRocks(){
		for (int i = 0; i < numRocks; i++){
			Instantiate (rock, new Vector3(i * 2.0F, 0, 0), Quaternion.identity); 
		}
	}
	

	// Update is called once per frame
	void Update () {


	}
}
