using UnityEngine;
using System.Collections;

public abstract class FengShui : MonoBehaviour{

	public enum fs_element {Fire, Earth, Metal, Water, Wood};
	protected float yin;
	protected float yang;
	protected Color color;
	protected float flowSpeed;
	protected fs_element element;
	protected SphereCollider FSradius;
	Rigidbody rb;

	protected virtual void Start (){
		FSradius = new SphereCollider ();
		rb = this.gameObject.AddComponent<Rigidbody> ();
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

	protected virtual void OnTriggerEnter() {

	}

	protected virtual void OnTriggerStay() {

	}
}