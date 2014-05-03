using UnityEngine;
using System.Collections;

public class Moveyoubastard : MonoBehaviour {
	private Transform pos;
	public float speed;
	bool gravFlag = true;
	// Use this for initialization
	void Start () {
		FadeIn.LoadLevel(1 ,0,5,Color.black);
		pos = this.gameObject.transform;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetButton ("Fire1")) {
			pos.Translate(0,0,-speed);
		}

		if (Input.GetButtonDown ("Fire3") && gravFlag) {
			gravFlag = false;
			this.gameObject.rigidbody.drag = .001f;
			this.gameObject.rigidbody.angularDrag = .001f;
			this.gameObject.rigidbody.useGravity = true;
			this.gameObject.rigidbody.mass = 100f;
		}
		if (Input.GetButtonUp ("Fire3") || !gravFlag) {
			this.gameObject.rigidbody.drag = 100f;
			this.gameObject.rigidbody.angularDrag = 100f;
			this.gameObject.rigidbody.useGravity = false;
			this.gameObject.rigidbody.mass = 1f;
			gravFlag = true;
		}
		pos.RotateAround(pos.TransformPoint(Vector3.zero),pos.TransformDirection(Vector3.up),Input.GetAxis("Horizontal"));
		pos.RotateAround(pos.TransformPoint(Vector3.zero),pos.TransformDirection(Vector3.right),Input.GetAxis("Vertical"));
		pos.RotateAround(pos.TransformPoint(Vector3.zero),pos.TransformDirection(Vector3.forward),Input.GetAxis("Roll"));
	}
}
