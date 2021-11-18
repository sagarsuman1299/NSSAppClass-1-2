using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShapeSelectorMaximum1 : MonoBehaviour
{

    [SerializeField] Text codeText;
    string codeTextValue = "";

    TextPanelManger1 text;

    // Update is called once per frame
    void Update()
    {
        codeText.text = codeTextValue;

        if (codeTextValue == "CIRCLE")
        {
            text = FindObjectOfType<TextPanelManger1>();
            text.MaximumCorrect();
            Invoke("Tick", 1.0f);
        }

        if (codeTextValue != "CIRCLE" && codeTextValue.Length >= 4)
        {
            codeTextValue = "";
            text = FindObjectOfType<TextPanelManger1>();
            text.WrongActive();
            text = FindObjectOfType<TextPanelManger1>();
            text.MaxWrong();
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
        text.MaxCorrect();
    }

    public void Cross()
    {
        text = FindObjectOfType<TextPanelManger1>();
        text.WrongNotActive();
    }
    public void CW()
    {
        text = FindObjectOfType<TextPanelManger1>();
        text.MaxWrongWrong();
    }
}
