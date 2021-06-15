using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public PanelsSpawn script;
    public GameObject text;
    public GameObject Correct;
    public GameObject Wrong;
    Text fortxt;
    public int check = 1;
   
    public void Etext()
    {
        fortxt = text.GetComponent<Text>();
        if (script.rnd == ((int)fortxt.text[0] - 48))
        {
            Correct.SetActive(true);
            check = 1;
            
        }
        else
        {
            Wrong.SetActive(true);
            check= 0;

        }

    }

}
