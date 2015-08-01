using UnityEngine;
using System.Collections;

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

