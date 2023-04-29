using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField]
    GameObject paused;

    private void Start()
    {
        paused.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !paused.activeSelf)
        {
            paused.SetActive(true);
            Time.timeScale = 0;
        }else if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void PauseOnB()
    {
        paused.SetActive(true);
        Time.timeScale = 0;
    }

    public void PauseOff()
    {
        paused.SetActive(false);
        Time.timeScale = 1;
    }

    public void Menu()
    {
        SceneManager.LoadScene("menu");
        Time.timeScale = 1;
    }

    public void Exit()
    {
        Debug.Log("exit");
        Application.Quit();
    }
}
