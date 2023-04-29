using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{


    public void Play()
    {
        SceneManager.LoadScene("1");
    }

    public void PlayNewGame()
    {
        PlayerPrefs.DeleteAll();
        DataContainer.checkpointIndex = 0;
        SceneManager.LoadScene("1");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
