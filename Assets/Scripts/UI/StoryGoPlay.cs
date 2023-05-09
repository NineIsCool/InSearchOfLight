using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StoryGoPlay : MonoBehaviour
{
    void Start()
    {
        Invoke("Skip", 17f);
    }

    public void Skip()
    {
        SceneManager.LoadScene("1");
    }
}
