using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;





public class QuestionMaster : MonoBehaviour
{
    [System.Serializable]
    public class Questiontype
    {
        public string attributeA;
        public Sprite imageA;
        public string attributeB;
        public Sprite imageB;
    }

    public GameObject Question;
    public GameObject Answer;
    public Button ButtonA;
    public Button ButtonB;
    public Questiontype[] data;


    int QuestionIndex;
    int ChoiceIndex;



    // Start is called before the first frame update
    void OnEnable()
    {
        QuestionIndex = -1;
        SetQuestion();

    }

    void SetQuestion()
    {
        Answer.GetComponent<Text>().text = " ";


        int temp;        
        do
        {
            temp = Random.Range(0, data.Length);
        } while (temp == QuestionIndex);
        QuestionIndex = temp;
        ChoiceIndex = Random.Range(0, 2);

        Question.GetComponent<Text>().text = "Select the one who is ";
        if (ChoiceIndex == 0)
            Question.GetComponent<Text>().text += data[QuestionIndex].attributeA;
        else
            Question.GetComponent<Text>().text += data[QuestionIndex].attributeB;


        ButtonA.image.sprite = data[QuestionIndex].imageA;
        ButtonB.image.sprite = data[QuestionIndex].imageB;
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
        if(x==ChoiceIndex)
            Answer.GetComponent<Text>().text = "Right!";
        else
            Answer.GetComponent<Text>().text = "Wrong";

        Invoke("SetQuestion", 1.5f);
    }
}
