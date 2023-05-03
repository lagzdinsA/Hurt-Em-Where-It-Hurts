using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderScripts : MonoBehaviour {
	private Slider vSlider;
	public float minVal;
	public float maxVal;
	void Start () {
	
	vSlider = GameObject.Find("scaleSlider").GetComponent<Slider>();
	vSlider.minValue = minVal;
	vSlider.maxValue = maxVal;
	vSlider.onValueChanged.AddListener(SliderUpdate);
	}

void SliderUpdate(float value){
	transform.localScale = new Vector3(value, value, value);
}
}
