using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tvScriptforMB : MonoBehaviour
{
    public GameObject enterText;
    private bool playerStay = false;

    private void Start()
    {
        enterText.SetActive(false);
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.E) && playerStay)
        {
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            SceneManager.LoadScene("dialoguesceneMB");
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

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            enterText.SetActive(false);
            playerStay = false;
        }
    }
}


