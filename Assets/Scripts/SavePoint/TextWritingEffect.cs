using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextWritingEffect : MonoBehaviour
{
    public Animator anim;
    public int indexCheckP;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && indexCheckP > DataContainer.checkpointIndex)
        {
            anim.SetTrigger("StartTxt");
        }
    }

}
