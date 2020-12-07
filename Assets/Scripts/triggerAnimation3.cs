using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerAnimation3 : MonoBehaviour
{
    [SerializeField]
    private Animator myAnimation3;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimation3.SetBool("triggerAni3", true);
        }
    }
}
