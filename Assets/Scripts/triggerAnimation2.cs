using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerAnimation2 : MonoBehaviour
{
    [SerializeField]
    private Animator myAnimation2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimation2.SetBool("triggerAni2", true);
        }
    }
}
