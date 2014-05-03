using UnityEngine;
using System.Collections;

public class SkyChanger : MonoBehaviour {
	public Material sky;
	public Material water;
	public GameObject whale;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(this.gameObject.transform.position.y > Camera.main.transform.position.y){
			RenderSettings.skybox = water;
		}
		else{
			RenderSettings.skybox = sky;
		}
	}
}
