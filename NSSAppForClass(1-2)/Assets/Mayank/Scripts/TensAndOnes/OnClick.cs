using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClick : MonoBehaviour
{
    public Text ButtonText;
    Text fortxt;
    public NumGenerate value;
    [HideInInspector] public int clicked;

    public void Etext()
    {
        fortxt = ButtonText.GetComponent<Text>();
        clicked = (int)fortxt.text[0] - 48;
        if (value.flag == 1)
        {
            value.forunits(clicked);
        }
        else
        {
            value.fortens(clicked);
        }


    }
}
