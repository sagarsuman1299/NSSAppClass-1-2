using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrange_num_control : MonoBehaviour
{
    ////////////// Variables ////////////////////
    /////////////////////////////////////////////
    public GameObject[] Ans_space;              //Array to hold the boxes where the answers have to be dragged
    public GameObject[] ques;                   //Array to hold the text boxes containing questions
    public GameObject Winner;                   //Object enabled on correct ans
    public GameObject Loser;                    //Object enabled on losing
    int Random_Num;                             //Generated number
    int Count;                                  //Keeps count of correct ans
    int Check = 0;                              //Keeps count of snapped components
    int[] Data_ques = new int[9];               //Array storing generated numbers
    Vector2[] Position_quesBox = new Vector2[9];        //Position vector array for question text boxes
    Vector2[] Position_ansSpace = new Vector2[9];       //Position vector array for Answer space images
    Vector2[] Initial_Pos_ans = new Vector2[9];       //Position vector array for inital pos of answer space images, used when refreshing the panel
    int[] SnapState = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };     //Array to keep track of snap state of individual text areas, 1 => true

    public Sprite[] Question_imgs;              //Sprite array containing images for answer spaces


    /////////////// Variables /////////////////////////
    ///////////////////////////////////////////////////

    private void Start()
    {
        for (int i = 0; i < 9; i++)
        {
            Initial_Pos_ans[i] = ques[i].transform.position;       //Taking the initial position of the text areas to reset them on refresh
        }

        Startingfn();
    }

    private void Update()
    {
        Snapper();
        PosArr();

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
            Checker();
        }
    }


    ////////// Startup functions /////////////
    //////////////////////////////////////////
    public void Startingfn()
    {
        Random_Num = UnityEngine.Random.Range(2, 10);                                           //Generate a random number, this will decide how many numbers the player has to arrange
        
        int SpriteID = UnityEngine.Random.Range(0, 4);

        for (int i = 0; i < 9; i++)
        {
            Ans_space[i].GetComponent<UnityEngine.UI.Image>().sprite = Question_imgs[SpriteID];         //Generates sprite for Question space
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
                Ans_space[i].SetActive(true);
                ques[i].SetActive(true);
            }
        }
        else
        {
            for (int i = i = 4 - (Random_Num / 2); i < 4 + (Random_Num / 2); ++i)
            {
                Ans_space[i].SetActive(true);
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

    ////////// Startup functions /////////////
    //////////////////////////////////////////


    /////////// Snaps components /////////////
    public void Snapper()
    {
        for (int i = 0; i < 9; i++)
        {
            Position_quesBox[i] = ques[i].transform.position;
            Position_ansSpace[i] = Ans_space[i].transform.position;
            SnapState[i] = 0;
        }

        for(int i = 0; i < 9; i++)
        {
            for(int j = 0; j < 9; j++)
            {
                if((ques[i].activeSelf == true) && (Ans_space[j].activeSelf == true))
                {
                    if(Vector2.Distance(ques[i].transform.position, Ans_space[j].transform.position) <= 0.6f)
                    {
                        ques[i].transform.position = Ans_space[j].transform.position;
                        SnapState[i] = 1;
                    }
                }
            }
        }
    }

    ////////// Checks answers ////////////
    public void PosArr()
    {       
        Count = 0;

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (ques[i].activeSelf == true && ques[j].activeSelf == true)
                {
                    if((Data_ques[i] < Data_ques[j]) && (Position_quesBox[i].x < Position_quesBox[j].x))
                    {
                        if(SnapState[i] == 1 && SnapState[j] == 1)
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
        if((Random_Num*(Random_Num-1)/2) == Count)
        {
            Winner.SetActive(true);
            StartCoroutine(ResetQues());
        }
        else
        {
            Loser.SetActive(true);
            StartCoroutine(ResetQues());
        }
    }

    //////////// Refresh panel ////////////
    IEnumerator ResetQues()
    {
        yield return new WaitForSeconds(2);
        
        for(int i = 0; i < 9; i++)
        {
            ques[i].transform.position = Initial_Pos_ans[i];

            Ans_space[i].SetActive(false);
            ques[i].SetActive(false);
            Winner.SetActive(false);
            Loser.SetActive(false);

            SnapState[i] = 0;
        }

        Startingfn();
    }
}
