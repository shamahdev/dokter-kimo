using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class CutsceneManager : MonoBehaviour
{
    
    public int levelCount;
    public VideoPlayer videoPlayer;
    public VideoClip [] cutscenes;
    private int currentLevel;

    private void Awake() {
        currentLevel = PlayerPrefs.GetInt("CURRENT_LEVEL", 1);
    }

    private void Start() {
        PlayVideo(currentLevel-1);
        videoPlayer.loopPointReached += CheckOver;
    }

    public void NextLevel(){
        if(currentLevel <= levelCount){
            SceneManager.LoadScene("Game" + PlayerPrefs.GetInt("CURRENT_LEVEL", 1));
        }else{
            SceneManager.LoadScene("Score");
        }
    }

    private void PlayVideo(int num){
        videoPlayer.clip = cutscenes[num];
    }

    void CheckOver(UnityEngine.Video.VideoPlayer vp){
        NextLevel();
    }
}
