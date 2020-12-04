using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beginningText : MonoBehaviour
{
    public GameObject beginTxt;
    private bool entered = false;
    void Start()
    {
        beginTxt.SetActive(false);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !entered)
        {
            beginTxt.SetActive(true);
            StartCoroutine("WaitForSec");
            entered = true;
        }
    }

    // private void OnTriggerExit(Collider other) {
    //     entered = 
    // }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(6);
        beginTxt.SetActive(false);
        // Destroy(beginTxt);
        // Destroy(gameObject);
    }
}
