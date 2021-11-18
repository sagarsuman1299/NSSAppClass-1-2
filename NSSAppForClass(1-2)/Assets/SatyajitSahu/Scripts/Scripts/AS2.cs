using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AS2 : MonoBehaviour
{
    public bool isCorrect = false;
    public QM2 quizManager;

    public GameObject button;
    public GameObject button1;

    public GameObject tick;
    public GameObject cross;

    public GameObject qImage;

    public GameObject correctPanel;
    public GameObject wrongPanel;

    public void Answer()
    {
        if (isCorrect)
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

            tick.SetActive(false);
            cross.SetActive(false);

            Invoke("WrongCorrect", 3.0f);

            qImage.SetActive(false);
        }
    }

    public void WrongCorrect()
    {
        wrongPanel.SetActive(false);

        button.SetActive(true);
        button1.SetActive(true);

        tick.SetActive(true);
        cross.SetActive(true);

        qImage.SetActive(true);
    }
}
