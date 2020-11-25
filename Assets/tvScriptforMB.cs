using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tvScriptforMB : MonoBehaviour
{
    public GameObject enterText;

    private void Start()
    {
        enterText.SetActive(false);
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enterText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enterText.SetActive(false);
        }
      
    }
}


