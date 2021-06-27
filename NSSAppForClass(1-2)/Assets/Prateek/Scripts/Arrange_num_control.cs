using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrange_num_control : MonoBehaviour
{
    public GameObject[] Ans_space;                                                              //Array to hold the boxes where the answers have to be dragged
    public GameObject[] ques;                                                                   //Array to hold the text boxes containing questions
    public GameObject Winner;

    int Random_Num;
    int Count;
    float[] Position_ans = new float[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    int[] Data_ques = new int[9];

    bool Win = false;

    private void Start()
    {
        Random_Num = UnityEngine.Random.Range(2, 10);                                           //Generate a random number, this will decide how many numbers the player has to arrange
        // Debug.Log(Random_Num);

        Objs_Enable();

        QuesMaker();
    }

    private void Update()
    {
        Count = 0;

        PosArr();

        if(Win)
        {
            Winner.SetActive(true);
        }
    }


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

    public void PosArr()
    {
        Vector3[] Position_quesBox = new Vector3[9];
        
        for (int i = 0; i < 9; i++)
        {
            if (ques[i].activeSelf == true)
            {
                Position_quesBox[i] = ques[i].transform.position;
            }
            else
            {
                Position_quesBox[i] = new Vector3(0f, 0f, ques[i].transform.position.z);
            }
        }

        // for (int i = 0; i < 9; i++)
        // {
        //     Debug.Log(i);
        //     Debug.Log(Position_quesBox[i]);
        // }

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (ques[i].activeSelf == true && ques[j].activeSelf == true)
                {
                    if((Data_ques[i] < Data_ques[j]) && (Position_quesBox[i].x < Position_quesBox[j].x) && (Position_quesBox[i].y == Position_quesBox[j].y))
                    Count += 1;
                }
            }
        }

        Debug.Log(Count);

        if(Count == Random_Num)
        {
            Win = true;
        }
    }

}
