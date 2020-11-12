using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightTrigger : MonoBehaviour
{
    public GameObject malLights;
    //public AudioSource playSound;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        malLights.SetActive(true);
        //playSound().Play();
    }
  
}
