using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This script defines which sprite the 'Player" uses and its health.
/// </summary>

public class Player : MonoBehaviour
{
    public static Player instance; 
    public GameObject gameCore;

    private void Awake(){
        if (instance == null) 
            instance = this;
    }
    //method for damage proceccing by 'Player'
    public void GetDamage(int damage)   
    {
        gameCore.GetComponent<GameCore>().PenaltyScore();
    }
}
















