using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DemoVent : MonoBehaviour
{
    public Text screenText;

    void Start() {
        screenText.text = "This vent looks promising. Press E to interact.";
        screenText.enabled = false;
    }

    void FixedUpdate() {
        if(Input.GetButton("Interact")) {
            Debug.Log("Press registered");
            SceneManager.LoadScene("TechDemoVent");
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
