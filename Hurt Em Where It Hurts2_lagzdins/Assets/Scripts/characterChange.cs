using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class characterChange : MonoBehaviour {
	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent<Image>().sprite=HatCollision.current;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
