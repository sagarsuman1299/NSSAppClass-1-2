using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class water_props : MonoBehaviour
{
    ////////////// Variables ////////////////////
    /////////////////////////////////////////////
    public GameObject Ques;                             //Array to hold the question txt box
    public GameObject Opt_1;                            //Array to hold option 1
    public GameObject Opt_2;                            //Array to hold option 2
    public GameObject Win_txt;                          //Object enabled on checking ans

    int Ques_num = 0;                                   //Q1 -> color, 2 -> taste, 3 -> smell, 4 -> shape
    int Prev_ques = 0;                                  //Keeps track of prev ques to prevent dupli
    int Correct_btn;                                    //Index of the correct button
    int Selected = 0;                                   //Index of selected option
    bool Routine_check = true;                          //Used to pause coroutine execution

    public string[] color;                              //String array containing wrong colors
    public string[] taste;                              //String array containing wrong taste
    public string[] smell;                              //String array containing wrong smell
    public string[] shape;                              //String array containing wrong shape

    /////////////// Variables /////////////////////////
    ///////////////////////////////////////////////////


    // Start is called before the first frame update
    void OnEnable()
    {
        Win_txt.GetComponent<Text>().text = " ";

        Startfn();
    }

    public void Startfn()
    {
        Ques_num = Random.Range(1, 5);

        if(Ques_num != Prev_ques)
        {
            Opt_1.SetActive(true);
            Opt_2.SetActive(true);

            Opt_1.GetComponent<Button>().interactable = true;
            Opt_2.GetComponent<Button>().interactable = true;

            if (Ques_num == 1)
            {
                Ques.GetComponentInChildren<Text>().text = "What is the colour of water?";
            }
            else if (Ques_num == 2)
            {
                Ques.GetComponentInChildren<Text>().text = "What is the taste of water?";
            }
            else if (Ques_num == 3)
            {
                Ques.GetComponentInChildren<Text>().text = "What is the smell of water?";
            }
            else if (Ques_num == 4)
            {
                Ques.GetComponentInChildren<Text>().text = "What is the shape of water?";
            }

            Correct_btn = Random.Range(1, 3);

            Debug.Log(Ques_num);
            Debug.Log(Correct_btn);

            Prev_ques = Ques_num;

            if (Correct_btn == 1)
            {
                QuestionMaker(Opt_1, Opt_2);
            }
            else
            {
                QuestionMaker(Opt_2, Opt_1);
            }
        }

        else
        {
            Startfn();
        }
    }

    private void QuestionMaker(GameObject correct, GameObject wrong)
    {
        int x = Random.Range(0, 5);
        Debug.Log(x);

        if(Ques_num == 1)
        {
            correct.GetComponentInChildren<Text>().text = "No colour";
            wrong.GetComponentInChildren<Text>().text = color[x];
        }
        else if (Ques_num == 2)
        {
            correct.GetComponentInChildren<Text>().text = "No taste";
            wrong.GetComponentInChildren<Text>().text = taste[x];
        }
        else if (Ques_num == 3)
        {
            correct.GetComponentInChildren<Text>().text = "No smell";
            wrong.GetComponentInChildren<Text>().text = smell[x];
        }
        else if (Ques_num == 4)
        {
            correct.GetComponentInChildren<Text>().text = "No shape";
            wrong.GetComponentInChildren<Text>().text = shape[x];
        }
    }

    public void btn1()
    {
        Selected = 1;
        Checker();
    }

    public void btn2()
    {
        Selected = 2;
        Checker();
    }

    public void Checker()
    {
        Opt_1.GetComponent<Button>().interactable = false;
        Opt_2.GetComponent<Button>().interactable = false;

        if (Routine_check)
        {
            if (Selected == Correct_btn)
            {
                Win_txt.GetComponent<Text>().text = "Right answer";
                StartCoroutine(ResetQues());
            }
            else
            {
                Win_txt.GetComponent<Text>().text = "Wrong answer";
                {
                    if (Correct_btn == 1)
                    {
                        StartCoroutine(ViewAns(Opt_1, Opt_2));
                    }
                    else
                    {
                        StartCoroutine(ViewAns(Opt_2, Opt_1));
                    }
                }
            }
        }
    }

    IEnumerator ResetQues()
    {
        Routine_check = false;

        yield return new WaitForSeconds(2);

        Win_txt.GetComponent<Text>().text = " ";
        Startfn();

        Routine_check = true;
    }

    IEnumerator ViewAns(GameObject correct, GameObject wrong)
    {
        Routine_check = false;

        yield return new WaitForSeconds(2);

        Win_txt.GetComponent<Text>().text = "Right answer is:";

        wrong.SetActive(false);

        StartCoroutine(ResetQues());

        Routine_check = true;
    }
}
