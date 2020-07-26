using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour
{
    public void NextLevel(){
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        SceneManager.LoadScene("Game" + PlayerPrefs.GetInt("CURRENT_LEVEL", 1));
    }
}
