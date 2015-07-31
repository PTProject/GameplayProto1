using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

	List<Item> items;

	void Start () {
		items = new List<Item> ();

	}

	void Update () {
		
	}

	void add (Item item) {
		item.gameObject.SetActive (false);
		items.Add (item);
	}

	void drop (Item item) {
		item.gameObject.SetActive (true);
		items.Remove (item);
	}
}
