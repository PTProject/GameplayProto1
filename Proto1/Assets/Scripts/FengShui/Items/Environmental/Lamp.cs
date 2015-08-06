using UnityEngine;
using System.Collections;

public class Lamp : Item {

	protected override void Start () {
		yin = 30;
		yang = 0;
		flowSpeed = 1.5f;
				
		element = fs_element.Earth;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
