using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	float speed;
	Vector3 direction;
	Rigidbody rigidbody;
	int floorMask;

	void Start () {
		rigidbody = GetComponent <Rigidbody>();
		float speed = 5f;
	}

	void Update () {
	
	}
}
