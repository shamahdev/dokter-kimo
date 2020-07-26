using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCore : MonoBehaviour
{
    public bool isLandscape = false, isHome = false;
    private void Start() {
        Time.timeScale = 1;
        if(isLandscape){
            Screen.orientation = ScreenOrientation.LandscapeLeft;
        }else{
            Screen.orientation = ScreenOrientation.Portrait;
        }

        if(isHome){
            PlayerPrefs.DeleteKey("CURRENT_LEVEL");
            PlayerPrefs.DeleteKey("TOTAL_SCORE");
        }
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape) && isHome){
            Application.Quit();
        }
    }

    public void ChangeScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }

    public void DeleteAll(){
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
