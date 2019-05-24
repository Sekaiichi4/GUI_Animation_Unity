using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RadialButton : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] bool expanded;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void ButtonPress()
    {
        Debug.Log("PRESSED");
        if(!expanded)
        {
            expanded = true;
            animator.SetBool ("pressed", true);
        }
        else
        {
            expanded = false;
            animator.SetBool ("pressed", false);
        }
    }

}
