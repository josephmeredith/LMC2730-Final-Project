using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basementDoorScript : MonoBehaviour
{
    public GameObject doorText;
    public GameObject interactText;
    private bool playerStay = false;

    void Start()
    {
        doorText.SetActive(false);
        interactText.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerStay)
        {
            interactText.SetActive(false);
            doorText.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            interactText.SetActive(true);
            playerStay = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            interactText.SetActive(false);
            doorText.SetActive(false);
            playerStay = false;
        }
    }
}
