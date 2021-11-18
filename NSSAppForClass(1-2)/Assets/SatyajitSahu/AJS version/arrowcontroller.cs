using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arrowcontroller : MonoBehaviour
{
    public GameObject[] arrows;
    public GameObject quiz,done;
    int a, b, i;
    public Text b1, b2, b3, b4, correct;

    void Start()
    {
        a = 0;
        Q1();
    }
    public void Buttonclick1()
    {
        if (a == 0)
        {
            a++;
            correct.text = "Correct";
            Invoke("Q2", 1);
            
        }

        else if (a == 5)
        {
            a++;
            correct.text = "Correct";
            Invoke("Q7", 1);

        }

        else
        {
            correct.text = "Wrong";
            Invoke("wrong", 1);
        }
    }
    public void Buttonclick2()
    {
        if (a == 3)
        {
            a++;
            correct.text = "Correct";
            Invoke("Q5",1);

        }

        else
        {
            correct.text = "Wrong";
            Invoke("wrong", 1);
        }
    }
    public void Buttonclick3()
    {
        if (a == 1)
        {
            a++;
            correct.text = "Correct";
            Invoke("Q3", 1);

        }
        else if (a == 6)
        {
            a++;
            correct.text = "Correct";
            Invoke("alldone", 1);

        }
        else
        {
            correct.text = "Wrong";
            Invoke("wrong", 1);
        }
    }
    public void Buttonclick4()
    {
        if (a == 2)
        {
            a++;
            correct.text = "Correct";
            Invoke("Q4", 1);

        }

        else if (a == 4)
        {
            a++;
            correct.text = "Correct";
            Invoke("Q6", 1);

        }

        else
        {
            correct.text = "Wrong";
            Invoke("wrong", 1);
        }
    }

    public void Q1()
    {
        arrows[a].SetActive(true);
        b1.text = "Hand";
        b2.text = "Eyes";
        b3.text = "Nose";
        b4.text = "Ears";
    }
    public void Q2()
    {
        correct.text = "";
        arrows[a - 1].SetActive(false);
        arrows[a].SetActive(true);
        b1.text = "Legs";
        b2.text = "Eyes";
        b3.text = "Ears";
        b4.text = "Mouth";
    }
    public void Q3()
    {
        correct.text = "";
        arrows[a - 1].SetActive(false);
        arrows[a].SetActive(true);
        b1.text = "Legs";
        b2.text = "Hands";
        b3.text = "Nose";
        b4.text = "Feet";
    }
    public void Q4()
    {
        correct.text = "";
        arrows[a - 1].SetActive(false);
        arrows[a].SetActive(true);
        b1.text = "Fingers";
        b2.text = "Nose";
        b3.text = "Eyes";
        b4.text = "Feet";
    }

    public void Q5()
    {
        correct.text = "";
        arrows[a - 1].SetActive(false);
        arrows[a].SetActive(true);
        b1.text = "Legs";
        b2.text = "Ears";
        b3.text = "Eyes";
        b4.text = "Stomach";
    }

    public void Q6()
    {
        correct.text = "";
        arrows[a - 1].SetActive(false);
        arrows[a].SetActive(true);
        b1.text = "Hairs";
        b2.text = "Ears";
        b3.text = "Eyes";
        b4.text = "Elbow";
    }
    public void Q7()
    {
        correct.text = "";
        arrows[a - 1].SetActive(false);
        arrows[a].SetActive(true);
        b1.text = "Fingers";
        b2.text = "Nose";
        b3.text = "Eyes";
        b4.text = "Feet";
    }


    public void wrong()
    {
        correct.text = "";
    }

     public void alldone()
    {
        arrows[a - 1].SetActive(false);
        correct.text = "";
        quiz.SetActive(false);
        done.SetActive(true);
    }

}
    
