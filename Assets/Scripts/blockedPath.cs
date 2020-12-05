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
        if (other.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        Destroy(uiObject);
        Destroy(gameObject);
    }
}

