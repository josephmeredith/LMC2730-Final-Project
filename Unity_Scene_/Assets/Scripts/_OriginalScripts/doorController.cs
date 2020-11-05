using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorController : MonoBehaviour
{
    public GameObject instructions;
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "pCube220")
        {
            instructions.SetActive(true);
            Animator anim = other.GetComponentInChildren<Animator>();
            if(Input.GetKeyDown(KeyCode.E))
            anim.SetTrigger("OpenClose");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "pCube220")
        {
            instructions.SetActive(false);
        }
    }
}
