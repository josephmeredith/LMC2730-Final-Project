using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerScene : MonoBehaviour
{
    public GameObject uiObject;
    public string levelToLoad; 
    void Start()
    {
        uiObject.SetActive(false);
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.E) && uiObject.activeSelf)
            {
                SceneManager.LoadScene(levelToLoad);
                // SceneManager.LoadScene("ENDING");
                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")  
        {
            uiObject.SetActive(true);
            // if (Input.GetKeyDown(KeyCode.E))
            // {
            //     // SceneManager.LoadScene(levelToLoad);
            //     SceneManager.LoadScene("ENDING");
            //     //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            // }
        }
    }
}
