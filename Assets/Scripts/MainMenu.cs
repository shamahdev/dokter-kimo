using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject materiEnable, materiDisable;
    // Start is called before the first frame update
    void Awake(){
        int UNLOCK = PlayerPrefs.GetInt("FINISH_GAME", 0);
        if(UNLOCK == 1){
            materiEnable.SetActive(true);
            materiDisable.SetActive(false);
        }else{
            materiEnable.SetActive(false);
            materiDisable.SetActive(true);
        }
    }
}
