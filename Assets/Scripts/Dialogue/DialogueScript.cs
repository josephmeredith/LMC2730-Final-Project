using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueScript : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public GameObject text;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;
    public KeyCode key;
    private Button button;


    private void Awake()
    {
        button = GetComponent<Button>();

    }

    private void Update()
    {
        if (Input.GetKeyDown(key))
        {
            FadetoColor(button.colors.pressedColor);
            button.onClick.Invoke();
        }
        else if (Input.GetKeyUp(key))
        {
            FadetoColor(button.colors.normalColor);
        }
        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }

    void FadetoColor(Color color)
    {
        Graphic graphic = GetComponent<Graphic>();
        graphic.CrossFadeColor(color, button.colors.fadeDuration, true, true);
    }
    private void Start()
    {
        StartCoroutine(Type()); 
    }

    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
    public void NextSentence()
    {
        continueButton.SetActive(false);

        if (index < sentences.Length - 1) {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        } else {
            textDisplay.text = "";

        }
    }
}
