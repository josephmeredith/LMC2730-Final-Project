using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ventScript : MonoBehaviour
{
    public GameObject ventText;
    void Start()
    {
        ventText.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            ventText.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }
    
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3);
        Destroy(ventText);
        Destroy(gameObject);
    }
}
