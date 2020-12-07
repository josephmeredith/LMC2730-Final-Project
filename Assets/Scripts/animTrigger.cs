using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animTrigger : MonoBehaviour
{
    [SerializeField]
    private Animator triggAnim;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggAnim.SetBool("animTrigger", true);
        }
    }
}
