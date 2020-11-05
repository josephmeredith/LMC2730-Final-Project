using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class phoneMSG : MonoBehaviour
{
    public GameObject instructions;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Phone")
        {
            instructions.SetActive(true);
            Animator anim = other.GetComponentInChildren<Animator>();
            if (Input.GetKeyDown(KeyCode.E))
                anim.SetTrigger("phoneTrig");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Phone")
        {
            instructions.SetActive(false);
        }
    }
}
