using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public GameObject Correct;
    public GameObject Wrong;
    [HideInInspector]public int flag = 1;
    [HideInInspector]public int flag1 = 1;
    private float Delay = 0.5f;

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
        Correct.SetActive(true);
        yield return new WaitForSeconds(Delay);
        Correct.SetActive(false);
    }

    IEnumerator DelayWrong()
    {
        Wrong.SetActive(true);
        yield return new WaitForSeconds(Delay);
        Wrong.SetActive(false);
    }
}
