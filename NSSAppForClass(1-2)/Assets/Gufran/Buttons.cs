using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public PanelsSpawn spawn;
    public GameObject text;
    public int flag;
    public Manager manage;
    Text fortxt;

   
   
    public void Etext()
    {
        
        fortxt = text.GetComponent<Text>();
        //Debug.Log(fortxt.text);
       // Debug.Log(num1.rnd );
       // Debug.Log(num2.rnd );
      //  Debug.Log((int)fortxt.text[0] - 48);
        manage.show(spawn.rnd , (int)fortxt.text[0] - 48);

    }

}
