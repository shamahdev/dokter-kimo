using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class CutsceneOnlyManager : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public VideoClip [] cutscenes;
    private int watchCutscene;

    private void Awake() {
        watchCutscene = PlayerPrefs.GetInt("WATCH_CUTSCENE", 1);
    }

    private void Start() {
        PlayVideo(watchCutscene-1);
        videoPlayer.loopPointReached += CheckOver;
    }

    public void BackToMateri(){
        SceneManager.LoadScene("Materi");
    }

    private void PlayVideo(int num){
        videoPlayer.clip = cutscenes[num];
    }

    void CheckOver(UnityEngine.Video.VideoPlayer vp){
        BackToMateri();
    }
}