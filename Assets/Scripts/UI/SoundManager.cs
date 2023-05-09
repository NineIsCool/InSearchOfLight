using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Slider sliderValueSound;
    public AudioSource audio;
    public float volume;

    private void Start()
    {
        if (!DataContainer.isPlayM)
        {
            audio.Play();
            DataContainer.isPlayM = true;
        }
        Load();
        ValueSound();
    }

    public void SliderSound()
    {
        volume = sliderValueSound.value;
        ValueSound();
    }

    private void ValueSound()
    {
        audio.volume = volume;
        sliderValueSound.value = volume;
    }

    public void Save()
    {
        PlayerPrefs.SetFloat("volume", volume);
    }

    private void Load()
    {
        volume = PlayerPrefs.GetFloat("volume");
    }
}
