using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class lockedDoor : MonoBehaviour
{
    public GameObject doorText;
    public GameObject enterText;
    public GameObject continueButton;
    private bool playerStay = false;

    void Start()
    {
        // dtextDisplay.text = "Press E to interact.";
        // dtextDisplay.enabled = false;
        doorText.SetActive(false);
        enterText.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerStay && !continueButton.activeSelf)
        {
            enterText.SetActive(false);
            doorText.SetActive(true);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && !continueButton.activeSelf)
        {
            enterText.SetActive(true);
            playerStay = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            enterText.SetActive(false);
            doorText.SetActive(false);
            playerStay = false;
        }
    }
}
  