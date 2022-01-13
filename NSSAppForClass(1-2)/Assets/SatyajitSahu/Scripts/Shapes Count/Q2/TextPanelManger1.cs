using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPanelManger1 : MonoBehaviour
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

    [Header("Button PanelsZero")]  //change3
    public GameObject circleButtonZero;
    public GameObject triangleButtonZero;
    public GameObject squareButtonZero;
    public GameObject rectangleButtonZero;  //

    [Header("Button PanelsOne")]  //change3
    public GameObject circleButtonOne;
    public GameObject triangleButtonOne;
    public GameObject squareButtonOne;
    public GameObject rectangleButtonOne;  //

    [Header("Fill In Panels")]
    public GameObject circleText;
    public GameObject triangleText;
    public GameObject squareText;
    public GameObject rectangleText;

    [Header("Fill In PanelsZero")]  //change3
    public GameObject circleTextZero;
    public GameObject triangleTextZero;
    public GameObject squareTextZero;
    public GameObject rectangleTextZero; //

    [Header("Fill In PanelsOne")]  //change3
    public GameObject circleTextOne;
    public GameObject triangleTextOne;
    public GameObject squareTextOne;
    public GameObject rectangleTextOne; //

    [Header("Correct Panels")]
    public GameObject circleCorrect;
    public GameObject triangleCorrect;
    public GameObject squareCorrect;
    public GameObject rectangleCorrect;

    [Header("Result Panels")]
    public GameObject correctPanel;
    public GameObject wrongPanel;

    public GameObject correctText;
    public GameObject wrongText;

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

    [Header("Buttons Next Question")]  //change2
    public GameObject circleNext;
    public GameObject triangleNext;
    public GameObject squareNext;
    public GameObject rectangleNext;

    [Header("Question Corrects")]  //change3
    public GameObject circleCorrectInQuestion;
    public GameObject triangleCorrectInQuestion;
    public GameObject squareCorrectInQuestion;
    public GameObject rectangleCorrectInQuestion;

    public void Correct()
    {
        correctPanel.SetActive(true);

        correctText.SetActive(true);  //c4
    }
    public void MaximumCorrect()
    {
        correctPanel.SetActive(true);
        maxPanel.SetActive(false);

        correctText.SetActive(true);  //c4
    }
    public void MinimumCorrect()
    {
        correctPanel.SetActive(true);
        minPanel.SetActive(false);

        correctText.SetActive(true);  //c4
    }
    public void WrongActive()
    {
        wrongPanel.SetActive(true);

        wrongText.SetActive(true);  //c4
    }
    public void WrongNotActive()
    {
        wrongPanel.SetActive(false);

        wrongText.SetActive(false);  //c4
    }

    public void CircleCorrect0()  //change3
    {
        correctPanel.SetActive(false);
        correctText.SetActive(false);  //c4
        circleButtonZero.SetActive(false);  //change3
        triangleButtonZero.SetActive(true);  //change3
        circleTextZero.SetActive(false);  //change3
        //circleCorrect.SetActive(true);  //c
        triangleTextZero.SetActive(true);  //change3
        circleQuestion.SetActive(false);
        triangleQuestion.SetActive(true);

        //circleTextZero.SetActive(false);  //change3
        //circleTextOne.SetActive(false);  //change3
    }
    public void CircleCorrect1()  //change3
    {
        correctPanel.SetActive(false);
        correctText.SetActive(false);  //c4
        circleButtonOne.SetActive(false);  //change 3
        triangleButtonZero.SetActive(true); //change3
        circleTextOne.SetActive(false);  //change3
        //circleCorrect.SetActive(true);  //c
        triangleTextZero.SetActive(true);  //change3
        circleQuestion.SetActive(false);
        triangleQuestion.SetActive(true);

        //circleTextZero.SetActive(false);  //change3
        //circleTextOne.SetActive(false);  //change3
    }
    public void CircleCorrect()
    {
        correctPanel.SetActive(false);
        correctText.SetActive(false);  //c4
        circleButton.SetActive(false);
        triangleButtonZero.SetActive(true);  //change3
        circleText.SetActive(false);
        //circleCorrect.SetActive(true);  //c
        triangleTextZero.SetActive(true);  //change3
        circleQuestion.SetActive(false);
        triangleQuestion.SetActive(true);

        //circleTextZero.SetActive(false);  //change3
        //circleTextOne.SetActive(false);  //change3
    }

    public void TriangleCorrect0()
    {
        correctPanel.SetActive(false);
        correctText.SetActive(false);  //c4
        triangleButtonZero.SetActive(false);
        squareButtonZero.SetActive(true);
        triangleTextZero.SetActive(false);
        //triangleCorrect.SetActive(true); //c
        squareTextZero.SetActive(true);
        triangleQuestion.SetActive(false);
        squareQuestion.SetActive(true);
    }
    public void TriangleCorrect1()
    {
        correctPanel.SetActive(false);
        correctText.SetActive(false);  //c4
        triangleButtonOne.SetActive(false);
        squareButtonZero.SetActive(true);
        triangleTextOne.SetActive(false);
        //triangleCorrect.SetActive(true); //c
        squareTextZero.SetActive(true);
        triangleQuestion.SetActive(false);
        squareQuestion.SetActive(true);
    }
    public void TriangleCorrect()
    {
        correctPanel.SetActive(false);
        correctText.SetActive(false);  //c4
        triangleButton.SetActive(false);
        squareButtonZero.SetActive(true);
        triangleText.SetActive(false);
        //triangleCorrect.SetActive(true); //c
        squareTextZero.SetActive(true);
        triangleQuestion.SetActive(false);
        squareQuestion.SetActive(true);
    }

    public void SquareCorrect0()
    {
        correctPanel.SetActive(false);
        correctText.SetActive(false);  //c4
        squareButtonZero.SetActive(false);
        rectangleButtonZero.SetActive(true);
        squareTextZero.SetActive(false);
        //squareCorrect.SetActive(true); //c
        rectangleTextZero.SetActive(true);
        squareQuestion.SetActive(false);
        rectangleQuestion.SetActive(true);
    }
    public void SquareCorrect1()
    {
        correctPanel.SetActive(false);
        correctText.SetActive(false);  //c4
        squareButtonOne.SetActive(false);
        rectangleButtonZero.SetActive(true);
        squareTextOne.SetActive(false);
        //squareCorrect.SetActive(true); //c
        rectangleTextZero.SetActive(true);
        squareQuestion.SetActive(false);
        rectangleQuestion.SetActive(true);
    }
    public void SquareCorrect()
    {
        correctPanel.SetActive(false);
        correctText.SetActive(false);  //c4
        squareButton.SetActive(false);
        rectangleButtonZero.SetActive(true);
        squareText.SetActive(false);
        //squareCorrect.SetActive(true); //c
        rectangleTextZero.SetActive(true);
        squareQuestion.SetActive(false);
        rectangleQuestion.SetActive(true);
    }

    public void RectangleCorrect0()
    {
        correctPanel.SetActive(false);
        correctText.SetActive(false);  //c4
        rectangleButtonZero.SetActive(false);
        maxPanel.SetActive(true);
        rectangleTextZero.SetActive(false);
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
    public void RectangleCorrect1()
    {
        correctPanel.SetActive(false);
        correctText.SetActive(false);  //c4
        rectangleButtonOne.SetActive(false);
        maxPanel.SetActive(true);
        rectangleTextOne.SetActive(false);
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
    public void RectangleCorrect()
    {
        correctPanel.SetActive(false);
        correctText.SetActive(false);  //c4
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
        correctText.SetActive(false);  //c4
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
        correctText.SetActive(false);  //c4
        minPanel.SetActive(false);
        minText.SetActive(false);
        correctMinText.SetActive(true);
    }

    public void CircleWrong0()  //change3
    {
        questionImageReal.SetActive(false);
        questionImageCircle.SetActive(true);
        circleButtonZero.SetActive(false);
        //circleNext.SetActive(true);  //change2

        //circleQuestion.SetActive(false); //change2
    }
    public void CircleWrong1()  //change3
    {
        questionImageReal.SetActive(false);
        questionImageCircle.SetActive(true);
        circleButtonOne.SetActive(false);
        //circleNext.SetActive(true);  //change2

        //circleQuestion.SetActive(false); //change2
    }
    public void CircleWrong()
    {
        questionImageReal.SetActive(false);
        questionImageCircle.SetActive(true);
        circleButton.SetActive(false);
        circleNext.SetActive(true);  //change2

        circleQuestion.SetActive(false); //change2

        circleCorrectInQuestion.SetActive(true);  //change3
        circleText.SetActive(false);  //change3
    }

    public void CircleWrongWrong0()  //change3
    {
        questionImageReal.SetActive(true);
        questionImageCircle.SetActive(false);
        circleButtonOne.SetActive(true);
        circleTextZero.SetActive(false);  //change3
        circleTextOne.SetActive(true);  //change3
        //circleNext.SetActive(false);  //change2
    }
    public void CircleWrongWrong1()  //change3
    {
        questionImageReal.SetActive(true);
        questionImageCircle.SetActive(false);
        circleButton.SetActive(true);
        circleTextOne.SetActive(false);  //change3
        circleText.SetActive(true);  //change3
        //circleNext.SetActive(false);  //change2
    }
    public void CircleWrongWrong()
    {
        questionImageReal.SetActive(true);
        questionImageCircle.SetActive(false);
        circleButton.SetActive(true);
        circleNext.SetActive(false);  //change2
    }

    public void TriangleWrong0()  //change3
    {
        questionImageReal.SetActive(false);
        questionImageTriangle.SetActive(true);
        triangleButtonZero.SetActive(false);
        //triangleNext.SetActive(true);  //change2

        //triangleQuestion.SetActive(false); //change2
    }
    public void TriangleWrong1()  //change3
    {
        questionImageReal.SetActive(false);
        questionImageTriangle.SetActive(true);
        triangleButtonOne.SetActive(false);
        //triangleNext.SetActive(true);  //change2

        //triangleQuestion.SetActive(false); //change2
    }
    public void TriangleWrong()
    {
        questionImageReal.SetActive(false);
        questionImageTriangle.SetActive(true);
        triangleButton.SetActive(false);
        triangleNext.SetActive(true);  //change2

        triangleQuestion.SetActive(false); //change2

        triangleCorrectInQuestion.SetActive(true);  //change3
        triangleText.SetActive(false);  //change3
    }

    public void TriangleWrongWrong0()
    {
        questionImageReal.SetActive(true);
        questionImageTriangle.SetActive(false);
        triangleButtonOne.SetActive(true);  //change3
        triangleTextZero.SetActive(false);  //change3
        triangleTextOne.SetActive(true);  //change3
        //triangleNext.SetActive(false);    //change2
    }
    public void TriangleWrongWrong1()
    {
        questionImageReal.SetActive(true);
        questionImageTriangle.SetActive(false);
        triangleButton.SetActive(true);
        triangleTextOne.SetActive(false);  //change3
        triangleText.SetActive(true);  //change3
        //triangleNext.SetActive(false);    //change2
    }
    public void TriangleWrongWrong()
    {
        questionImageReal.SetActive(true);
        questionImageTriangle.SetActive(false);
        triangleButton.SetActive(true);
        triangleNext.SetActive(false);    //change2
    }

    public void SquareWrong0()
    {
        questionImageReal.SetActive(false);
        questionImageSquare.SetActive(true);
        squareButtonZero.SetActive(false);
        //squareNext.SetActive(true);   //change2

        //squareQuestion.SetActive(false); //change2
    }
    public void SquareWrong1()
    {
        questionImageReal.SetActive(false);
        questionImageSquare.SetActive(true);
        squareButtonOne.SetActive(false);
        //squareNext.SetActive(true);   //change2

        //squareQuestion.SetActive(false); //change2
    }
    public void SquareWrong()
    {
        questionImageReal.SetActive(false);
        questionImageSquare.SetActive(true);
        squareButton.SetActive(false);
        squareNext.SetActive(true);   //change2

        squareQuestion.SetActive(false); //change2

        squareCorrectInQuestion.SetActive(true);  //change3
        squareText.SetActive(false);  //change3
    }

    public void SquareWrongWrong0()
    {
        questionImageReal.SetActive(true);
        questionImageSquare.SetActive(false);
        squareButtonOne.SetActive(true);
        squareTextZero.SetActive(false);  //change3
        squareTextOne.SetActive(true);  //change3
        //squareNext.SetActive(false);   //change2
    }
    public void SquareWrongWrong1()
    {
        questionImageReal.SetActive(true);
        questionImageSquare.SetActive(false);
        squareButton.SetActive(true);
        squareTextOne.SetActive(false);  //change3
        squareText.SetActive(true);  //change3
        //squareNext.SetActive(false);   //change2
    }
    public void SquareWrongWrong()
    {
        questionImageReal.SetActive(true);
        questionImageSquare.SetActive(false);
        squareButton.SetActive(true);
        squareNext.SetActive(false);   //change2
    }

    public void RectangleWrong0()
    {
        questionImageReal.SetActive(false);
        questionImageRectangle.SetActive(true);
        rectangleButtonZero.SetActive(false);
        //rectangleNext.SetActive(true);   //change2

        //rectangleQuestion.SetActive(false); //change2
    }
    public void RectangleWrong1()
    {
        questionImageReal.SetActive(false);
        questionImageRectangle.SetActive(true);
        rectangleButtonOne.SetActive(false);
        //rectangleNext.SetActive(true);   //change2

        //rectangleQuestion.SetActive(false); //change2
    }
    public void RectangleWrong()
    {
        questionImageReal.SetActive(false);
        questionImageRectangle.SetActive(true);
        rectangleButton.SetActive(false);
        rectangleNext.SetActive(true);   //change2

        rectangleQuestion.SetActive(false); //change2

        rectangleCorrectInQuestion.SetActive(true);  //change3
        rectangleText.SetActive(false);  //change3
    }

    public void RectangleWrongWrong0()
    {
        questionImageReal.SetActive(true);
        questionImageRectangle.SetActive(false);
        rectangleButtonOne.SetActive(true);
        rectangleTextZero.SetActive(false);  //change3
        rectangleTextOne.SetActive(true);  //change3
        //rectangleNext.SetActive(false);  //change2
    }
    public void RectangleWrongWrong1()
    {
        questionImageReal.SetActive(true);
        questionImageRectangle.SetActive(false);
        rectangleButton.SetActive(true);
        rectangleTextOne.SetActive(false);  //change3
        rectangleText.SetActive(true);  //change3
        //rectangleNext.SetActive(false);  //change2
    }
    public void RectangleWrongWrong()
    {
        questionImageReal.SetActive(true);
        questionImageRectangle.SetActive(false);
        rectangleButton.SetActive(true);
        rectangleNext.SetActive(false);  //change2
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

    public void circleNextQuestion()  //change2
    {
        wrongPanel.SetActive(false);
        triangleButtonZero.SetActive(true);  //change3
        circleText.SetActive(false);
        triangleTextZero.SetActive(true);  //change3
        circleQuestion.SetActive(false);
        triangleQuestion.SetActive(true);
        circleNext.SetActive(false);
        questionImageCircle.SetActive(false);
        questionImageReal.SetActive(true);

        circleCorrectInQuestion.SetActive(false);  //change3
    }
    public void triangleNextQuestion()  //change2
    {
        wrongPanel.SetActive(false);
        squareButtonZero.SetActive(true);
        triangleText.SetActive(false);
        squareTextZero.SetActive(true);
        triangleQuestion.SetActive(false);
        squareQuestion.SetActive(true);
        triangleNext.SetActive(false);
        questionImageTriangle.SetActive(false);
        questionImageReal.SetActive(true);

        triangleCorrectInQuestion.SetActive(false);  //change3
    }
    public void squareNextQuestion()   //change2
    {
        wrongPanel.SetActive(false);
        rectangleButtonZero.SetActive(true);
        squareText.SetActive(false);
        rectangleTextZero.SetActive(true);
        squareQuestion.SetActive(false);
        rectangleQuestion.SetActive(true);
        squareNext.SetActive(false);
        questionImageSquare.SetActive(false);
        questionImageReal.SetActive(true);

        squareCorrectInQuestion.SetActive(false);  //change3
    }
    public void rectangleNextQuestion()   //change2
    {
        wrongPanel.SetActive(false);
        maxPanel.SetActive(true);
        rectangleText.SetActive(false);
        circleCorrect.SetActive(true);
        triangleCorrect.SetActive(true);
        squareCorrect.SetActive(true);
        rectangleCorrect.SetActive(true);
        maxMinText.SetActive(true);
        rectangleQuestion.SetActive(false);
        maxQuestion.SetActive(true);
        rectangleNext.SetActive(false);

        questionImageRectangle.SetActive(false);

        rectangleCorrectInQuestion.SetActive(false);  //change3
    }
}
