using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonChange1 : MonoBehaviour
{
    TextPanelManger1 text;

    public void circleChange()
    {
        text = FindObjectOfType<TextPanelManger1>();
        text.circleNextQuestion();
    }

    public void triangleChange()
    {
        text = FindObjectOfType<TextPanelManger1>();
        text.triangleNextQuestion();
    }

    public void squareChange()
    {
        text = FindObjectOfType<TextPanelManger1>();
        text.squareNextQuestion();
    }

    public void rectangleChange()
    {
        text = FindObjectOfType<TextPanelManger1>();
        text.rectangleNextQuestion();
    }
}
