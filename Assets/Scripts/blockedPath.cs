using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockedPath : MonoBehaviour
{
    public GameObject uiObject;
    void Start()
    {
        uiObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            uiObject.SetActive(true);
            // StartCoroutine("WaitForSec");
        }
    }
    private void OnTriggerExit(Collider other) {
        uiObject.SetActive(false);
    }
    // IEnumerator WaitForSec()
    // {
    //     yield return new WaitForSeconds(5);
    //     Destroy(uiObject);
    //     Destroy(gameObject);
    // }
}

