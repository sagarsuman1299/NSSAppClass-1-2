using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pencil : MonoBehaviour
{
    public GameObject[] pencils1;
    public GameObject[] pencils2;
    int a, b, i;
    public int questionNo;
    public Text ans;
    public Text question;
    private int wrongCount = 1;

    void Start()
    {

        a = Random.Range(1, 10);
        b = Random.Range(0, a);
        if (questionNo == 1)
        {
            question.text = "Gaurav has " + (a + 1) + " pencils. Akbar has " + (b + 1) + " pencils.";
        }
        else if (questionNo == 2)
        {
            question.text = "Gaurav has " + (a + 1) + " pencils. Akbar has " + (b + 1) + " pencils.";
        }
        for (int i = 0; i <= a; i++)
        {
            pencils1[i].SetActive(true);
        }
        for (int i = 0; i <= b; i++)
        {
            pencils2[i].SetActive(true);
        }
    }
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
        if (a - b == i)
        {
            ans.text = "CORRECT";

            StartCoroutine(delay());

        }
        else
        {
            if (wrongCount == 3)
            {
                ans.text = "Correct Answer is : " + (a - b);
                wrongCount = 1;
                StartCoroutine(delay());

            }
            else
            {
                wrongCount++;
                ans.text = "INCORRECT";
                StartCoroutine(Wrongdelay());
            }
        }
    }
    public void pencilgenerate()
    {
        wrongCount = 1;
        a = Random.Range(1, 10);
        b = Random.Range(0, a);
        if (questionNo == 1)
        {
            question.text = "Gaurav has " + (a + 1) + " pencils. Akbar has " + (b + 1) + " pencils.";
        }
        else if (questionNo == 2)
        {
            question.text = "Gaurav has " + (a + 1) + " pencils. Akbar has " + (b + 1) + " pencils.";
        }
        for (int i = 0; i <= a; i++)
        {
            pencils1[i].SetActive(true);
        }
        for (int i = 0; i <= b; i++)
        {
            pencils2[i].SetActive(true);
        }
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(2);
        for (int i = 0; i <= a; i++)
        {
            pencils1[i].SetActive(false);
        }
        for (int i = 0; i <= b; i++)
        {
            pencils2[i].SetActive(false);
        }
        ans.text = "";
        pencilgenerate();
    }
    IEnumerator Wrongdelay()
    {
        yield return new WaitForSeconds(1);

        ans.text = "";

    }
}

