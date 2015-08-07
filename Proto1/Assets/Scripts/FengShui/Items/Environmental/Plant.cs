using UnityEngine;
using System.Collections;

public class Plant : Item {
	
	protected override void Start () {
		yin = 0; 
		yang = 50;
		flowSpeed = 25f;

		element = fs_element.Wood;

	}

	void Update () {
	
	}
}
