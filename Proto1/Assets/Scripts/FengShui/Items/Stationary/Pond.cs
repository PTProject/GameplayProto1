using UnityEngine;
using System.Collections;

public class Pond : Item {
	
	protected override void Start () {
		base.Start ();
		yin = 40f; 
		yang = 5f;
		flowSpeed = 10f;
		
		element = fs_element.Water;
	}

	void Update () {
		
	}
}
