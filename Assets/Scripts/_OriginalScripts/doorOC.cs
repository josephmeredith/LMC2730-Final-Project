using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOC : MonoBehaviour
{
    public GameObject instructions;
    private Animator anim;
    private bool onDoor = false;

  private void Update() {
      if (Input.GetKeyDown(KeyCode.E) && onDoor) {
          anim.SetTrigger("OpenClose");
      }
  }
    private void OnTriggerStay(Collider other)
    {
      if (other.tag == "doorMayar")
      {
          instructions.SetActive(true);
          anim = other.GetComponentInChildren<Animator>();
          onDoor = true;
          // if (Input.GetKeyDown(KeyCode.E)) {
          //       anim.SetTrigger("OpenClose");
          // }
      }
    }

    private void OnTriggerExit(Collider other)
    {
       if (other.tag == "doorMayar")
       {
             instructions.SetActive(false);
             onDoor = false;
       }
    }
}
