using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QuestionAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject correctPanel;
    public GameObject wrongPanel;

    public GameObject qImage;

    public GameObject allDone;

    public GameObject button;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;

    public GameObject Quizpanel;
    public GameObject questionText;

    public Image QuestionTxt;  

    int totalQuestions = 0;

    private void Start()
    {
        totalQuestions = QnA.Count;
        generateQuestion();
    }

    void GameOver()
    {
        Quizpanel.SetActive(false);
        questionText.SetActive(false);
        allDone.SetActive(true);
    }

    public void correct()
    {
        QnA.RemoveAt(currentQuestion);

        button.SetActive(false);
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);

        StartCoroutine(waitForNext());
    }

    IEnumerator waitForNext()
    {
        yield return new WaitForSeconds(2);

        button.SetActive(true);
        button1.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);

        correctPanel.SetActive(false);
        generateQuestion();

        qImage.SetActive(true);
    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];
            
            if(QnA[currentQuestion].CorrectAnswer == i+1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {
        if(QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);

            QuestionTxt.GetComponent<Image>().sprite = QnA[currentQuestion].Question; 
            SetAnswers();
        }
        else
        {
            Debug.Log("Out of Questions");
            GameOver();
        }


    }
}
