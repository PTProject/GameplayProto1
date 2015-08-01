using UnityEngine;
using System.Collections;

public abstract class FengShui : MonoBehaviour{

	public enum fs_element {Fire, Earth, Metal, Water, Wood};
	protected float yin;
	protected float yang;
	protected Color color;
	protected float flowSpeed;
	protected fs_element element;

	protected virtual void Start () {
	}

	protected virtual void Update () {
	
	}

	public float YinValue(){
		return yin;
	}
	
	public float YangValue(){
		return yang;
	}

	public fs_element Element(){
		return element;
	}
}