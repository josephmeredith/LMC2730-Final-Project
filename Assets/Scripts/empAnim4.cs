using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class empAnim4 : MonoBehaviour
{
    public Animator dryerAnim;
    //private Animator triggAnims;
    private bool keyPressed = true;
    void Start()
    {
        dryerAnim = GetComponent<Animator>();
    }
    
    void Update()
    {
        keyPressed = Input.GetKeyDown(KeyCode.E);
    }

    void OnTriggerEnter(Collider other)
    {
        if (keyPressed)
        {
            dryerAnim.Play("dryerFall");
        }
    }
}
