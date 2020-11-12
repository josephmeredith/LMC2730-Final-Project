using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class demoDoor : MonoBehaviour
{
    public Text instructions;

    void Start() {
        instructions.text = "Press E to interact.";
        instructions.enabled = false;
    }

    void update() {
        if(CrossPlatformInputManager.GetButtonDown("Use")) {
            // if (Input.GetKeyDown("E")) {
                instructions.text = "The door is locked. I need to find another way out.";
            }
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "doorMayar")
        {
            // instructions.text = "Press E to interact.";
            instructions.enabled = true;
            // if(CrossPlatformInputManager.GetButtonDown("Use")) {
            // // if (Input.getKeyDown("e")) {
            //     instructions.text = "The door is locked. I need to find another way out.";
            // }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "doorMayar")
        {
            // instructions.text = "";  
            instructions.enabled = false;      
        }
    }
}
