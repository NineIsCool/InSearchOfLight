using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{

    public GameObject continueBottom;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("startSavePos"))
        {
            continueBottom.SetActive(true);
        }
    }
    public void Play()
    {
        SceneManager.LoadScene("1");
    }

    public void PlayNewGame()
    {
        PlayerPrefs.DeleteKey("startSavePos");
        DataContainer.checkpointIndex = 0;
        SceneManager.LoadScene("Story");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
