﻿using UnityEngine;
using System.Collections;

public class Moveyoubastard : MonoBehaviour {
	private Transform pos;
	public float speed;
	public bool gravity = false;
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
		pos.RotateAround(pos.TransformPoint(Vector3.zero),pos.TransformDirection(Vector3.up),Input.GetAxis("Horizontal"));
		pos.RotateAround(pos.TransformPoint(Vector3.zero),pos.TransformDirection(Vector3.right),Input.GetAxis("Vertical"));
		pos.RotateAround(pos.TransformPoint(Vector3.zero),pos.TransformDirection(Vector3.forward),Input.GetAxis("Roll"));

		if (Input.GetButtonDown ("Fire3") && !gravity) {
			this.gameObject.rigidbody.drag = .001f;
			this.gameObject.rigidbody.angularDrag = .001f;
			this.gameObject.rigidbody.useGravity = true;
			this.gameObject.rigidbody.mass = 100f;
			gravity = true;
		}
		if (Input.GetButtonDown ("Fire3") && gravity) {
			this.gameObject.rigidbody.drag = 100f;
			this.gameObject.rigidbody.angularDrag = 100f;
			this.gameObject.rigidbody.useGravity = false;
			this.gameObject.rigidbody.mass = 1f;
			gravity = false;
		}
	}
}

