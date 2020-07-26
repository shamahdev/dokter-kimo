using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pausePopup;

    private void Start() {
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if(GameObject.Find("PausePopup(Clone)")){
                SceneManager.LoadScene(0);
            }else{
                OpenPause();
            }
        }
    }

    public void OpenPause(){
        Instantiate(pausePopup, GameObject.FindWithTag("GUI").transform);
    }
}
