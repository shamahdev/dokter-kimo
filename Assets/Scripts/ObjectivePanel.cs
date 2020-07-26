using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectivePanel : MonoBehaviour
{
    public AudioClip startSound;
    private AudioSource audioSource;
    public Text _Objective;
    // Start is called before the first frame update
    private void Awake() {
        audioSource = GetComponent<AudioSource>();
    }
    private void Start(){
        audioSource.PlayOneShot(startSound);
        Time.timeScale = 0;
    }
    public void SetObjective(string msg){
        _Objective.text = msg;
    }
    public void Destroy(){
        Destroy(this.gameObject);
    }
    private void OnDestroy(){
        Time.timeScale = 1;
    }
}
