using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sum_buttons : MonoBehaviour
{
    public Num1 num1;
    public Num2 num2;
    public GameObject text;
    public int flag;
    public sum_manager manage;
    Text fortxt;
   
    public void Etext()
    {
        fortxt = text.GetComponent<Text>();
        //Debug.Log(fortxt.text);
       // Debug.Log(num1.rnd );
       // Debug.Log(num2.rnd );
      //  Debug.Log((int)fortxt.text[0] - 48);
        manage.show(num1.rnd , num2.rnd  , (int)fortxt.text[0] - 48);

    }

}
