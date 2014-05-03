using UnityEngine;
using System.Collections;

public class Moveyoubastard : MonoBehaviour {
	private Transform pos;
	// Use this for initialization
	void Start () {
		pos = this.gameObject.transform;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetButton ("Fire1")) {
			pos.Translate(0,0,-0.1f);
		}
		pos.RotateAround(pos.TransformPoint(Vector3.zero),Vector3.up,Input.GetAxis("Horizontal"));
		pos.RotateAround(pos.TransformPoint(Vector3.zero),Vector3.forward,Input.GetAxis("Vertical"));
	}
}
