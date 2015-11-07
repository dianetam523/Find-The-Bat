using UnityEngine;
using System.Collections;

public class RayCast : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 target = GameObject.FindGameObjectWithTag ("CrossHair").transform.position;
		RayCastHit hit;
		Physics.Raycast(target, 

	}
}
