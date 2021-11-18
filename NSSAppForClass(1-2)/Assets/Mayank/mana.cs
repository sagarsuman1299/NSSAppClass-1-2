using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mana : MonoBehaviour
{

    public GameObject Correct;
    public GameObject Wrong;
    [HideInInspector] public int flag = 1;
    [HideInInspector] public int flag1 = 1;
    private float Delay = 0.5f;
    public Image Calc;
    public Sprite correct;
    public Sprite wrong;


    public void show(int rnd1, int rnd2, int value)
    {
        if (rnd1 + rnd2 == value)
        {
            flag = 1;
            flag1 = 1;
            StartCoroutine(DelayCorrect());
        }
        else

        {
            flag = 0;
            flag1 = 0;
            StartCoroutine(DelayWrong());
        }
    }
    IEnumerator DelayCorrect()
    {
        Calc.sprite = correct;
        Correct.SetActive(true);
        yield return new WaitForSeconds(Delay);
        Correct.SetActive(false);
    }

    IEnumerator DelayWrong()
    {
        Calc.sprite = wrong;
        Wrong.SetActive(true);
        yield return new WaitForSeconds(Delay);
        Wrong.SetActive(false);
    }
}