using UnityEngine;
using System.Collections;

public class waterMusicScript : MonoBehaviour {

	public AudioSource BlueDanube;
	public AudioSource underwaterSound;
	// Use this for initialization
	void Start () {
		audio.clip = BlueDanube;
		audio.Play ();
	}
	
	// Update is called once per frame
	void Update () {
	if (this.transform.position.y < 1) {
		audio.
	}

	}
}
