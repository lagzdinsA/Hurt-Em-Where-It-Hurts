using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {
	public GameObject Blood;
	public AudioSource audio;
	public AudioClip clip;
	private void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.name=="Sword"){
			Instantiate(Blood,transform.position,Quaternion.identity);
			audio.PlayOneShot(clip);
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
