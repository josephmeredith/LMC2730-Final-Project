using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VentScene : MonoBehaviour
{
    public GameObject leaveText;
    public GameObject dontText;
    public GameObject entrance;
    public GameObject exit;
    private bool onVent = false;

    void Start()
    {
        leaveText.SetActive(false);
        dontText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && onVent) {
            SceneManager.LoadScene("finalArea");
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player" && gameObject == entrance) {
            dontText.SetActive(true);
        } else {
            leaveText.SetActive(true);
            onVent = true;
        } 
    }

    private void OnTriggerExit(Collider other) {
        leaveText.SetActive(false);
        dontText.SetActive(false);
        onVent = false;
    }
}
