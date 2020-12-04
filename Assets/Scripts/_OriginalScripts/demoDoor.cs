using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using TMPro;


public class demoDoor : MonoBehaviour
{
    public Text screenText;

    void Start() {
        screenText.text = "Press E to interact.";
        screenText.enabled = false;
    }

    void FixedUpdate() {
        if(Input.GetButton("Interact")) {
            screenText.text = "The door is locked. I need to find another way out.";
            //Debug.Log("Press registered");
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            screenText.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            screenText.enabled = false;      
        }
    }
}
