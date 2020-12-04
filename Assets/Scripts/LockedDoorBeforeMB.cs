using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LockedDoorBeforeMB : MonoBehaviour
{
    // public TextMeshProUGUI dtextDisplay;
    public GameObject doorText;
    public GameObject enterText;
    public GameObject beginText;
    private bool playerStay = false;
    //public KeyCode key;

    void Start()
    {
        // dtextDisplay.text = "Press E to interact.";
        // dtextDisplay.enabled = false;
        doorText.SetActive(false);
        enterText.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerStay)
        {
            // dtextDisplay.text = "That's weird. The door is locked.";
            // Debug.Log("button press registered");
            // doorText.text = "That's weird. The door is locked.";
            beginText.SetActive(false);
            enterText.SetActive(false);
            // dtextDisplay.enabled = true;
            doorText.SetActive(true);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
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
            playerStay = false;
        }
    }
}
