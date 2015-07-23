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

	void FixedUpdate () {

		getInput("RTSmouse");

		move(direction);
	}

	void getInput(string controlScheme){
		switch (controlScheme) {
		case "RTSmouse":
			if(Input.GetMouseButtonDown(1)){
				direction.x = Input.mousePosition.x - gameObject.transform.position.x;
				direction.z = Input.mousePosition.z - gameObject.transform.position.z;
			}
			break;
		case "RTSkey":
			break;
		case "RTSmousekey":
			break;
		case "thirdperson":
			break;
		}
	}

	void move(Vector3 destination){

	}

}
