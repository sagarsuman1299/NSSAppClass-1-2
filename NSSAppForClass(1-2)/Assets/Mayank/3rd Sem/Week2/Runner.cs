using System.Collections;
using UnityEngine;
using UnityEngine.UI;        

public class Runner : MonoBehaviour
{
    public Image image, Calc;
    public Sprite calc_correct, calc_wrong;
    public Sprite[] less_than_15;
    public Sprite[] less_than_40;
    public Sprite[] less_than_70;
    public Sprite[] less_than_100;
    public Text price_text;
    public Text Question_text;

    public GameObject correct, wrong;
    [HideInInspector]public int random_number, price;
    public Text Correct_Ans_Text;

    public void Questionchange()
    {
        Question_text.text = "What is the amount on the price tag?";
        price = Random.Range(5, 101);
        price_text.text = price + " /-";
        if (price >70 && price<=100)
        {
            random_number = Random.Range(0, 3);
            image.sprite = less_than_100[random_number];
        }
        else if (price >40 && price<=70)
        {
            random_number = Random.Range(0, 3);
            image.sprite = less_than_70[random_number];
        }
        else if (price > 15 && price <= 40)
        {
            random_number = Random.Range(0, 3);
            image.sprite = less_than_40[random_number];
        }
        else
        {
            random_number = Random.Range(0, 3);
            image.sprite = less_than_15[random_number];
        }

        
    }

    public void delay_correct()
    {
        StartCoroutine(DelayCorrect());
    }

    public void delay_wrong()
    {
        StartCoroutine(DelayWrong());
    }

    IEnumerator DelayCorrect()
    {
        Calc.sprite = calc_correct;
        correct.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        
        correct.SetActive(false);
    }

    IEnumerator DelayWrong()
    {
        Calc.sprite = calc_wrong;
        wrong.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        wrong.SetActive(false);
    }

}
