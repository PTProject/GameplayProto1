using UnityEngine;
using System.Collections;

public class WindChime : Item {
	
	protected override void Start () {
		yin = 54;
		yang = 10;
		flowSpeed = 8f;
		
		element = fs_element.Metal;
	}

	void Update () {
	
	}
}
