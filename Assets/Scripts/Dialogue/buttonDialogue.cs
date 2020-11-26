using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class buttonDialogue : MonoBehaviour
{
    //public KeyCode key;
    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();

    }
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            FadetoColor(button.colors.pressedColor);
            button.onClick.Invoke();
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            FadetoColor(button.colors.normalColor);
        }
    }

    void FadetoColor(Color color)
    {
        Graphic graphic = GetComponent<Graphic>();
        graphic.CrossFadeColor(color, button.colors.fadeDuration, true, true);
    }
}
