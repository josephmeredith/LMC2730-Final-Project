using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beginningText : MonoBehaviour
{
    public GameObject beginTxt;
    void Start()
    {
        beginTxt.SetActive(false);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            beginTxt.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(6);
        Destroy(beginTxt);
        Destroy(gameObject);
    }
}
