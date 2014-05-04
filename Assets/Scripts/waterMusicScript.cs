using UnityEngine;
using System.Collections;

public class waterMusicScript : MonoBehaviour {

	AudioSource[] sounds;
	AudioSource musicSource;
	AudioSource underwaterSource;
	AudioSource waveSource;
	public AudioClip BlueDanube;
	public AudioClip underwaterSound;
	public AudioClip waves;

	public GameObject plane;
	public Transform water;
	bool underwaterFlag;
	// Use this for initialization
	void Start () {

		if (this.transform.position.y >= water.position.y) {
			underwaterFlag = true;
		} else {
			underwaterFlag = false;
		}
		sounds = GetComponents<AudioSource> ();
		musicSource = sounds [0];
		musicSource.clip = BlueDanube;
		musicSource.Play ();
		underwaterSource = sounds [1];
		underwaterSource.clip = underwaterSound;
		waveSource = sounds [2];
		waveSource.clip = waves;
		waveSource.Play ();
	}
	
	// Update is called once per frame
	void Update () {

		if ((this.transform.position.y < water.position.y) && !underwaterFlag) {
			musicSource.volume = 0.2f;
			underwaterSource.Play ();
			underwaterFlag = true;
			plane.SetActive (true);
		} else if ((this.transform.position.y >= water.position.y) && underwaterFlag) {
			musicSource.volume = 1f;
			underwaterSource.Stop ();
			underwaterFlag = false;
			plane.SetActive (false);
		}
		if ((this.transform.position.y > 15) && !waveSource.mute){
			waveSource.mute = true;
		} else if (this.transform.position.y <= 15 && waveSource.mute) {
			waveSource.mute = false;
		}
	}
}
