using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodePanelRectangle : MonoBehaviour
{

    [SerializeField] Text codeText;
    string codeTextValue = "";

    TextPanelManger text;

    // Update is called once per frame
    void Update()
    {
        codeText.text = codeTextValue;

        if (codeTextValue == "7")
        {
            text = FindObjectOfType<TextPanelManger>();
            text.Correct();
            Invoke("Tick", 1.0f);
        }

        if (codeTextValue != "7" && codeTextValue.Length == 1)
        {
            codeTextValue = "";
            text = FindObjectOfType<TextPanelManger>();
            text.WrongActive();
            text = FindObjectOfType<TextPanelManger>();
            text.RectangleWrong();
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
        text = FindObjectOfType<TextPanelManger>();
        text.RectangleCorrect();
    }

    public void Cross()
    {
        text = FindObjectOfType<TextPanelManger>();
        text.WrongNotActive();
    }

    public void CW()
    {
        text = FindObjectOfType<TextPanelManger>();
        text.RectangleWrongWrong();
    }
}
