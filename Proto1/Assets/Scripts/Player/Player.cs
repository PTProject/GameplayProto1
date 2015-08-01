using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	Inventory inventory;
	private bool isLooting;

	// Movement variables
	float speed;
	Vector3 velocity;
	Rigidbody rb;
	Vector3? destination;
	int mapMask;
	float rayLength;

	void Start () {
		inventory = new Inventory ();
		isLooting = false;

		rb = GetComponent <Rigidbody>();
		speed = 20f;
		mapMask = LayerMask.GetMask ("Map");
		rayLength = 100f;
		destination = null;
	}

	void Update () {
	
	}

	void FixedUpdate () {
		readInput("RTSmouse");
		//		Debug.Log (rb.velocity.sqrMagnitude);
	}

	void readInput(string controlScheme){
		switch (controlScheme) {
		case "RTSmouse":
			if(Input.GetMouseButtonDown(1)){
				RTSmouseMovement(Input.mousePosition);
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

	void RTSmouseMovement(Vector3 cursor){
		Ray camRay = Camera.main.ScreenPointToRay (cursor);
		
		RaycastHit ground;
		
		if (Physics.Raycast (camRay, out ground, rayLength)) {
			destination = ground.point;
			if(ground.collider.gameObject.tag == "Loot"){
				Vector3 temp = destination.Value;
				temp.y = 0.5f;
				isLooting = true;
				destination = temp;
			}

			velocity = destination.Value - rb.position;
			//			Debug.Log(velocity + " " + velocity.normalized + " " + (speed * Time.deltaTime));
		}
	}
	
	void loot (Item item) {
		inventory.add (item);
	}
	
	void drop () {
		
	}
	
	void kick () {
		
	}
	
	void pitch () {
		
	}

	void OnTriEnter(Collider other) {
		if (other.tag == "Loot") {
			Item item = other.GetComponent<Item>();
			if(isLooting){
				item.gameObject.SetActive(false);
				loot (item);
				isLooting = false;
			}
		}
	}
}