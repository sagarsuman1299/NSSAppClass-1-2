using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Arrange_num_control : MonoBehaviour
{
    ////////////// Variables ////////////////////
    /////////////////////////////////////////////
    public GameObject[] Ans_spaceImg;               //Array to hold the boxes where the answers have to be dragged
    public GameObject[] ques;                       //Array to hold the text boxes containing questions
    public GameObject Winner;                       //Object enabled on correct ans
    public GameObject Loser;                        //Object enabled on losing

    int Random_Num;                                 //Generated number
    int Count;                                      //Keeps count of correct ans
    int Check = 0;                                  //Keeps count of snapped components
    int WrongCount = 0;                             //To allow 3 tries
    bool Routine_check = true;

    int[] Data_ques = new int[9];                       //Array storing generated numbers
    Vector2[] Position_quesBox = new Vector2[9];        //Position vector array for question text boxes
    Vector2[] Position_ansSpace = new Vector2[9];       //Position vector array for Answer space images
    Vector2[] Initial_Pos_ans = new Vector2[9];         //Position vector array for initial pos of answer space images, used when refreshing the panel
    int[] SnapState = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };     //Array to keep track of snap state of individual text areas, 1 => true

    public Sprite[] Question_imgs;                      //Sprite array containing images for answer spaces

    /////////////// Variables /////////////////////////
    ///////////////////////////////////////////////////

    private void OnEnable()
    {
        for (int i = 0; i < 9; i++)
        {
            Initial_Pos_ans[i] = ques[i].transform.position;       //Taking the initial position of the text areas to reset them on refresh
        }

        for (int i = 0; i < 9; i++)
        {
            SnapState[i] = 0;
        }

        Startingfn();
    }

    private void OnDisable()
    {
        for (int i = 0; i < 9; i++)
        {
            ques[i].transform.position = Initial_Pos_ans[i];       //Setting initial pos back on disable
        }
        
        WrongCount = 0;

        for (int i = 0; i < 9; i++)
        {
            ques[i].transform.position = Initial_Pos_ans[i];

            Ans_spaceImg[i].GetComponentInChildren<UnityEngine.UI.Text>().text = " ";

            Ans_spaceImg[i].SetActive(false);
            ques[i].SetActive(false);

            SnapState[i] = 0;
        }
        Winner.SetActive(false);
        Loser.SetActive(false);
    }

    private void Update()
    {
        Snapper();

        Check = 0;

        for(int i = 0; i < 9; i++)
        {
            if(SnapState[i] == 1)
            {
                Check += 1;
            }            
        }

        if(Check == Random_Num)
        {
            Counter();
            Checker();
        }
    }


    ////////// Startup functions start /////////////
    //////////////////////////////////////////
    public void Startingfn()
    {
        Random_Num = UnityEngine.Random.Range(2, 10);                                                      //Generate a random number, this will decide how many numbers the player has to arrange

        Debug.Log(Random_Num);
        
        int SpriteID = UnityEngine.Random.Range(0, 4);

        for (int i = 0; i < 9; i++)
        {
            Ans_spaceImg[i].GetComponent<UnityEngine.UI.Image>().sprite = Question_imgs[SpriteID];         //Generates sprite for Blank space
        }

        Objs_Enable();

        QuesMaker();
    }

    ////////// Enables objects //////////////
    public void Objs_Enable()
    {        
        if (Random_Num % 2 != 0)
        {
            for (int i = 4 - (Random_Num / 2); i <= 4 + (Random_Num / 2); ++i)
            {
                Ans_spaceImg[i].SetActive(true);
                ques[i].SetActive(true);
            }
        }
        else
        {
            for (int i = i = 4 - (Random_Num / 2); i < 4 + (Random_Num / 2); ++i)
            {
                Ans_spaceImg[i].SetActive(true);
                ques[i].SetActive(true);
            }
        }
    }

    ////////// Makes ques array and sets it in text boxes ///////////
    public void QuesMaker()
    {
        int[] flag = new int[9];

        for (int i = 0; i < 9; ++i)
        {
            flag[i] = 0;
        }

        for (int i = 0; i < 9; ++i)
        {
            int t = UnityEngine.Random.Range(1, 10);

            if (flag[t - 1] == 0)
            {
                Data_ques[i] = t;
                flag[t - 1] = 1;
            }
            else
            {
                i--;
            }
        }

        for (int i = 0; i < 9; ++i)
        {
            if (ques[i].activeSelf == true)
            {
                ques[i].GetComponent<UnityEngine.UI.Text>().text = Data_ques[i].ToString();
            }
        }

    }

    ////////// Startup functions end /////////////
    //////////////////////////////////////////


    /////////// Snaps components /////////////
    public void Snapper()
    {
        for (int i = 0; i < 9; i++)
        {
            Position_quesBox[i] = ques[i].transform.position;
            Position_ansSpace[i] = Ans_spaceImg[i].transform.position;
            SnapState[i] = 0;
        }

        for(int i = 0; i < 9; i++)
        {
            for(int j = 0; j < 9; j++)
            {
                if((ques[i].activeSelf == true) && (Ans_spaceImg[j].activeSelf == true))
                {
                    if(Vector2.Distance(ques[i].transform.position, Ans_spaceImg[j].transform.position) <= 0.6f)
                    {
                        ques[i].transform.position = Ans_spaceImg[j].transform.position;
                        SnapState[i] = 1;
                    }
                }
            }
        }
    }

    ////////// Checks answers ////////////
    public void Counter()
    {       
        Count = 0;

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (ques[i].activeSelf == true && ques[j].activeSelf == true)
                {
                    if ((Data_ques[i] < Data_ques[j]) && (Position_quesBox[i].x < Position_quesBox[j].x))
                    {
                        if (SnapState[i] == 1 && SnapState[j] == 1)
                        {
                            Count += 1;
                        }
                    }
                }
            }
        }
    }

    public void Checker()
    {
        Check = 0;

        if(Routine_check)
        {
            if ((Random_Num * (Random_Num - 1) / 2) == Count)
            {
                WrongCount = 0;
                Winner.SetActive(true);
                StartCoroutine(ResetQues());
            }
            else
            {
                WrongCount += 1;
                if (WrongCount == 3)
                {
                    Loser.GetComponent<UnityEngine.UI.Text>().text = "WRONG ANSWER!!";
                    WrongCount = 0;
                    Loser.SetActive(true);
                    StartCoroutine(AnsFinder());
                }
                else
                {
                    Loser.GetComponent<UnityEngine.UI.Text>().text = "WRONG! TRY AGAIN";
                    Loser.SetActive(true);
                    StartCoroutine(RetryQues());
                }
            }
        }
        
    }

    //////////// Refresh panel ////////////
    IEnumerator ResetQues()
    {
        Routine_check = false;
        yield return new WaitForSeconds(2);
        for (int i = 0; i < 9; i++)
        {
            ques[i].transform.position = Initial_Pos_ans[i];

            Ans_spaceImg[i].GetComponentInChildren<UnityEngine.UI.Text>().text = " ";

            Ans_spaceImg[i].SetActive(false);
            ques[i].SetActive(false);

            SnapState[i] = 0;
        }
        Winner.SetActive(false);
        Loser.SetActive(false);

        Routine_check = true;

        Startingfn();
    }

    //////////// Retry question ///////////
    IEnumerator RetryQues()
    {
        Routine_check = false;
        yield return new WaitForSeconds(2);
        Loser.SetActive(false);
        
        for (int i = 0; i < 9; i++)
        {
            ques[i].transform.position = Initial_Pos_ans[i];
            SnapState[i] = 0;
        }

        Routine_check = true;
    }

    /////////// Reset button /////////////
    public void Resetfn()
    {
        for (int i = 0; i < 9; i++)
        {
            ques[i].transform.position = Initial_Pos_ans[i];
            SnapState[i] = 0;
        }
    }

    //////////// Retry question ///////////
    IEnumerator AnsFinder()
    {
        Routine_check = false;
        yield return new WaitForSeconds(2);
        Loser.GetComponent<UnityEngine.UI.Text>().text = "RIGHT ANSWER IS:";

        int[] Result_arr = Data_ques;

        for (int i = 0; i < 9; i++)
        {
            if (ques[i].activeSelf == true)
            {
                ques[i].GetComponent<UnityEngine.UI.Text>().text = " ";
            }
            else
            {
                Result_arr[i] = 0;
            }
        }

        int numToRemove = 0;
        Result_arr = Result_arr.Where(val => val != numToRemove).ToArray();

        Array.Sort(Result_arr);

        int t = 0;
        for(int i = 0; i < 9; i++)
        {
            if(Ans_spaceImg[i].activeSelf == true)
            {
                Ans_spaceImg[i].GetComponentInChildren<UnityEngine.UI.Text>().text = Result_arr[t].ToString();
                t++;
            }
        }

        Routine_check = true;

        StartCoroutine(ResetQues());
    }
}
