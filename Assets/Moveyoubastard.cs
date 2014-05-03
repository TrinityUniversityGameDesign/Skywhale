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
			this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x,this.gameObject.transform.position.y,this.gameObject.transform.position.z-0.1f);
		}
		pos.RotateAround(Vector3.zero,Vector3.up,Input.GetAxis("Horizontal"));
	}
}
