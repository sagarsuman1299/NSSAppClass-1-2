using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionCreator : MonoBehaviour
{
    public GameObject[] panels;
    public GameObject questionText;
    public GameObject answerText;
    public string[] attributes;

    int panelIndex;
    int optionIndex;                                   //0 is for lower attribute (eg thinner/smaller) and 1 is for larger attribute
    int attempt;
    
    
    void Start()
    {
        panelIndex = Random.Range(0, panels.Length);
        panels[panelIndex].SetActive(true);
        optionIndex = Random.Range(0, 2);

        SetQuestion(panelIndex, optionIndex);
    }

    void SetQuestion(int panelIndex, int optionIndex)
    {
        questionText.GetComponent<Text>().text = "Select the one which is " + attributes[(panelIndex % 4) * 2 + optionIndex] + " of the two: ";
        answerText.GetComponent<Text>().text = "";
        attempt = 0;
    }

    void ChooseNewPanel()
    {
        int temp;
        do
        {
            temp = Random.Range(0, panels.Length);
        } while (temp == panelIndex);
        panels[panelIndex].SetActive(false);
        panels[temp].SetActive(true);
        panelIndex = temp;

        optionIndex = Random.Range(0, 2);
        SetQuestion(panelIndex, optionIndex);
    }

    void Assess(int x)
    {
        if(x==optionIndex)
        {
            answerText.GetComponent<Text>().color = Color.green;
            answerText.GetComponent<Text>().text = "Correct!";
            Invoke("ChooseNewPanel", 1);
        }
        else
        {
            attempt++;
            int chance = 3 - attempt;
            answerText.GetComponent<Text>().color = Color.red;
            if (attempt == 3)
            {
                answerText.GetComponent<Text>().text = "Wrong Answer";
                Invoke("ChooseNewPanel", 1);
            }
            else
            {
                answerText.GetComponent<Text>().text = "Wrong, Try Again \n Attempts left: " + chance.ToString();
                Invoke("ClearText", 1);
            }
        }
    }

    public void High()
    {
        Assess(1);
    }

    public void Low()
    {
        Assess(0);
    }

    public void ClearText()
        {
            answerText.GetComponent<Text>().text = " ";
        }

    
}
