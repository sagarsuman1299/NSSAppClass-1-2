using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddSubtract : MonoBehaviour
{
    private int i=0,j=0;
    public Text[]  QuesText ;
    public Text changetext;
    public Text AnswerCheck;

    // Start is called before the first frame update
    void Start()
    {
        QuesText[3].text = "=" ;
        Ques1();
    }
    private void Ques1()
    {
        j = 1;
        QuesText[1].text = "+";
        QuesText[2].text = "_";
        QuesText[4].text = Random.Range(1,10).ToString();
        QuesText[0].text = Random.Range(1, int.Parse(QuesText[4].text)).ToString();
        if(QuesText[4].text == QuesText[0].text)
        {
            QuesText[4].text = (int.Parse(QuesText[4].text) +1).ToString();
        }
        ////////////
        
    }
    private void Ques2()
    {
        j = 2;
        QuesText[1].text = "-";
        QuesText[2].text = "_";
        QuesText[0].text = Random.Range(1, 10).ToString();
        QuesText[4].text = Random.Range(1, int.Parse(QuesText[0].text)).ToString();
        if (QuesText[0].text == QuesText[4].text)
        {
            QuesText[0].text = (int.Parse(QuesText[0].text) + 1).ToString();
        }
        ////////////

    }

    // Update is called once per frame

    public void TextChangeTo1()
    {
        i = 1;
        numberFunction();       
    }
    public void TextChangeTo2()
    {
        //changetext.text = "2";
        i = 2;
        numberFunction();
    }
    public void TextChangeTo3()
    {
        i = 3;
        numberFunction();
    }
    public void TextChangeTo4()
    {
        i = 4;
        numberFunction();
    }
    public void TextChangeTo5()
    {
        i = 5;
        numberFunction();
    }
    public void TextChangeTo6()
    {
        i = 6;
        numberFunction();
    }
    public void TextChangeTo7()
    {
        i = 7;
        numberFunction();
    }
    public void TextChangeTo8()
    {
        i = 8;
        numberFunction();
    }
    public void TextChangeTo9()
    {
        i = 9;
        numberFunction();
    }
    void numberFunction()
    {
        if (j == 1)
        {
            if ((int.Parse(QuesText[4].text) - int.Parse(QuesText[0].text)) == i)
            {
                QuesText[2].text = i.ToString();
                AnswerCheck.text = "Correct";
                StartCoroutine(WaitForTime());

            }
            else
            {
                QuesText[2].text = i.ToString();
                AnswerCheck.text = "Incorrect";
                StartCoroutine(WaitForTime());
            }
        }
        if (j == 2)
        {
            if ((int.Parse(QuesText[0].text) - int.Parse(QuesText[4].text)) == i)
            {
                QuesText[2].text = i.ToString();
                AnswerCheck.text = "Correct";
                StartCoroutine(WaitForTime());

            }
            else
            {
                QuesText[2].text = i.ToString();
                AnswerCheck.text = "Incorrect";
                StartCoroutine(WaitForTime());
            }
        }

    }
    public IEnumerator WaitForTime()
    {
        if (j == 1) { 
        yield return new WaitForSeconds(2);
        if ((int.Parse(QuesText[4].text) - int.Parse(QuesText[0].text)) == i)
        {
            AnswerCheck.text = "Fill in the blanks";
            Ques2();
        }
        else
        {
            QuesText[2].text = "_";
            AnswerCheck.text = "Fill in the blanks";
        }
        }

        if (j == 2)
        {
            yield return new WaitForSeconds(2);
            if ((int.Parse(QuesText[0].text) - int.Parse(QuesText[4].text)) == i)
            {
                AnswerCheck.text = "Fill in the blanks";
                Ques1();
            }
            else
            {
                QuesText[2].text = "_";
                AnswerCheck.text = "Fill in the blanks";
            }
        }
    }

   
}
