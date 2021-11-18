using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPanelManger : MonoBehaviour
{
    [Header("Solution Images")]
    public GameObject questionImageReal;
    public GameObject questionImageCircle;
    public GameObject questionImageTriangle;
    public GameObject questionImageSquare;
    public GameObject questionImageRectangle;

    [Header("Questions")]
    public GameObject circleQuestion;
    public GameObject triangleQuestion;
    public GameObject squareQuestion;
    public GameObject rectangleQuestion;

    [Header("Button Panels")]
    public GameObject circleButton;
    public GameObject triangleButton;
    public GameObject squareButton;
    public GameObject rectangleButton;

    [Header("Fill In Panels")]
    public GameObject circleText;
    public GameObject triangleText;
    public GameObject squareText;
    public GameObject rectangleText;

    [Header("Correct Panels")]
    public GameObject circleCorrect;
    public GameObject triangleCorrect;
    public GameObject squareCorrect;
    public GameObject rectangleCorrect;

    [Header("Result Panels")]
    public GameObject correctPanel;
    public GameObject wrongPanel;

    [Header("MaxMin Panels")]
    public GameObject maxPanel;
    public GameObject minPanel;

    [Header("MaxMin Text")]
    public GameObject maxText;
    public GameObject minText;

    [Header("Correct MaxMin Text")]
    public GameObject maxMinText;
    public GameObject correctMaxText;
    public GameObject correctMinText;

    [Header("MaxMin Questions")]
    public GameObject maxQuestion;
    public GameObject minQuestion;

    QuestionChanger q;

    public void Correct()
    {
        correctPanel.SetActive(true);
    }
    public void MaximumCorrect()
    {
        correctPanel.SetActive(true);
        maxPanel.SetActive(false);
    }
    public void MinimumCorrect()
    {
        correctPanel.SetActive(true);
        minPanel.SetActive(false);
    }
    public void WrongActive()
    {
        wrongPanel.SetActive(true);
    }
    public void WrongNotActive()
    {
        wrongPanel.SetActive(false);
    }

    public void CircleCorrect()
    {
        correctPanel.SetActive(false);
        circleButton.SetActive(false);
        triangleButton.SetActive(true);
        circleText.SetActive(false);
        //circleCorrect.SetActive(true);  //c
        triangleText.SetActive(true);
        circleQuestion.SetActive(false);
        triangleQuestion.SetActive(true);
    }

    public void TriangleCorrect()
    {
        correctPanel.SetActive(false);
        triangleButton.SetActive(false);
        squareButton.SetActive(true);
        triangleText.SetActive(false);
        //triangleCorrect.SetActive(true); //c
        squareText.SetActive(true);
        triangleQuestion.SetActive(false);
        squareQuestion.SetActive(true);
    }

    public void SquareCorrect()
    {
        correctPanel.SetActive(false);
        squareButton.SetActive(false);
        rectangleButton.SetActive(true);
        squareText.SetActive(false);
        //squareCorrect.SetActive(true); //c
        rectangleText.SetActive(true);
        squareQuestion.SetActive(false);
        rectangleQuestion.SetActive(true);
    }

    public void RectangleCorrect()
    {
        correctPanel.SetActive(false);
        rectangleButton.SetActive(false);
        maxPanel.SetActive(true);
        rectangleText.SetActive(false);
        circleCorrect.SetActive(true);
        triangleCorrect.SetActive(true);
        squareCorrect.SetActive(true);
        rectangleCorrect.SetActive(true);
        //rectangleText.SetActive(true);
        maxMinText.SetActive(true);
        rectangleQuestion.SetActive(false);
        maxQuestion.SetActive(true);
        questionImageReal.SetActive(false);
    }

    public void MaxCorrect()
    {
        correctPanel.SetActive(false);
        //maxPanel.SetActive(false);
        minPanel.SetActive(true);
        maxText.SetActive(false);
        correctMaxText.SetActive(true);
        minText.SetActive(true);
        maxQuestion.SetActive(false);
        minQuestion.SetActive(true);
    }

    public void MinCorrect()
    {
        correctPanel.SetActive(false);
        minPanel.SetActive(false);
        minText.SetActive(false);
        correctMinText.SetActive(true);
        QuestionChange();
    }

    public void QuestionChange()
    {
        q = FindObjectOfType<QuestionChanger>();
        q.QChange();
    }

    public void CircleWrong()
    {
        questionImageReal.SetActive(false);
        questionImageCircle.SetActive(true);
        circleButton.SetActive(false);
    }
    public void CircleWrongWrong()
    {
        questionImageReal.SetActive(true);
        questionImageCircle.SetActive(false);
        circleButton.SetActive(true);
    }

    public void TriangleWrong()
    {
        questionImageReal.SetActive(false);
        questionImageTriangle.SetActive(true);
        triangleButton.SetActive(false);
    }
    public void TriangleWrongWrong()
    {
        questionImageReal.SetActive(true);
        questionImageTriangle.SetActive(false);
        triangleButton.SetActive(true);
    }

    public void SquareWrong()
    {
        questionImageReal.SetActive(false);
        questionImageSquare.SetActive(true);
        squareButton.SetActive(false);
    }
    public void SquareWrongWrong()
    {
        questionImageReal.SetActive(true);
        questionImageSquare.SetActive(false);
        squareButton.SetActive(true);
    }

    public void RectangleWrong()
    {
        questionImageReal.SetActive(false);
        questionImageRectangle.SetActive(true);
        rectangleButton.SetActive(false);
    }
    public void RectangleWrongWrong()
    {
        questionImageReal.SetActive(true);
        questionImageRectangle.SetActive(false);
        rectangleButton.SetActive(true);
    }

    public void MaxWrong()
    {
        maxPanel.SetActive(false);
    }
    public void MaxWrongWrong()
    {
        maxPanel.SetActive(true);
    }
    public void MinWrong()
    {
        minPanel.SetActive(false);
    }
    public void MinWrongWrong()
    {
        minPanel.SetActive(true);
    }
}
