using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Identify_fake : MonoBehaviour
{
    ////////////// Variables ////////////////////
    /////////////////////////////////////////////
    public GameObject[] Question_space;                 //Array to hold the buttons displaying the sprites
    public GameObject Win_txt;                          //Object enabled on checking ans

    int Correct_index = 0;                              //Index of the button holding the correct ans
    int Answer_index;                                   //Index of the correct ans in the indian currency array
    int Selected = 0;                                   //Index of selected option
    int WrongCount = 0;                                 //To allow 3 tries
    bool Routine_check = true;                          //Used to pause coroutine execution

    public Sprite[] Indian_curren;                      //Sprite array containing Indian money
    public Sprite[] Other_curren;                       //Sprite array with other currency

    /////////////// Variables /////////////////////////
    ///////////////////////////////////////////////////


    // Start is called before the first frame update
    void OnEnable()
    {
        Startfn();
    }

    public void Startfn()
    {
        WrongCount = 0;

        for (int i = 0; i < 4; i++)
        {
            Question_space[i].SetActive(true);
            Question_space[i].GetComponent<Button>().interactable = true;
        }

        for (int i = 0; i < 4; i++)
        {
            int t = Random.Range(0, 12);

            Question_space[i].GetComponent<Image>().sprite = Indian_curren[t];
        }

        Correct_index = Random.Range(0, 4);

        Debug.Log(Correct_index);

        Answer_index = Random.Range(0, 17);

        Question_space[Correct_index].GetComponent<Image>().sprite = Other_curren[Answer_index];
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
