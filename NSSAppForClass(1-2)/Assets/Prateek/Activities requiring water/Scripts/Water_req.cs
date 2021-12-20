using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Water_req : MonoBehaviour
{
    ////////////// Variables ////////////////////
    /////////////////////////////////////////////
    public GameObject[] Options;                        //Array to hold the buttons displaying the sprites
    public GameObject Win_txt;                          //Object enabled on checking ans

    int Correct_index = 0;                              //Index of the button holding the correct ans
    int Answer_index;                                   //Index of the correct ans in the array
    int Selected = 0;                                   //Index of selected option
    int WrongCount = 0;                                 //To allow 3 tries
    bool Routine_check = true;                          //Used to pause coroutine execution

    public Sprite[] req_water;                          //Sprite array containing water requiring ones
    public Sprite[] dont_req_water;                     //Sprite array containing ones not requiring water
    public string[] water_req;                          //String array containing ones requiring water
    public string[] no_water_req;                       //String array containing ones not requiring water

    /////////////// Variables /////////////////////////
    ///////////////////////////////////////////////////


    // Start is called before the first frame update
    void OnEnable()
    {
        Startfn();
    }

    public void Startfn()
    {
        Win_txt.GetComponent<Text>().text = " ";

        WrongCount = 0;

        for (int i = 0; i < 3; i++)
        {
            Options[i].SetActive(true);
            Options[i].GetComponent<Button>().interactable = true;
        }

        int[] flag = new int[9];

        for (int i = 0; i < 9; ++i)
        {
            flag[i] = 0;
        }

        for (int i = 0; i < 3; ++i)
        {
            int t = Random.Range(0, 9);

            if (flag[t] == 0)
            {
                Options[i].GetComponent<Image>().sprite = dont_req_water[t];
                Options[i].GetComponentInChildren<Text>().text = no_water_req[t];
                flag[t] = 1;
            }
            else
            {
                i--;
            }
        }

        Correct_index = Random.Range(0, 3);

        Debug.Log(Correct_index);

        Answer_index = Random.Range(0, 6);

        Options[Correct_index].GetComponent<Image>().sprite = req_water[Answer_index];
        Options[Correct_index].GetComponentInChildren<Text>().text = water_req[Answer_index];
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

    public void Checker()
    {
        for (int i = 0; i < 3; i++)
        {
            Options[i].GetComponent<Button>().interactable = false;
        }

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
                if (WrongCount == 1)
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

        Startfn();

        Routine_check = true;
    }

    IEnumerator ViewAns()
    {
        Routine_check = false;

        yield return new WaitForSeconds(2);

        Win_txt.GetComponent<Text>().text = "Right answer is:";

        for (int i = 0; i < 3; i++)
        {
            if (i != Correct_index)
            {
                Options[i].SetActive(false);
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

        for (int i = 0; i < 3; i++)
        {
            Options[i].GetComponent<Button>().interactable = true;
            Options[i].GetComponent<Button>().interactable = true;
        }

        Routine_check = true;
    }
}
