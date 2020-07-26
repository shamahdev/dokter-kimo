using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextPerson : MonoBehaviour
{
    public GameObject gameCore, wrapper;
    public Text textGejala;
    public GameObject[] people = new GameObject[8];
    public string[] gejala = new string[8];
    public bool[] positive = new bool[8];
    public AudioClip footstep;
    private int currentNumber = 0;
    private AudioSource audioSource;

    private void Start(){
        audioSource = GetComponent<AudioSource>();
        Render(currentNumber);
    }
    
    public void IsPositive(bool answer){
        if(positive[currentNumber] == answer){
            Next();
        }else{
            gameCore.GetComponent<GameCore>().PenaltyScore();
        }
    }
    private void Next(){
        gameCore.GetComponent<GameCore>().increaseScore();
        Render(++currentNumber);
    }

    private void Render(int num){
        audioSource.PlayOneShot(footstep);
        wrapper.SetActive(false);
        for (int i = 0; i < people.Length; i++){
            if (num == i){
                people[i].SetActive(true);
            }else{
                people[i].SetActive(false);
            }
        }
        wrapper.SetActive(true);
        textGejala.text = gejala[num];
    }
}
