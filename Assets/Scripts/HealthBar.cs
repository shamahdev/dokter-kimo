using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public GameObject redOverlay;
    public Sprite healthOn, healthOf;
    public bool lose = false;
    private static Image[] healths = new Image[3];
    private int currentHealth, maxHealth;
     
    // Start is called before the first frame update
    void Start(){
        maxHealth = 3;
        currentHealth = maxHealth;
        for (int i = 0; i < healths.Length; i++){
            healths[i] = transform.GetChild(i).gameObject.GetComponent<Image>();
        }
    }
    public void Minus(){
        Instantiate(redOverlay, GameObject.FindWithTag("GUI").transform);
        currentHealth--;
        for (int i = (healths.Length-1); i >= 0; i--){
            if((i+1) > currentHealth){
                healths[i].sprite = healthOf;
            }else{
                healths[i].sprite = healthOn;
            }
        }
        if (currentHealth == 0){
            lose = true;
        }
    }

    public int Penalty(){
        return maxHealth-currentHealth;
    }
}
