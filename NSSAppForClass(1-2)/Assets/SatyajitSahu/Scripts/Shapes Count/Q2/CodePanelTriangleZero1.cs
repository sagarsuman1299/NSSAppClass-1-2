using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodePanelTriangleZero1 : MonoBehaviour
{

    [SerializeField] Text codeText;
    string codeTextValue = "";

    TextPanelManger1 text;

    // Update is called once per frame
    void Update()
    {
        codeText.text = codeTextValue;

        if (codeTextValue == "13")
        {
            text = FindObjectOfType<TextPanelManger1>();
            text.Correct();
            Invoke("Tick", 1.0f);
        }

        if (codeTextValue != "13" && codeTextValue.Length == 2)
        {
            codeTextValue = "";
            text = FindObjectOfType<TextPanelManger1>();
            text.WrongActive();
            text = FindObjectOfType<TextPanelManger1>();
            text.TriangleWrong0();
            Invoke("Cross", 3.0f);
            Invoke("CW", 3.0f);
        }
    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }

    public void Tick()
    {
        text = FindObjectOfType<TextPanelManger1>();
        text.TriangleCorrect0();
    }

    public void Cross()
    {
        text = FindObjectOfType<TextPanelManger1>();
        text.WrongNotActive();
    }

    public void CW()
    {
        text = FindObjectOfType<TextPanelManger1>();
        text.TriangleWrongWrong0();
    }

}
