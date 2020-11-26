using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class DemoVent : MonoBehaviour
{
    public TextMeshProUGUI ventText;
    public bool onVent = false;

    void Start() {
        ventText.text = "Press E to interact";
        ventText.enabled = false;
    }

    void FixedUpdate() {
        if(Input.GetKeyDown(KeyCode.E) && onVent) {
            Debug.Log("Press registered");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            ventText.enabled = true;
            onVent = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ventText.enabled = false;      
            onVent = false;
        }
    }
}
