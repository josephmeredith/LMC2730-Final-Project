using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSpeech : MonoBehaviour
{
    public GameObject speechP;
    void Start()
    {
        speechP.SetActive(false);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            speechP.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(6);
        Destroy(speechP);
        Destroy(gameObject);
    }
}
