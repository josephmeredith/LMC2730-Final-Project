using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class empAnim : MonoBehaviour
{
    public Animator macAnim;
    void Start()
    {
         macAnim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            macAnim.Play("mac1Fall");
        }
    }
}
