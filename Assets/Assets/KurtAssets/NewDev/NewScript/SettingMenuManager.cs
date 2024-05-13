using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public TMP_Dropdown graphicsDropdown;
    public Slider masterVol, musicVol, sfxVol;
    public AudioMixer settingAudioMixer;


    public void ChangeGraphicsQuality()
    {
        QualitySettings.SetQualityLevel(graphicsDropdown.value);
    }

    public void ChangeMasterVolume()
    {
        settingAudioMixer.SetFloat("MasterV", masterVol.value);
    }

    public void ChangeMusicVolume()
    {
        settingAudioMixer.SetFloat("MusicV", musicVol.value);
    }

    public void ChangeSFXVolume()
    {
        settingAudioMixer.SetFloat("MyExposedParam 2", sfxVol.value);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
