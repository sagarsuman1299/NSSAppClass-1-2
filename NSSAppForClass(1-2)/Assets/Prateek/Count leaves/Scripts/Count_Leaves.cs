using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count_Leaves : MonoBehaviour
{
    ////////////// Variables ////////////////////
    /////////////////////////////////////////////
    public GameObject[] branches;       //Individual branches, not the empty objects
    public GameObject[] leaves1;        //First 50 leaves from the bottom, go by the order of the empty objects
    public GameObject[] leaves2;        //Rest 50
    public GameObject[] EmptyObjs;      ///IMP: B1 and B2 which are always active have been put in last 2 indeces as they were later additions and I'm lazy to change the whole code///

    public GameObject textAr;           //txt area to print input
    public GameObject winTxt;           //shows correctness of ans

    int WrongCount = 0;                 //Checks how many times the user has provided wrong answer
    bool Routine_check = true;          //Its to keep the code from executing over and over again while the couroutine waits

    int Generated;

    /////////////// Variables /////////////////////////
    ///////////////////////////////////////////////////
    

    // Start is called before the first frame update
    void OnEnable()
    {
        StartFun();        
    }

    ////////////// Starting fns begin ///////////////
    ////////////////////////////////////////////////
    public void StartFun()
    {
        textAr.GetComponent<UnityEngine.UI.Text>().text = "";
        winTxt.GetComponent<UnityEngine.UI.Text>().text = "";

        Generated = Random.Range(21, 101);
        Debug.Log(Generated);

        BranchEnabler();
        LeafEnabler();
    }

    public void BranchEnabler()
    {
        EmptyObjs[8].SetActive(true);
        EmptyObjs[9].SetActive(true);

        if(Generated >= 21)
        {
            EmptyObjs[0].SetActive(true);
            branches[2].SetActive(true);
        }
        if(Generated >= 31)
        {
            EmptyObjs[1].SetActive(true);
            branches[3].SetActive(true);
        }
        if(Generated >= 41)
        {
            EmptyObjs[2].SetActive(true);
            branches[4].SetActive(true);
        }
        if(Generated >= 51)
        {
            EmptyObjs[3].SetActive(true);
            branches[5].SetActive(true);
        }
        if(Generated >= 61)
        {
            EmptyObjs[4].SetActive(true);
            branches[6].SetActive(true);
        }
        if(Generated >= 71)
        {
            EmptyObjs[5].SetActive(true);
            branches[7].SetActive(true);
        }
        if(Generated >= 81)
        {
            EmptyObjs[6].SetActive(true);
            branches[8].SetActive(true);
        }
        if(Generated >= 91)
        {
            EmptyObjs[7].SetActive(true);
            branches[9].SetActive(true);
        }
    }

    public void LeafEnabler()
    {
        if(Generated <= 60)
        {
            for(int i = 0; i < (Generated-20); i++)
            {
                leaves1[i].SetActive(true);
            }
        }

        if(Generated > 60)
        {
            for(int i = 0; i < 40; i++)
            {
                leaves1[i].SetActive(true);
            }

            for(int j = 0; j < (Generated-60); j++)
            {
                leaves2[j].SetActive(true);
            }
        }
    }
    ////////////// Starting fns end ///////////////
    ////////////////////////////////////////////////


    ////////////// For pressing the diff buttons on keypad begin ///////////////
    ////////////////////////////////////////////////////////////////////////////
    public void Press1()
    {
        textAr.GetComponent<UnityEngine.UI.Text>().text = textAr.GetComponent<UnityEngine.UI.Text>().text + 1.ToString();
    }
    public void Press2()
    {
        textAr.GetComponent<UnityEngine.UI.Text>().text = textAr.GetComponent<UnityEngine.UI.Text>().text + 2.ToString();
    }
    public void Press3()
    {
        textAr.GetComponent<UnityEngine.UI.Text>().text = textAr.GetComponent<UnityEngine.UI.Text>().text + 3.ToString();
    }
    public void Press4()
    {
        textAr.GetComponent<UnityEngine.UI.Text>().text = textAr.GetComponent<UnityEngine.UI.Text>().text + 4.ToString();
    }
    public void Press5()
    {
        textAr.GetComponent<UnityEngine.UI.Text>().text = textAr.GetComponent<UnityEngine.UI.Text>().text + 5.ToString();
    }
    public void Press6()
    {
        textAr.GetComponent<UnityEngine.UI.Text>().text = textAr.GetComponent<UnityEngine.UI.Text>().text + 6.ToString();
    }
    public void Press7()
    {
        textAr.GetComponent<UnityEngine.UI.Text>().text = textAr.GetComponent<UnityEngine.UI.Text>().text + 7.ToString();
    }
    public void Press8()
    {
        textAr.GetComponent<UnityEngine.UI.Text>().text = textAr.GetComponent<UnityEngine.UI.Text>().text + 8.ToString();
    }
    public void Press9()
    {
        textAr.GetComponent<UnityEngine.UI.Text>().text = textAr.GetComponent<UnityEngine.UI.Text>().text + 9.ToString();
    }
    public void Press0()
    {
        textAr.GetComponent<UnityEngine.UI.Text>().text = textAr.GetComponent<UnityEngine.UI.Text>().text + 0.ToString();
    }

    public void Erase()
    {
        textAr.GetComponent<UnityEngine.UI.Text>().text = "";
    }
    public void Check()
    {
        if(textAr.GetComponent<UnityEngine.UI.Text>().text == "")
        {
            winTxt.GetComponent<UnityEngine.UI.Text>().text = "Enter a number";
        }
        else
        {
            WinCheck();
        }   
    }
    ////////////// For pressing the diff buttons on keypad end ///////////////
    //////////////////////////////////////////////////////////////////////////


    ////////////// Check the provided input against generated num ///////////////
    /////////////////////////////////////////////////////////////////////////////
    public void WinCheck()
    {
        if(Routine_check)
        {
            if (int.Parse(textAr.GetComponent<UnityEngine.UI.Text>().text) == Generated)
            {
                WrongCount = 0;
                winTxt.GetComponent<UnityEngine.UI.Text>().text = "RIGHT ANSWER!!";
                StartCoroutine(ResetQuesCorrect());
            }
            else
            {
                WrongCount += 1;

                if (WrongCount == 3)
                {
                    WrongCount = 0;
                    winTxt.GetComponent<UnityEngine.UI.Text>().text = "WRONG ANSWER!!";
                    StartCoroutine(ResetQuesWrong());
                }
                else
                {
                    winTxt.GetComponent<UnityEngine.UI.Text>().text = "WRONG! TRY AGAIN";
                    StartCoroutine(RetryQues());
                }
            }
        }
    }

    IEnumerator ResetQuesCorrect()
    {
        Routine_check = false;

        yield return new WaitForSeconds(2);

        for (int i = 2; i < 10; i++)
        {
            branches[i].SetActive(false);
        }

        for(int i = 0; i < 10; i++)
        {
            EmptyObjs[i].SetActive(false);
        }

        for(int j = 0; j < 40; j++)
        {
            leaves1[j].SetActive(false);
            leaves2[j].SetActive(false);
        }

        Routine_check = true;

        StartFun();
    }

    IEnumerator ResetQuesWrong()
    {
        Routine_check = false;

        yield return new WaitForSeconds(2);

        textAr.GetComponent<UnityEngine.UI.Text>().text = Generated.ToString();
        winTxt.GetComponent<UnityEngine.UI.Text>().text = "RIGHT ANSWER IS:";

        StartCoroutine(DisplayCorrect());

        Routine_check = true;
    }

    IEnumerator DisplayCorrect()
    {
        yield return new WaitForSeconds(2);

        for (int i = 2; i < 10; i++)
        {
            branches[i].SetActive(false);
        }

        for (int i = 0; i < 10; i++)
        {
            EmptyObjs[i].SetActive(false);
        }

        for (int j = 0; j < 40; j++)
        {
            leaves1[j].SetActive(false);
            leaves2[j].SetActive(false);
        }

        StartFun();
    }

    IEnumerator RetryQues()
    {
        Routine_check = false;

        yield return new WaitForSeconds(2);
        Erase();
        winTxt.GetComponent<UnityEngine.UI.Text>().text = "";

        Routine_check = true;
    }
}
