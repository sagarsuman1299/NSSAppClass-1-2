using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShapeSelectorMinimum1 : MonoBehaviour
{

    [SerializeField] Text codeText;
    string codeTextValue = "";

    TextPanelManger1 text;

    // Update is called once per frame
    void Update()
    {
        codeText.text = codeTextValue;

        if (codeTextValue == "SQUARE")
        {
            text = FindObjectOfType<TextPanelManger1>();
            text.MinimumCorrect();
            Invoke("Tick", 1.0f);
        }

        if (codeTextValue != "SQUARE" && codeTextValue.Length >= 4)
        {
            codeTextValue = "";
            text = FindObjectOfType<TextPanelManger1>();
            text = FindObjectOfType<TextPanelManger1>();
            text.MinWrong();
            text.WrongActive();
            Invoke("Cross", 1.0f);
            Invoke("CW", 1.0f);
        }
    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }

    public void Tick()
    {
        text = FindObjectOfType<TextPanelManger1>();
        text.MinCorrect();
    }

    public void Cross()
    {
        text = FindObjectOfType<TextPanelManger1>();
        text.WrongNotActive();
    }
    public void CW()
    {
        text = FindObjectOfType<TextPanelManger1>();
        text.MinWrongWrong();
    }
}
