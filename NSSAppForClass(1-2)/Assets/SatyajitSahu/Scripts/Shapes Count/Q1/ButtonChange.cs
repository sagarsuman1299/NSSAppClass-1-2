using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonChange : MonoBehaviour
{
    TextPanelManger text;

    public void circleChange()
    {
        text = FindObjectOfType<TextPanelManger>();
        text.circleNextQuestion();
    }

    public void triangleChange()
    {
        text = FindObjectOfType<TextPanelManger>();
        text.triangleNextQuestion();
    }

    public void squareChange()
    {
        text = FindObjectOfType<TextPanelManger>();
        text.squareNextQuestion();
    }

    public void rectangleChange()
    {
        text = FindObjectOfType<TextPanelManger>();
        text.rectangleNextQuestion();
    }
}
