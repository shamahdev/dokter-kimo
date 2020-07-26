using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomEnemy : MonoBehaviour
{
    public GameObject[] car = new GameObject[3];
    public float[] delayTime = new float[3];
    private static float[] timer = new float[3];

    void Start(){
        for (int i = 0; i < timer.Length; i++){
            ResetTimer(i);
        }
    }

    void Update(){
        for (int i = 0; i < timer.Length; i++){
            timer[i] -= Time.deltaTime;
            if(timer[i] <= 0){
                Destroy(GameObject.Find("car" + (i+1) + "(Clone)"));
                Instantiate(car[i], this.gameObject.transform);
                ResetTimer(i);
            }
        }
    }

    void ResetTimer(int x){
            timer[x] = delayTime[x];
    }
}
