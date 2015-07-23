using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	float speed;
	Vector3 velocity;
	Rigidbody rb;
	Vector3? destination;
	int mapMask;
	float rayLength;
	
	void Start () {
		rb = GetComponent <Rigidbody>();
		speed = 5f;
		mapMask = LayerMask.GetMask ("Map");
		rayLength = 100f;
		destination = null;
	}

	void FixedUpdate () {

		getInput("RTSmouse");

	}

	void getInput(string controlScheme){
		switch (controlScheme) {
		case "RTSmouse":
			if(Input.GetMouseButtonDown(1)){
				setVelocityFromCursor(Input.mousePosition);
				velocity = velocity.normalized * speed * Time.deltaTime;
				rb.velocity = velocity;
			}
			if(destination.HasValue) {
				bool pointReached = rb.moveTo(destination.Value);
				if(pointReached) destination = null;
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

	void setVelocityFromCursor(Vector3 cursor){
		Ray camRay = Camera.main.ScreenPointToRay (cursor);

		RaycastHit ground;

		if (Physics.Raycast (camRay, out ground, rayLength, mapMask)) {
			destination = ground.point;
			velocity = destination.Value - transform.position;
			velocity.y = 0.5f;
		}
	}
}

public static class rbHelper {

	static float lastSqrMag = 0;

	public static bool moveTo(this Rigidbody rb, Vector3 to){
		Vector3 distance = to - rb.position;
		float sqrMag = distance.sqrMagnitude;
		if (sqrMag < lastSqrMag) {
			rb.MovePosition(to);
			lastSqrMag = 0;
			return true;
		} else {
			rb.MovePosition (rb.velocity + rb.position);
		}
		lastSqrMag = sqrMag;
		return false;
	}
}
