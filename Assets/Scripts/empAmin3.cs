using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class empAmin3 : MonoBehaviour
{
    public Animator tv2Anim;
    void Start()
    {
        tv2Anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            tv2Anim.Play("TV2Fall");
        }
    }
}
