using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Onclicks : MonoBehaviour
{
    int number_of_moves = 0;
    bool pressed_enter = false;
    public Text Input;
    Text txt;
    public GameObject Number_text;
    public Runner disp;
    



    // Start is called before the first frame update
    void Start()
    {
        disp.Questionchange();
    }

    // Update is called once per frame
    void Update()
    {
        if (pressed_enter)
        {
            if (Input.text == "")
            {
                Input.text = "1000";
            }
            number_of_moves++;
            if (Int32.Parse(Input.text) == disp.price && number_of_moves<=3)
            {
                //Change the question
                disp.delay_correct();
                Input.text = "";
                pressed_enter = false;
                number_of_moves = 0;
                disp.Questionchange();
                
            }
            else if (number_of_moves>=3)
            {
                //Display Text
                
                StartCoroutine(Delayy());
                number_of_moves = 0;
                Input.text = "";
                pressed_enter = false;
                
            }
            else
            {

                //Show Wrong Answer text
                disp.delay_wrong();
                Input.text = "";
                pressed_enter = false;
                //Stay in same qsn
            }
        }
    }
    IEnumerator Delayy()
    {
        disp.Question_text.text = "";
        disp.Correct_Ans_Text.text = "Correct answer is " + disp.price;
        yield return new WaitForSeconds(1.0f);
        disp.Correct_Ans_Text.text = "";
        disp.Questionchange();
    }





    public void Enter()
    {
        pressed_enter = true;
        
    }

    public void Clear()
    {
        Input.text = "";
    }

    public void Extract_text()
    {
        
        txt = Number_text.GetComponent<Text>();
        input_check();
    }

    void input_check()
    {
        Input.text = Input.text + txt.text;
    }
    



}
