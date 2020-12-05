using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ventD : MonoBehaviour
{
    // public GameObject ventText;
    public GameObject interactText;
    private bool onVent = false;

    void Start()
    {
        interactText.SetActive(false);
        // ventText.SetActive(false);
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.E) && onVent) {
            SceneManager.LoadScene("ventScene");
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            // ventText.SetActive(true);
            interactText.SetActive(true); 
            onVent = true;           
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            // ventText.SetActive(false);
            interactText.SetActive(false);
            onVent = false;
        }
    }
}
