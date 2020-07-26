using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultPopup : MonoBehaviour
{
    public Text Score;
    public GameObject _Success, _Fail;
    private int _Score = 0;
    private bool success;

    private void Start() {
        GameObject.FindWithTag("Music").GetComponent<AudioSource>().Stop();
        Time.timeScale = 0;
    }

    public void Fail(){
        _Success.SetActive(false);
        _Fail.SetActive(true);
    }
    public void Success(int score, int penalty = 0){
        _Score = ((score*1000)-(score*penalty*300))/score;
        Score.text = _Score.ToString();
        _Success.SetActive(true);
        _Fail.SetActive(false);

        int nextLevel = PlayerPrefs.GetInt("CURRENT_LEVEL", 1) + 1;
        PlayerPrefs.SetInt("CURRENT_LEVEL", nextLevel);
        
        int totalScore = PlayerPrefs.GetInt("TOTAL_SCORE", 0) + _Score;
        PlayerPrefs.SetInt("TOTAL_SCORE", totalScore);
    }
    public void Next(){
        SceneManager.LoadScene("Cutscene");
    }
    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Home(){
        SceneManager.LoadScene(0);
    }
}
