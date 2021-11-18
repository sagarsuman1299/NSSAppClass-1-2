using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Manager : MonoBehaviour
{

    [HideInInspector] public int flag = 1;

    public int click=1;

    public Image calculator;
    public Sprite correct;
    public Sprite wrong;

    public Text remark;


    public void show(int rnd1,  int value)
    {
        click =1;
        if (rnd1  == value)
        {
            flag = 1;
            //Debug.Log(true);
            CorrectWait();

        }
        else

        {
            flag = 0;
            WrongWait();

        }
    }
    void WrongWait()
    {
        calculator.sprite = wrong;
        remark.text = "Incorrect";

    }

    void CorrectWait()
    {
        calculator.sprite = correct;
        
        remark.text = "Congratulations!" ;
        

    }
}
