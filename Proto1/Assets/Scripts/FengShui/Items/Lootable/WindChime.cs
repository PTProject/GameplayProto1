using UnityEngine;
using System.Collections;

public class WindChime : LootItem {
	
	protected override void Start () {
		base.Start ();
		yin = 54;
		yang = 10;
		flowSpeed = 8f;
		
		element = fs_element.Metal;
	}

	void Update () {
	
	}
}
