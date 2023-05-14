using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalManeger : MonoBehaviour
{
    void Start()
    {
        Invoke("Skip", 23f);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Skip();
        }
    }

    public void Skip()
    {
        SceneManager.LoadScene("Menu");
    }
}
