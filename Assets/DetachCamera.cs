using UnityEngine;
using System.Collections;

public class DetachCamera : MonoBehaviour {
	private Transform whale;
	private Quaternion origRot;
	private Vector3 origPos;
	// Use this for initialization
	void Start () {
		origRot = this.gameObject.transform.localRotation;
		origPos = this.gameObject.transform.localPosition;
		whale = this.gameObject.transform.parent;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("LockCamera") > 0) {
			this.gameObject.transform.parent = null;
		} else {
			this.gameObject.transform.localRotation = origRot;
			this.gameObject.transform.localPosition = origPos;
			this.gameObject.transform.parent = whale;
		}
	}
}
