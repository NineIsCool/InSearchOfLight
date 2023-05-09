using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueMusic : MonoBehaviour
{
    public AudioSource audio;
    private void Awake()
    {
        DontDestroyOnLoad(audio);
    }
}
