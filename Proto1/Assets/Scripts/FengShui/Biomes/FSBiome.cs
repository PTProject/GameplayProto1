using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FSBiome : FengShui {
	
	Vector3 position;
	float major;
	float minor;
	List<GameObject> Homes;


	protected override void Start () {
		base.Start ();
		Homes = new List<GameObject> ();
	}

	void Update () {
		
	}

	protected virtual void add (Item item) {
		if (Homes.Count == 0) {
			Homes.Add(Instantiate(Resources.Load("Home"),
			          item.gameObject.transform.position,
			          Quaternion.identity) as GameObject);
		}
	}

	protected virtual void add (FSHome home) {

	}
}
