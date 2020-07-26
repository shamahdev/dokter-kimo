using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraSlider : MonoBehaviour
{
    public Slider cameraSlider;

    public void Start(){
        //Adds a listener to the main slider and invokes a method when the value changes.
        cameraSlider.onValueChanged.AddListener(delegate {ValueChangeCheck(); });
    }
    // Invoked when the value of the slider changes.
    public void ValueChangeCheck(){
        float value = cameraSlider.value;
        Camera.main.transform.position = new Vector3(value,1,-10);
    }
}
