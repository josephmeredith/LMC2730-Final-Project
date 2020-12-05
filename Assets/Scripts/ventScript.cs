using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ventScript : MonoBehaviour
{
    public GameObject ventText;
    public GameObject jumpText;
    
    void Start()
    {
        ventText.SetActive(false);
        jumpText.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ventText.SetActive(true);
            jumpText.SetActive(true);
            // StartCoroutine("WaitForSec");
        }
    }

    private void OnTriggerExit(Collider other) {
        ventText.SetActive(false);
        jumpText.SetActive(false);
    }
    
    // IEnumerator WaitForSec()
    // {
    //     yield return new WaitForSeconds(3);
    //     Destroy(ventText);
    //     Destroy(gameObject);
    // }
}
