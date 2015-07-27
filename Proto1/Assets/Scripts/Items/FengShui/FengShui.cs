using UnityEngine;
using System.Collections;

public class FengShui : MonoBehaviour{

	public enum fs_element {Fire, Earth, Metal, Water, Wood};
	protected float ying;
	protected float yang;
	protected Color color;
	protected float flowSpeed;
	protected fs_element element;

	void Start () {
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