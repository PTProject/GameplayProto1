using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	Inventory inventory;
	private bool isLooting;

	void Start () {
		inventory = new Inventory ();
		isLooting = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void readInput () {
		
	}
	
	void loot (Item item) {
		inventory.add (item);
	}
	
	void drop () {
		
	}
	
	void kick () {
		
	}
	
	void pitch () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Loot") {
			Item item = other.GetComponent<Item>();
			if(isLooting){
				item.gameObject.SetActive(false);
				loot (item);
			}
		}
	}
}
