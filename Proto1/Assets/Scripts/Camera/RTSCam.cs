using UnityEngine;
using System.Collections;

public class RTSCam : MonoBehaviour {

	public Transform target;
	public float smoothing = 10f;

	Vector3 offset;

	void Start () {
		transform.position = target.position;
		transform.position = new Vector3(transform.position.x - 4,
		                                 transform.position.y + 8,
		                                 transform.position.z - 4);

		transform.LookAt (target.position);
		offset = transform.position - target.position;

	}

	void Update () {
		Vector3 newCamPos = target.position + offset;

		transform.position = Vector3.Lerp (transform.position, newCamPos,
		                                   smoothing * Time.deltaTime);
	}
}
