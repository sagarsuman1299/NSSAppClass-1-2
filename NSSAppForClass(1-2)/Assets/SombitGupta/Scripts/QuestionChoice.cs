using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionChoice : MonoBehaviour
{
    public GameObject[] panels;
    public GameObject questionText;
    public GameObject answerText;
    public Sprite[] sprites;

    int panelIndex;
    int distIndex;                             //0 indicates nearer/nearest, and 1 indicates farther/farthest

    void Start()
    {
        panelIndex = Random.Range(0, panels.Length);                 //select which panel(question) to show
        panels[panelIndex].SetActive(true);                          //activates the question
        distIndex = Random.Range(0, 2);

        SetQuestion(panelIndex, distIndex);                          //sets the question

        

        
    }

    void AssessAnswer(int i)                                         //Assesses the question based on input by user. 
    {
        if(i==distIndex)
        {
            answerText.GetComponent<Text>().text = "Correct!";
            Invoke("ChooseNewPanel", 1);
        }
        else
            answerText.GetComponent<Text>().text = "Wrong";
    }

    public void Near()                                                  //called when biggest button is pressed
    {
        AssessAnswer(0);
    }
    public void Far()                                                   //called when smallest button is pressed
    {
        AssessAnswer(1);
    }
    public void Middle()
    {
        AssessAnswer(2);
    }


    void SetQuestion(int panelIndex, int distIndex)
    {
        Button[] buttons = panels[panelIndex].GetComponentsInChildren<Button>();
        for(int i=0; i<buttons.Length; i++)
        {
            buttons[i].image.sprite = sprites[Random.Range(0, sprites.Length)];
        }

        
        
        
        
        questionText.GetComponent<Text>().text = "Select the ";
        if (panelIndex > 1)
        {
            if (distIndex == 0)
                questionText.GetComponent<Text>().text += "nearest ";
            else
                questionText.GetComponent<Text>().text += "farthest ";
        }
        else
        {
            if (distIndex == 0)
                questionText.GetComponent<Text>().text += "nearer ";
            else
                questionText.GetComponent<Text>().text += "farther ";
        }
        questionText.GetComponent<Text>().text += "animal.";

        answerText.GetComponent<Text>().text = "";                   //defaults answer textbox to empty space
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

        distIndex = Random.Range(0, 2);
        SetQuestion(panelIndex, distIndex);

    }
}
