using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIlernB : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        IsPressed("IsPressedD", KeyCode.D);
        IsPressed("IsPressedA", KeyCode.A);
        IsPressed("IsPressedW", KeyCode.W);
        IsPressed("IsPressedS", KeyCode.S);
    }

    private void IsPressed(string flag, KeyCode pressedKey)
    {
        if (Input.GetKeyDown(pressedKey))
        {
            animator.SetBool(flag, true);
        }
        else if (Input.GetKeyUp(pressedKey))
        {
            animator.SetBool(flag, false);
        }
    }
}
