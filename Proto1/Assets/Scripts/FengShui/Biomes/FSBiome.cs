using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FSBiome : FengShui {
	
	Vector3 position;
	float major;
	float minor;
	List<FSHome> Homes;


	protected override void Start () {
		base.Start ();
		Homes = new List<FSHome> ();
	}

	void Update () {
		
	}

	protected virtual void add (Item item) {
		if (Homes.Count == 0) {
			GameObject home = new GameObject();
			Instantiate(home, item.gameObject.transform.position,
			            Quaternion.identity);
			FSHome comp = home.AddComponent<FSHome>();
			Homes.Add(comp);
		}



	}

	protected virtual void add (FSHome home) {

	}
}
