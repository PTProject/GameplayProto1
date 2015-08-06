using UnityEngine;
using System.Collections;

public class DeerScare : Item {

	protected override void Start () {
		yin = 25;
		yang = 5;
		flowSpeed = 4f;
				
		element = fs_element.Wood;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
