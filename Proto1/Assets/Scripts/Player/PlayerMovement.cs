﻿using UnityEngine;
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
				Debug.Log (velocity.x + " " + velocity.z);
			}
			if(destination.HasValue) {
				//Debug.Log (velocity + " " + destination.Value);
				bool pointReached = rb.moveTo(destination.Value, velocity, speed);
				if(pointReached) {
					destination = null;
					Debug.Log ("reached");
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
			Debug.Log(velocity + " " + velocity.normalized + " " + (speed * Time.deltaTime));
		}
	}
}

public static class rbHelper {
	

	public static bool moveTo(this Rigidbody rb, Vector3 to, Vector3 velocity,
	                          float speed){
		Vector3 distance = to - rb.position;
		float sqrMag = distance.sqrMagnitude;
		if (sqrMag < velocity.sqrMagnitude) {
			rb.MovePosition (to);
			return true;
		} else {
			rb.MovePosition (velocity + rb.position);
		}
		return false;
	}
}
