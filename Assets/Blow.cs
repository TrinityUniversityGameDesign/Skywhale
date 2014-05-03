using UnityEngine;
using System.Collections;

public class Blow : MonoBehaviour {
	private ParticleEmitter hole;
	public AudioClip blowholeSound;
	bool blowFlag = true;

	// Use this for initialization
	void Start () {
		hole = this.particleEmitter;
		hole.emit = false;
		audio.clip = blowholeSound;
	}




	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Blowhole") && blowFlag) {
			hole.emit = true;
			audio.Play();
		}
		if (!audio.isPlaying) {
		//	hole.ClearParticles();
			hole.emit = false;
			audio.Stop ();
		}

	}
}