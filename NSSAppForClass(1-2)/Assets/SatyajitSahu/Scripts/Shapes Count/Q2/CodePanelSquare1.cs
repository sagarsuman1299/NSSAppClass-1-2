using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodePanelSquare1 : MonoBehaviour
{

    [SerializeField] Text codeText;
    string codeTextValue = "";

    TextPanelManger1 text;

    // Update is called once per frame
    void Update()
    {
        codeText.text = codeTextValue;

        if (codeTextValue == "6")
        {
            text = FindObjectOfType<TextPanelManger1>();
            text.Correct();
            Invoke("Tick", 1.0f);
        }

        if (codeTextValue != "6" && codeTextValue.Length == 1)
        {
            codeTextValue = "";
            text = FindObjectOfType<TextPanelManger1>();
            text.WrongActive();
            text = FindObjectOfType<TextPanelManger1>();
            text.SquareWrong();
            //Invoke("Cross", 8.0f);
            //Invoke("CW", 8.0f);
        }
    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }

    public void Tick()
    {
        text = FindObjectOfType<TextPanelManger1>();
        text.SquareCorrect();
    }

    public void Cross()
    {
        text = FindObjectOfType<TextPanelManger1>();
        text.WrongNotActive();
    }

    public void CW()
    {
        text = FindObjectOfType<TextPanelManger1>();
        text.SquareWrongWrong();
    }
}
