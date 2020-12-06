using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuseCollection : MonoBehaviour
{
    public GameObject collectText;
    private bool onFuse = false;
    private bool collectFuses = false;
    private bool finished = false;
    public GameObject currentFuse;
    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;
    private int currentSlot = 0;

    public GameObject breakerText;
    void Start()
    {
        collectText.SetActive(false);
        slot1.SetActive(false);
        slot2.SetActive(false);
        slot3.SetActive(false);
        slot4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && onFuse) {
            currentFuse.SetActive(false);
            collectText.SetActive(false);
            currentSlot++;
            onFuse = false;
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

    private void OnTriggerStay(Collider other) {
        if (other.tag == "breaker" && !finished) {
            collectFuses = true;
            Debug.Log("collectFuses = true");
        } else if (other.tag == "fuse" && collectFuses) {
            currentFuse = other.gameObject;
            collectText.SetActive(true);
            onFuse = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        collectText.SetActive(false);
        onFuse = false;
    }
}
