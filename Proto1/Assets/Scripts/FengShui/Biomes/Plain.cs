using UnityEngine;
using System.Collections;

public class Plain : FSBiome {

	protected override void Start () {
		base.Start ();
		yin = 120f;
		yang = 150f;
		color = Color.green;
		flowSpeed = 80f;
		element = fs_element.Earth;
	}

	protected void Update () {
		
	}
}
