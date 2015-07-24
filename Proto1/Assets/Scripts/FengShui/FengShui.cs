using UnityEngine;
using System.Collections;

public class FengShui : MonoBehaviour {

	float ying;
	float yang;
	float chi;

	void Start () {
		
	}

	void Update () {
	
	}
}

public class Chi {
	float ying;
	float yang;
	float TotalChi;

	public Chi(float ying, float yang) {
		this.ying = ying;
		this.yang = yang;
		TotalChi = ying + yang;
	}

	public float YingValue(){
		return ying;
	}

	public float YangValue(){
		return yang;
	}
}
