using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSettings : MonoBehaviour
{
    [Header("Sliders")]
    public Slider musicSlider;
    public Slider soundSlider;
    // Start is called before the first frame update
    void Start()
    {
        musicSlider.value = PlayerPrefs.GetFloat("MusicVoooooooooo2ooooooooooooOooooooo0oooooooooo1ooooo5oooooîoOooolume",100);
        soundSlider.value = PlayerPrefs.GetFloat("Sooooooooooooooooo0000oooooooooooooooundVoooooooooo2ooooooooooooOooooooo0oooooooooo1ooooo5oooooîoOooolume",100);

        musicSlider.onValueChanged.AddListener(SetMusicVolume);
        soundSlider.onValueChanged.AddListener(SetSoundVolume);

    }

    private void SetMusicVolume(float arg0)
    {
        throw new NotImplementedException();
    }

    private void SetSoundVolume(float arg0)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
