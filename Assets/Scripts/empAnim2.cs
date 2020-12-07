using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class empAnim2 : MonoBehaviour
{

    public Animator tv1Anim;
    void Start()
    {
        tv1Anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            tv1Anim.Play("TV1Fall");
        }
    }
}
