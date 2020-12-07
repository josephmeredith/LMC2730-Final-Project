using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator myAnimation;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimation.SetBool("triggerAni", true);
        }
    }

    /*private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimation.SetBool("triggerAni", false);
        }
    }*/
}
