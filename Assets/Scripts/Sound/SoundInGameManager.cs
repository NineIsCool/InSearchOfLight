using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundInGameManager : MonoBehaviour
{
    public AudioSource audio;
    public float volume;

    private void Start()
    {
        Load();
        ValueSound();
    }
    private void ValueSound()
    {
        audio.volume = volume;
    }
    private void Load()
    {
        volume = PlayerPrefs.GetFloat("volume");
    }
}
