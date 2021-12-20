using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Identify_Denomination : MonoBehaviour
{
    ////////////// Variables ////////////////////
    /////////////////////////////////////////////
    public GameObject[] Question_space;                 //Array to hold the buttons displaying the sprites
    public GameObject Win_txt;                          //Object enabled on checking ans
    public GameObject Ques_image;                       //Image displaying the question

    int Correct_index = 0;                              //Index of the button holding the correct ans
    int Answer_index;                                   //Index of the correct ans in the indian currency array
    int Selected = 0;                                   //Index of selected option
    int WrongCount = 0;                                 //To allow 3 tries
    bool Routine_check = true;                          //Used to pause coroutine execution

    public Sprite[] Indian_curren;                      //Sprite array containing Indian money
    int[] Denominations = new int[8] { 5, 10, 20, 50, 100, 200, 500, 2000 };     //Int array with denominations

    /////////////// Variables /////////////////////////
    ///////////////////////////////////////////////////


    // Start is called before the first frame update
    void OnEnable()
    {
        Startfn();
    }

    public void Startfn()
    {
        Correct_index = Random.Range(0, 4);

        Debug.Log(Correct_index);

        Answer_index = Random.Range(0, 8);

        WrongCount = 0;

        for (int i = 0; i < 4; i++)
        {
            Question_space[i].SetActive(true);
            Question_space[i].GetComponent<Button>().interactable = true;
        }

        for (int i = 0; i < 4; i++)
        {
            int t = Random.Range(0, 8);

            if(t != Answer_index)
            {
                Question_space[i].GetComponentInChildren<Text>().text = Denominations[t].ToString();
            }
            else
            {
                i--;
            }
        }

        Question_space[Correct_index].GetComponentInChildren<Text>().text = Denominations[Answer_index].ToString();

        Ques_image.GetComponent<Image>().sprite = Indian_curren[Answer_index];
    }

    public void btn1()
    {
        Selected = 0;
        Checker();
    }

    public void btn2()
    {
        Selected = 1;
        Checker();
    }

    public void btn3()
    {
        Selected = 2;
        Checker();
    }

    public void btn4()
    {
        Selected = 3;
        Checker();
    }

    public void Checker()
    {
        for (int i = 0; i < 4; i++)
        {
            Question_space[i].GetComponent<Button>().interactable = false;
        }

        //Debug.Log(Selected);

        if (Routine_check)
        {
            if (Selected == Correct_index)
            {
                Win_txt.GetComponent<Text>().text = "Right answer";
                StartCoroutine(ResetQues());
            }
            else
            {
                Win_txt.GetComponent<Text>().text = "Wrong answer";
                if (WrongCount == 2)
                {
                    StartCoroutine(ViewAns());
                }
                else
                {
                    WrongCount += 1;
                    StartCoroutine(RetryQues());
                }
            }
        }
    }

    IEnumerator ResetQues()
    {
        Routine_check = false;

        yield return new WaitForSeconds(3);

        Win_txt.GetComponent<Text>().text = " ";
        Startfn();

        Routine_check = true;
    }

    IEnumerator ViewAns()
    {
        Routine_check = false;

        yield return new WaitForSeconds(2);

        Win_txt.GetComponent<Text>().text = "Right answer is:";

        for (int i = 0; i < 4; i++)
        {
            if (i != Correct_index)
            {
                Question_space[i].SetActive(false);
            }
        }

        StartCoroutine(ResetQues());

        Routine_check = true;
    }

    IEnumerator RetryQues()
    {
        Routine_check = false;

        yield return new WaitForSeconds(2);

        Win_txt.GetComponent<Text>().text = " ";

        for (int i = 0; i < 4; i++)
        {
            Question_space[i].GetComponent<Button>().interactable = true;
        }

        Routine_check = true;
    }
}
