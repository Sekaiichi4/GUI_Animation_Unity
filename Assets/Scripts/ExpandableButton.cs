using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ExpandableButton : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] TextMeshProUGUI text;

    [SerializeField] bool expanded;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void ExpandButton()
    {
        expanded = true;
        animator.SetBool ("pressed", true);
    }

    public void ShrinkButton()
    {
        expanded = false;
        animator.SetBool ("pressed", false);
    }

    public void ChangeText()
    {
        
        text.text = (expanded == true ? "Menu" : "Button");
        
    }
}
