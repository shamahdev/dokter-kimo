using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carousel : MonoBehaviour
{
    public GameObject[] carouselObjects;
    public GameObject prevNav;
    public GameObject nextNav;
    private int currentObject;
    // Start is called before the first frame update
    void Start(){
        currentObject = 0;
        Render(currentObject);
    }

    // Update is called once per frame
    private void Render(int current){
        if(current == 0){
            nextNav.SetActive(true);
            prevNav.SetActive(false);
        }else if(current == carouselObjects.Length-1){
            nextNav.SetActive(false);
            prevNav.SetActive(true);
        }else{
            nextNav.SetActive(true);
            prevNav.SetActive(true);
        }
        for (int i = 0; i < carouselObjects.Length; i++){
            if(i==current){
                carouselObjects[i].SetActive(true);
            }else{
                carouselObjects[i].SetActive(false);
            }
        }
    }
    public void NextSlide(){
        if(currentObject < carouselObjects.Length-1){
            Render(++currentObject);
        }
    }
    public void PrevSlide(){
        if(currentObject > 0){
            Render(--currentObject);
        }
    }
}
