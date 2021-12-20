using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sum_manager : MonoBehaviour
{
    public Num1 num1;
    public Num2 num2;

    public GameObject Correct;
    public GameObject Wrong;
    private float Delay = 0.5f;
    public Image Calc;
    public Sprite correct;
    public Sprite wrong;
    public Text QuestionText;
    private int wrongAnsCount = 1;

    public void show(int rnd1, int rnd2, int value)
    {
        if (rnd1 + rnd2 == value)
        {
            num1.PanelUpdate();
            num2.PanelUpdate();
            StartCoroutine(sum_DelayCorrect());
        }
        else
        {
            if (wrongAnsCount == 3)
            {
                QuestionText.text = "Correct Answer is : " + (rnd1 + rnd2);
                wrongAnsCount = 0;
                StartCoroutine(sum_Delay());
            }
            wrongAnsCount++;
            StartCoroutine(sum_DelayWrong());
        }
    }
    IEnumerator sum_DelayCorrect()
    {
        Calc.sprite = correct;
        Correct.SetActive(true);
        yield return new WaitForSeconds(Delay);
        Correct.SetActive(false);
    }

    IEnumerator sum_DelayWrong()
    {
        Calc.sprite = wrong;
        Wrong.SetActive(true);
        yield return new WaitForSeconds(Delay);
        Wrong.SetActive(false);
    }

    IEnumerator sum_Delay()
    {
        Calc.sprite = wrong;
        yield return new WaitForSeconds(2.0f);
        num1.PanelUpdate();
        num2.PanelUpdate();
        QuestionText.text = "What is the sum of the given numbers?";
    }
}
