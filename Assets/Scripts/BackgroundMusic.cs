using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundMusic : MonoBehaviour
{
   
    private static BackgroundMusic backgroundMusic;

    private AudioSource backgroundAudio;

    private void Awake()
    {
        if (backgroundMusic == null)
        {
            backgroundMusic = this;
            DontDestroyOnLoad(backgroundMusic);           
        }
        else
        {
            Destroy(gameObject);    
        }
    }
}