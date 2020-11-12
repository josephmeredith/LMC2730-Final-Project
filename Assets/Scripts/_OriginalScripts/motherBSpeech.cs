using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motherBSpeech : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject speech;
    void Start()
    {
        speech.SetActive(false);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            speech.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        Destroy(speech);
        Destroy(gameObject);
    }
}
