using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class dropdownScript : MonoBehaviour {
public GameObject player;
	void HandleInputData (int val) {
		if(val==0){
player.gameObject.GetComponent<HatCollision>().gender="boy";
		}
		if(val==1){
player.gameObject.GetComponent<HatCollision>().gender="girl";
		}
	}
}
