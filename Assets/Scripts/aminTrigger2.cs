using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aminTrigger2 : MonoBehaviour
{
    [SerializeField]
    private Animator triggAnim2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggAnim2.SetBool("animTrigger2", true);
        }
    }
}
