using UnityEngine;
using System.Collections;

public class waterMusicScript : MonoBehaviour {

	AudioSource[] sounds;
	AudioSource musicSource;
	AudioSource underwaterSource;
	public AudioClip BlueDanube;
	public AudioClip underwaterSound;
	bool underwaterFlag;
	// Use this for initialization
	void Start () {
		if (this.transform.position.y >= 1) {
			underwaterFlag = false;
		} else {
			underwaterFlag = true;
		}
		sounds = GetComponents<AudioSource> ();
		musicSource = sounds [0];
		musicSource.clip = BlueDanube;
		musicSource.Play ();
		underwaterSource = sounds [1];
		underwaterSource.clip = underwaterSound;
	}
	
	// Update is called once per frame
	void Update () {

		if ((this.transform.position.y < 1) && !underwaterFlag) {
			musicSource.volume = 0.2f;
			underwaterSource.Play ();
			underwaterFlag = true;
		} else if ((this.transform.position.y >= 1) && underwaterFlag) {
			musicSource.volume = 1f;
			underwaterSource.Stop ();
			underwaterFlag = false;
		}
	}
}
