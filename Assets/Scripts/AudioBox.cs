using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBox : MonoBehaviour
{
    public AudioClip[] sounds;
    private AudioSource audioSource;
    
    void Start(){
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void PlaySoundOnce(int position){
        for(int i=0; i > sounds.Length; i++){
            if(i == position){
                audioSource.PlayOneShot(sounds[i]);
            }
        }
    }
}
