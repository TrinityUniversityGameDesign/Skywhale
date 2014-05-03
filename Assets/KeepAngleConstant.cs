using UnityEngine;
using System.Collections;

public class KeepAngleConstant : MonoBehaviour {
	public Transform whale;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.rotation = whale.rotation;
	}
}
