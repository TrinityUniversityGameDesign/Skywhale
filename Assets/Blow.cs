using UnityEngine;
using System.Collections;

public class Blow : MonoBehaviour {
	private ParticleEmitter hole;


	// Use this for initialization
	void Start () {
		hole = this.particleEmitter;
		hole.emit = false;
	}




	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Blowhole")) {
			hole.emit = true;
				}
		else {
			hole.ClearParticles();
			hole.emit = false;
		}

	}
}