using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory {

	List<Item> items;

	public Inventory () {
		items = new List<Item> ();

	}

	public void add (Item item) {
		item.gameObject.SetActive (false);
		items.Add (item);
	}

	public void drop (Item item) {
		item.gameObject.SetActive (true);
		items.Remove (item);
	}
}
