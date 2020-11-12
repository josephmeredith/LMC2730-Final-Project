using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class phoneScene : MonoBehaviour
{
    public GameObject instructions;
    public string unitySceneIII;
    void Start()
    {
        instructions.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Phone")
        {
            instructions.SetActive(true);
            if (instructions.activeInHierarchy == true && Input.GetKeyDown("Use"))
            {
               SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        instructions.SetActive(false);
    }

}
