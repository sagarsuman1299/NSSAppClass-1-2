using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;

    public GameObject button;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;

    public GameObject qImage;

    public GameObject correctPanel;
    public GameObject wrongPanel;

    public void Answer()
    {
        if(isCorrect)
        {
            Debug.Log("Correct Answer");
            quizManager.correct();
            correctPanel.SetActive(true);

            qImage.SetActive(false);
        }
        else
        {
            Debug.Log("Wrong Answer");
            wrongPanel.SetActive(true);

            button.SetActive(false);
            button1.SetActive(false);
            button2.SetActive(false);
            button3.SetActive(false);
            Invoke("WrongCorrect", 3.0f);

            qImage.SetActive(false);
        }
    }

    public void WrongCorrect()
    {
        wrongPanel.SetActive(false);

        button.SetActive(true);
        button1.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);

        qImage.SetActive(true);
    }

}
