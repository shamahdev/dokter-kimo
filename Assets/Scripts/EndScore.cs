using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndScore : MonoBehaviour
{
    public Text Score;
    private int _Score;
    // Start is called before the first frame update
    void Awake(){
        _Score = PlayerPrefs.GetInt("TOTAL_SCORE", 0);
    }
    void Start(){
        PlayerPrefs.SetInt("FINISH_GAME", 1);
        Score.text = _Score.ToString();
    }
    public void PlayAgain(){
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(0);
    }
}
