using UnityEngine;
using System.Collections;

public enum ItemType {ROCK, STICK, OBJECT};

public class Item : MonoBehaviour {

	public Inventory inventory;

	public ItemType type;

	public Sprite spriteNeutral;

	public Sprite spriteHighlighted;

	public int maxSize;

	public void Use(){
		switch (type){
		case ItemType.ROCK:
			Debug.Log ("I just picked up a rock!");
			break;
		case ItemType.STICK:
			Debug.Log ("I just picked up a stick!");
			break;
		case ItemType.OBJECT:
			Debug.Log ("I just picked up an object!");
			break;
		}
	}
//	public void OnLook(Collider other){
//		if (other.tag == "Item"){
//			inventory.AddItem(other.GetComponent<Item>());
//		    Debug.Log ("ROCKS DUDE!");
//		}
//	}
}
