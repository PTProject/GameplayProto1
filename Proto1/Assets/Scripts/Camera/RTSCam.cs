using UnityEngine;
using System.Collections;

public class RTSCam : MonoBehaviour {

	public Transform target;
	public float smoothing = 6f;

	Vector3 offset;

	void Start () {
		offset = transform.position - target.position;

	}

	void Update () {
		Vector3 newCamPos = target.position + offset;

		transform.position = Vector3.Lerp (transform.position, newCamPos,
		                                   smoothing * Time.deltaTime);

	}
}
