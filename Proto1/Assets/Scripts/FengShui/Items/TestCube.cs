using UnityEngine;
using System.Collections;

public class TestCube : Item {
	
	protected override void Start () {
		yin = 0;
		yang = 30;
		color = Color.blue;
		flowSpeed = 5f;
		element = fs_element.Earth;
	}

	protected override void Update () {
		
	}
}
