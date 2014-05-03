using UnityEngine;
using System.Collections;

public class DetachCamera : MonoBehaviour {
	private Transform whale;
	private Quaternion origRot;
	private Vector3 origPos;
	private Transform pos;
	// Use this for initialization
	void Start () {
		pos = this.gameObject.transform;
		origRot = pos.localRotation;
		origPos = pos.localPosition;
		whale = pos.parent;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("LockCamera") > 0) {
			pos.parent = null;
		} else {
			if (pos.parent == null) {
				pos.parent = whale;
				print ("boop");
			}
			if (pos.localPosition != origPos) {
				pos.localPosition = Vector3.Lerp (pos.localPosition, origPos, 0.05f);
				print ("boop2");
			}
			if (pos.localRotation != origRot) {
				pos.localRotation = Quaternion.Lerp (pos.localRotation, origRot, 0.05f);
				print ("boop3");
			}
		}
	}
}