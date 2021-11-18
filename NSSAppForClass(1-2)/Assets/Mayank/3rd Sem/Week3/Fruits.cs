using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fruits : MonoBehaviour
{
    [HideInInspector] public int number_of_fruits1, number_of_fruits2, number_of_fruits3, fruit1, fruit2, fruit3, correct_ans;
 
    public GameObject[] FirstPanel;
    public GameObject[] SecondPanel;
    public GameObject[] ThirdPanel;
    public Sprite [] sprites;
    public Image[] firstpanel_Images, secondpanel_Images, thirdpanel_Images;
    int itr;
    string[] frruits = { "bananas", "apples", "oranges", "pair of cherries", "strawberries", "berries", "pears", "watermelons" };

    public GameObject correct, wrong;
    public Sprite calc_correct, calc_wrong;
    public Image calc;
    public Text Question_text;
    public Text Correct_Ans_Text;

    public void OnEnable()
    {
        disable_qsn();
        qsn_change();
        if(sprites.Length != frruits.Length)
        {
            Debug.Log("Errrrrrrrrrrr!!!!!!!");
        }
    }

    public void qsn_change()
    {
        
        
        number_of_fruits1 = Random.Range(0, 5);
        number_of_fruits2 = Random.Range(0, 5);
        number_of_fruits3 = Random.Range(0, 5);

        FirstPanel[number_of_fruits1].SetActive(true);
        SecondPanel[number_of_fruits2].SetActive(true);
        ThirdPanel[number_of_fruits3].SetActive(true);

        
        fruit1 = Random.Range(0, sprites.Length);
        fruit2 = Random.Range(0, sprites.Length);
        fruit3 = Random.Range(0, sprites.Length);

        switch (number_of_fruits1 + 1)
        {
            case 1:
                itr = 0;
                break;
            case 2:
                itr = 1;
                break;
            case 3:
                itr = 3;
                break;
            case 4:
                itr = 6;
                break;
            case 5:
                itr = 10;
                break;
        }
        for (int i= itr; i <= itr + number_of_fruits1; i++)
        {
            firstpanel_Images[i].sprite = sprites[fruit1];
        }
        
        while(fruit2 == fruit1)
        {
            fruit2 = Random.Range(0, sprites.Length);
        }

        switch (number_of_fruits2 + 1)
        {
            case 1:
                itr = 0;
                break;
            case 2:
                itr = 1;
                break;
            case 3:
                itr = 3;
                break;
            case 4:
                itr = 6;
                break;
            case 5:
                itr = 10;
                break;
        }
        
        for (int i = itr; i <= itr + number_of_fruits2; i++)
        {
            secondpanel_Images[i].sprite = sprites[fruit2];
        }

        while ((fruit3 == fruit1) || (fruit3 == fruit2))
        {
            fruit3 = Random.Range(0, sprites.Length);
        }

        switch (number_of_fruits3 + 1)
        {
            case 1:
                itr = 0;
                break;
            case 2:
                itr = 1;
                break;
            case 3:
                itr = 3;
                break;
            case 4:
                itr = 6;
                break;
            case 5:
                itr = 10;
                break;
        }

        for (int i = itr; i <= itr + number_of_fruits3; i++)
        {
            thirdpanel_Images[i].sprite = sprites[fruit3];
        }

        qsn_text_new_qsn();


    }

    public void qsn_text_new_qsn()
    {

        int random_qsn = Random.Range(0, 3);
        if (random_qsn == 0)
        {
            Question_text.text = "How many " + frruits[fruit1] + " are there?";
            correct_ans = number_of_fruits1 + 1;
        }
        else if (random_qsn == 1)
        {
            Question_text.text = "How many " + frruits[fruit2] + " are there?";
            correct_ans = number_of_fruits2 + 1;
        }
        else
        {
            Question_text.text = "How many " + frruits[fruit3] + " are there?";
            correct_ans = number_of_fruits3 + 1;
        }
        
    }

    public void disable_qsn()
    {
        FirstPanel[number_of_fruits1].SetActive(false);
        SecondPanel[number_of_fruits2].SetActive(false);
        ThirdPanel[number_of_fruits3].SetActive(false);

    }

    public void Delay_correct()
    {
        StartCoroutine(DelayCorrect());
    }

    public void Delay_wrong()
    {
        StartCoroutine(DelayWrong());
    }

    IEnumerator DelayCorrect()
    {
        calc.sprite = calc_correct;
        correct.SetActive(true);
        yield return new WaitForSeconds(0.5f);

        correct.SetActive(false);
    }

    IEnumerator DelayWrong()
    {
        calc.sprite = calc_wrong;
        wrong.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        wrong.SetActive(false);
    }


}
