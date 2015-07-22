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

		turn();
		move();
	}

	void getInput(string controlScheme){
		switch (controlScheme) {
		case "RTSmouse":
			break;
		case "RTSkey":
			break;
		case "RTSmousekey":
			break;
		case "thirdperson":
			break;
		}
	}

	void turn(){
			
	}

	void move(){

	}

}
