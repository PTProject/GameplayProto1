﻿using UnityEngine;
using System.Collections;

public class FengShui : MonoBehaviour{

	public enum fs_element {Fire, Earth, Metal, Water, Wood};
	protected float ying;
	protected float yang;
	protected Color color;
	protected bool smooth;
	protected fs_element element;

	void Start () {
		ying = 0;
		yang = 0;
	}

	void Update () {
	
	}

	public float YingValue(){
		return ying;
	}
	
	public float YangValue(){
		return yang;
	}

	public fs_element Element(){
		return element;
	}
}