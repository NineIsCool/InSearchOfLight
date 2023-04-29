using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPoint : MonoBehaviour
{
    public Transform player;
    public int indexCheckP;

    void Awake()
    {
        player = GameObject.Find("Player").transform;
        if (PlayerPrefs.HasKey("startSavePos"))
        {
            DataContainer.checkpointIndex = PlayerPrefs.GetInt("startSavePos");
        }
        if (DataContainer.checkpointIndex == indexCheckP)
        {
            player.position = transform.position;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && indexCheckP>DataContainer.checkpointIndex)
        {
            PlayerPrefs.SetInt("startSavePos", indexCheckP);
            PlayerPrefs.Save();
            DataContainer.checkpointIndex = indexCheckP;
        } 
    }
}
