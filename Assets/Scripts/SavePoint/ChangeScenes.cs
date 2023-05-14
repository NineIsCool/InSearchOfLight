using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScenes : MonoBehaviour
{
    public int indexCheck;
    public GameObject scene1;
    public GameObject scene2;
    void Update()
    {
        if (indexCheck == PlayerPrefs.GetInt("startSavePos"))
        {
            scene1.SetActive(false);
            scene2.SetActive(true);
        }
        else
        {
            scene1.SetActive(false);
        }
    }
}
