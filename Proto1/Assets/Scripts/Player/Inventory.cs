using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory {

	List<Item> items;
	readonly int iterator;

	public Inventory () {
		items = new List<Item> ();
		iterator = 0;

	}

	public void add (Item item) {
		item.gameObject.SetActive (false);
		items.Add (item);
	}

	public void drop (Item item) {
		item.gameObject.SetActive (true);
		items.Remove (item);
	}

	public void cycleNext () {

	}

	public void cycleBack () {
}
