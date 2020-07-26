using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PausePopup : MonoBehaviour
{
    public Text scoreText;
    private int Score;
    private void Start(){
        GameObject.FindWithTag("Music").GetComponent<AudioSource>().Pause();
        Time.timeScale = 0;
        Score = PlayerPrefs.GetInt("TOTAL_SCORE", 0);
        RenderScore();
    }

    public void ChangeScene(string x){
        SceneManager.LoadScene(x);
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void RenderScore(){
        scoreText.text = Score.ToString();
    }

    public void Destroy(){
        GameObject.FindWithTag("Music").GetComponent<AudioSource>().UnPause();
        Destroy(this.gameObject);
    }
    private void OnDestroy(){
        Time.timeScale = 1;
    }
}
