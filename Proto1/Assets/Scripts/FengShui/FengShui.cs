using UnityEngine;
using System.Collections;

public class FengShui : MonoBehaviour{

	protected float ying;
	protected float yang;
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

public enum fs_element {Fire, Earth, Metal, Water, Wood};