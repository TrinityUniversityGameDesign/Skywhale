using UnityEngine;
using System.Collections;

public class waveSound : MonoBehaviour {
	public AudioClip waves;
	public GameObject skywhale;

	// Use this for initialization
	void Start () {
		audio.clip = waves;
		audio.Play ();
		//skywhale = GameObject.FindGameObjectWithTag ("Whale");
	}
	
	// Update is called once per frame
	void Update () {
		if ((skywhale.transform.position.y > 15) && !audio.mute){
			audio.mute = true;
		} else if (skywhale.transform.position.y <= 15 && audio.mute) {
			audio.mute = false;
		}
	}
}
