using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Button_Handler : MonoBehaviour
{
    int number_of_moves = 0;
    bool pressed_enter = false;
    
    public Text entered;
    Text txt;
    public GameObject num_text;
    public Fruits fruits;

    // Update is called once per frame
    void Update()
    {
        if (pressed_enter)
        {
            number_of_moves++;
            if (Int32.Parse(entered.text) == fruits.correct_ans && number_of_moves <= 3)
            {
                //Change the question
                fruits.Delay_correct();
                entered.text = "";
                pressed_enter = false;
                number_of_moves = 0;
                fruits.disable_qsn();
                fruits.qsn_change();

            }
            else if (number_of_moves >= 3)
            {

                StartCoroutine(Delayy());
                number_of_moves = 0;
                entered.text = "";
                pressed_enter = false;

            }
            else
            {

                //Show Wrong Answer text
                fruits.Delay_wrong();
                entered.text = "";
                pressed_enter = false;
                //Stay in same qsn
            }
        }
    }
    IEnumerator Delayy()
    {
        fruits.Question_text.text = "";
        fruits.Correct_Ans_Text.text = "Correct answer is - " + fruits.correct_ans;
        yield return new WaitForSeconds(1.0f);
        fruits.Correct_Ans_Text.text = "";
        fruits.disable_qsn();
        fruits.qsn_change();

    }





    public void Enter()
    {
        pressed_enter = true;

    }

    public void Clear()
    {
        entered.text = "";
    }

    public void Extract_text()
    {

        txt = num_text.GetComponent<Text>();
        entered_check();
        Debug.Log(entered.text);
    }

    void entered_check()
    {
        entered.text = entered.text + txt.text;
    }
}
