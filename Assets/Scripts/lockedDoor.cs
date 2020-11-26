using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class lockedDoor : MonoBehaviour
{
    public TextMeshProUGUI dtextDisplay;
    //public GameObject text;
    //public KeyCode key;

    void Start()
    {
        dtextDisplay.text = "Press E to interact.";
        dtextDisplay.enabled = false;

    }
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            dtextDisplay.text = "Damn, MotherBoard locked me in... I have to find another way out.";
            //Debug.Log("Press registered");
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            dtextDisplay.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            dtextDisplay.enabled = false;
        }
    }
}
  