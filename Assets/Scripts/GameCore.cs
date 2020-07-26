using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameCore : MonoBehaviour
{
    public AudioClip rightAnswerSound, wrongAnswerSound, successSound, failSound;
    public GameObject objectiveButton, resultPopup, healthBar;
    public string message;
    public int currentLevel, maxScore;
    private AudioSource audioSource;
    private int score, penalty;

    private void Awake() {
        audioSource = GetComponent<AudioSource>();
        PlayerPrefs.SetInt("CURRENT_LEVEL", currentLevel);
        objectiveButton.GetComponent<ObjectiveButton>().SetMsg(message);
        Render();
    }
    private void Render(){
        objectiveButton.GetComponent<ObjectiveButton>().SetScore(score, maxScore);
    }
    public void increaseScore(){
        if(score < maxScore){    
            audioSource.PlayOneShot(rightAnswerSound);
            score++;
            Render();
            if(score == maxScore){
                EndGame("success");
            }
        }
    }
    public void PenaltyScore(){
        audioSource.PlayOneShot(wrongAnswerSound);
        healthBar.GetComponent<HealthBar>().Minus();
        if(healthBar.GetComponent<HealthBar>().lose){
            EndGame("fail");
        }
    }
    private void EndGame(string option = "success"){
        if(option == "success"){
            penalty = healthBar.GetComponent<HealthBar>().Penalty();
            resultPopup.GetComponent<ResultPopup>().Success(score, penalty);
            audioSource.PlayOneShot(successSound);
        }else if(option == "fail"){
            resultPopup.GetComponent<ResultPopup>().Fail();
            audioSource.PlayOneShot(failSound);
        }
        Instantiate(resultPopup, GameObject.FindWithTag("GUI").transform);
    }
}
