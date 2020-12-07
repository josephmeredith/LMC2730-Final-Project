using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FuseCollection : MonoBehaviour
{
    public GameObject collectText;
    public GameObject collectKey;
    public GameObject keyText;
    public GameObject key;
    public GameObject doorB;
    private bool onFuse = false;
    private bool collectFuses = false;
    private bool finished = false;
    private bool enabling = false;
    private bool onKey = false;
    private bool hasKey = false;
    private bool onDoor = false;
    private bool onBreaker = false;
    public GameObject currentFuse;
    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;
    public GameObject interactText;
    public GameObject breakerText;
    public GameObject doorText;

    public GameObject[] enable = new GameObject[10];
    public GameObject[] disable = new GameObject[10];
    private int currentSlot = 0;

    void Start()
    {
        breakerText.SetActive(false);
        collectText.SetActive(false);
        collectKey.SetActive(false);
        keyText.SetActive(false);
        slot1.SetActive(false);
        slot2.SetActive(false);
        slot3.SetActive(false);
        slot4.SetActive(false);
        doorText.SetActive(false);
        interactText.SetActive(false);
        // doorB.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && onFuse) {
            currentFuse.SetActive(false);
            collectText.SetActive(false);
            currentSlot++;
            onFuse = false;
        } else if (Input.GetKeyDown(KeyCode.E) && enabling) {
            interactText.SetActive(false);
            collectText.SetActive(false);
            enableAll();
            disableAll();
            enabling = false;
        } else if (Input.GetKeyDown(KeyCode.E) && onKey) {
            Debug.Log("on key!!!");
            key.SetActive(false);
            hasKey = true;
            keyText.SetActive(true);
            collectKey.SetActive(false);
        } else if (Input.GetKeyDown(KeyCode.E) && onDoor && !hasKey) {
            interactText.SetActive(false);
            doorText.SetActive(true);
        } else if (Input.GetKeyDown(KeyCode.E) && onDoor && hasKey) {
            SceneManager.LoadScene("finalMB");
        } else if (Input.GetKeyDown(KeyCode.E) && onBreaker) {
            interactText.SetActive(false);
            breakerText.SetActive(true);
        }

        if (currentSlot == 1) {
            slot1.SetActive(true);
        } else if (currentSlot == 2) {
            slot2.SetActive(true);
        } else if (currentSlot == 3) {
            slot3.SetActive(true);
        } else if (currentSlot == 4) {
            slot4.SetActive(true);
            finished = true;
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "breaker" && !finished) {
            interactText.SetActive(true);
            collectFuses = true;
            onBreaker = true;
        } else if (other.tag == "fuse" && collectFuses) {
            currentFuse = other.gameObject;
            collectText.SetActive(true);
            onFuse = true;
        } else if (other.tag == "breaker" && finished) {
            interactText.SetActive(true);
            breakerText.SetActive(false);
            enabling = true;
        } else if (other.tag == "key") {
            Debug.Log("key box entered");
            collectKey.SetActive(true);
            onKey = true;
        } else if (other.tag == "Door") {
            interactText.SetActive(true);
            onDoor = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        collectText.SetActive(false);
        interactText.SetActive(false);
        doorText.SetActive(false);
        breakerText.SetActive(false);
        collectKey.SetActive(false);
        keyText.SetActive(false);
        onFuse = false;
        onKey = false;
        onDoor = false;
        onBreaker = false;
    }

    private void enableAll() {
        for (int i = 0; i < enable.Length; i++) {
            enable[i].SetActive(true);
        }
    }

    private void disableAll() {
        for (int i = 0; i < disable.Length; i++) {
            disable[i].SetActive(false);
        }
    }
}
