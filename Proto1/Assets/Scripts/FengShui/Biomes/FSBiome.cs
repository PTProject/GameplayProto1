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
	}

	void Update () {
	
	}

	protected virtual void add (Item item) {
		if (Homes.Count == 0) {

		}
	}

	protected virtual void add (FSHome home) {

	}
}
