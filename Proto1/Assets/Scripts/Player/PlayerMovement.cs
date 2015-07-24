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
		speed = 20f;
		mapMask = LayerMask.GetMask ("Map");
		rayLength = 100f;
		destination = null;
	}

	void FixedUpdate () {
		getInput("RTSmouse");
		Debug.Log (rb.velocity.sqrMagnitude);
	}

	void getInput(string controlScheme){
		switch (controlScheme) {
		case "RTSmouse":
			if(Input.GetMouseButtonDown(1)){
				setVelocityFromCursor(Input.mousePosition);
				velocity = velocity.normalized * speed * Time.deltaTime;
//				Debug.Log(destination.Value);
			}
			if(destination.HasValue) {
				//Debug.Log (velocity + " " + destination.Value);
				bool pointReached = rb.moveTo(destination.Value, velocity, speed);
				if(pointReached) {
					destination = null;
//					Debug.Log(rb.position);
				}
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
			velocity = destination.Value - rb.position;
//			Debug.Log(velocity + " " + velocity.normalized + " " + (speed * Time.deltaTime));
		}
	}
}

public static class rbHelper {
	
	static float lastSqrMag;

	public static bool moveTo(this Rigidbody rb, Vector3 to, Vector3 velocity,
	                          float speed){
		Vector3 distance = to - rb.position;
		float sqrMag = distance.sqrMagnitude;
//		Debug.Log (distance.sqrMagnitude + " " + velocity.sqrMagnitude + " " + lastSqrMag);
		if (sqrMag < lastSqrMag || lastSqrMag == 0) {
			rb.AddForce(velocity, ForceMode.VelocityChange);
			lastSqrMag = sqrMag;
			return false;
		} else {
			rb.velocity = Vector3.zero;
			lastSqrMag = 0;
		}
		return true;
	}
}
