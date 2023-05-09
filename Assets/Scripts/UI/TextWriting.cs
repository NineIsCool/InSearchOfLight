using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextWriting : MonoBehaviour
{
    public Text textGameObject;
    public GameObject secondText;
    private string text;
    private bool isDoneC=true;

    private void Start()
    {
        text = textGameObject.text;
        textGameObject.text = "";
    }
    private void Update()
    {
        if (textGameObject.gameObject.activeSelf && isDoneC)
        {
            StartCoroutine("TextCorutine");
        }
    }

    IEnumerator TextCorutine()
    {
        isDoneC = false;
        foreach (char abc in text)
        {
            textGameObject.text += abc;
            yield return new WaitForSeconds(0.1f);
        }

        while(textGameObject.text.Length>0)
        {
            textGameObject.text=textGameObject.text.Remove(textGameObject.text.Length - 1);
            yield return new WaitForSeconds(0.07f);
        }
        secondText.SetActive(true);
        textGameObject.gameObject.SetActive(false);
        isDoneC = true;
    }
}
