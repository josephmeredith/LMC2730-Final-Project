using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class phoneTrigg : MonoBehaviour
{
    public GameObject phoneMSG;
    ///public string levelToLoad;
    // Start is called before the first frame update
    void Start()
    {
        phoneMSG.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            phoneMSG.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        phoneMSG.SetActive(false);
    }
}
