using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScore : MonoBehaviour
{
    public GameObject gameCore;
    public float finishDistance = 20f;
    public Text distanceText;
    private float currentTime = 0f;
    private bool available;
    private float distance;

    // Start is called before the first frame update
    void Start(){
        currentTime = finishDistance;
        available = true;
    }
    void Update(){
        if(available){
            currentTime -= 1f * Time.deltaTime;
            distance = (float) currentTime/10;
            distanceText.text = distance.ToString("f1") + " KM Lagi";
            if(currentTime < 0f){
                available = false;
            }
        }else{
            gameCore.GetComponent<GameCore>().increaseScore();
        }
    }
}
