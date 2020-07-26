using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MateriManager : MonoBehaviour
{
    public void WatchCutscene(int num){
        PlayerPrefs.SetInt("WATCH_CUTSCENE", num);
        SceneManager.LoadScene("CutsceneOnly");
    }
}
