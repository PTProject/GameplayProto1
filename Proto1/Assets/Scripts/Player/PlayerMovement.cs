using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	float speed;
	Vector3 velocity;
	Rigidbody rb;
	Vector3 destination;
	int floorMask;

	void Start () {
		rb = GetComponent <Rigidbody>();
		speed = 5f;
	}

	void FixedUpdate () {

		getInput("RTSmouse");

	}

	void getInput(string controlScheme){
		switch (controlScheme) {
		case "RTSmouse":
			if(Input.GetMouseButtonDown(1)){
				velocity.x = Input.mousePosition.x - gameObject.transform.position.x;
				velocity.z = Input.mousePosition.z - gameObject.transform.position.z;
				destination = Input.mousePosition;
				destination.y = 0.5f;
			}
			velocity = velocity.normalized * speed * Time.deltaTime;
			moveTo(destination);
			break;
		case "RTSkey":
			break;
		case "RTSmousekey":
			break;
		case "thirdperson":
			break;
		}
	}

	void moveTo(Vector3 to){
		Vector3 distance = destination - transform.position;
		if (distance.magnitude < speed) {
			rb.MovePosition(to);
		} else {
			rb.MovePosition (velocity + transform.position);
		}
	}

}
