using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class final : MonoBehaviour
{
    public Animator anim;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        anim.SetTrigger("FinalTrigger");
    }

    public void LoadFinal()
    {
        
        SceneManager.LoadScene("Final");
    }
}
