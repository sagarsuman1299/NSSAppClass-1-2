using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionMaker : MonoBehaviour
{
    public GameObject Question;
    public GameObject Answer;
    public Button ButtonA;
    public Button ButtonB;
    public Text TextA;
    public Text TextB;

    [System.Serializable]
    public class QuestionStats
    {
        public string ActionA;
        public Sprite SpriteA;
        public string ActionB;
        public Sprite SpriteB;
    }

    public QuestionStats[] Stats;

    int QuestionIndex;
    int ChoiceIndex;




    void OnEnable()
    {
        QuestionIndex = -1;
        SetQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetQuestion()
    {
        Answer.GetComponent<Text>().text = " ";


        int temp;
        do
        {
            temp = Random.Range(0, Stats.Length);
        } while (temp == QuestionIndex);
        QuestionIndex = temp;
        ChoiceIndex = Random.Range(0, 2);

        Question.GetComponent<Text>().text = "Which of these actions ";
        if (ChoiceIndex == 0)
            Question.GetComponent<Text>().text += "should you ";
        else
            Question.GetComponent<Text>().text += "should you not ";
        Question.GetComponent<Text>().text += "do?";


        ButtonA.image.sprite = Stats[QuestionIndex].SpriteA;
        TextA.text = Stats[QuestionIndex].ActionA;
        ButtonB.image.sprite = Stats[QuestionIndex].SpriteB;
        TextB.text = Stats[QuestionIndex].ActionB;
    }

    public void OnClickButtonA()
    {
        Assess(0);
    }

    public void OnClickButtonB()
    {
        Assess(1);
    }

    void Assess(int x)
    {
        if (x == ChoiceIndex)
            Answer.GetComponent<Text>().text = "Right!";
        else
            Answer.GetComponent<Text>().text = "Wrong";

        Invoke("SetQuestion", 1.5f);
    }
}
