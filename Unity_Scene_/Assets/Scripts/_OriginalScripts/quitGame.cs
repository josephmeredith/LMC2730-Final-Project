using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitGame : MonoBehaviour
{
 public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("has quit game");
            Application.Quit();
        }
    }
}
