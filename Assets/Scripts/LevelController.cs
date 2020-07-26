using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#region Serializable classes
[System.Serializable]
public class EnemyWaves {
    [Tooltip("time for wave generation from the moment the game started")]
    public float timeToStart;

    [Tooltip("Enemy wave's prefab")]
    public GameObject wave;
}

#endregion

public class LevelController : MonoBehaviour {

    public EnemyWaves[] enemyWaves; 
    public Text waveText;
    Camera mainCamera;
    private int waveLeft;

    private void Start(){
        mainCamera = Camera.main;
        waveLeft = enemyWaves.Length;
        WaveText(waveLeft.ToString());
        for (int i = 0; i < enemyWaves.Length; i++) {
            StartCoroutine(CreateEnemyWave(enemyWaves[i].timeToStart, enemyWaves[i].wave));
        }
       

    }
    
    IEnumerator CreateEnemyWave(float delay, GameObject Wave) {
        if (delay != 0)
            yield return new WaitForSeconds(delay);
        if (Player.instance != null){
            Instantiate(Wave);
            waveLeft--;
            WaveText(waveLeft.ToString());
        }
    }
    private void WaveText(string wave){
        waveText.text = wave + " Gelombang Lagi";
        if(waveLeft == 0){
            GameObject.Find("GameCore").GetComponent<GameCore>().increaseScore();
        }
        
    }
}
