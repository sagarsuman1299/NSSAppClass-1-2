using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NumGenerate : MonoBehaviour
{
    public GameObject[] Panel1;
    public GameObject[] Panel2;
    public GameObject Correct;
    public GameObject Wrong;
    public Text Enter;
    [HideInInspector] public int rnd;
    [HideInInspector] public Text randomnumber;
    OnClick onclick;
    [HideInInspector] public int flag;
    [HideInInspector] public int flag2;
    private float delay = 0.5f;
    int tens;
    int units;
    public Image Calc;
    public Sprite correct;
    public Sprite wrong;

    private int wrongTensCount = 1;
    private int wrongOnesCount = 1;

    public void random()
    {
        rnd = Random.Range(1, 100);
        units = rnd % 10;
        tens = rnd / 10;
        flag = 0;
        flag2 = 0;
        wrongOnesCount = 1;
        wrongTensCount = 1;

        for (int i = 0; i < tens; i++)
            Panel1[i].SetActive(true);
        for (int j = 0; j < units; j++)
            Panel2[j].SetActive(true);
        randomnumber.text = "The number is: " + rnd;
        Enter.text = "How many Tens are there?";
    }
    // Start is called before the first frame update
    void Start()
    {

        flag = 0;
        flag2 = 0;

    }

    private void OnEnable()
    {
        random();
    }

    // Update is called once per frame
    void Change()
    {

        for (int i = 0; i < tens; i++)
            Panel1[i].SetActive(false);
        for (int j = 0; j < units; j++)
            Panel2[j].SetActive(false);
        random();

    }


    public void fortens(int a)
    {
        if (a == tens)
        {
            flag = 1;
            StartCoroutine(DelayCorrect());
            Enter.text = "How many Ones are there?";
        }
        else
        {
            if (wrongTensCount == 3)
            {
                flag = 1;
                Enter.text = "Correct Answer is : " + tens;
                StartCoroutine(NextTens());
                wrongTensCount = 0;
            }
            else
            {
                wrongTensCount++;
                StartCoroutine(DelayWrong());
            }

        }
    }
    public void forunits(int a)
    {

        if (a == units)
        {
            flag2 = 1;
            StartCoroutine(DelayCorrect());
        }
        else
        {
            if (wrongOnesCount == 3)
            {
                Enter.text = "Correct Answer is : " + units;
                StartCoroutine(NextOnes());
                wrongOnesCount = 0;

            }
            else
            {
                wrongOnesCount++;
                StartCoroutine(DelayWrong());
            }
        }
    }


    IEnumerator DelayCorrect()
    {
        Calc.sprite = correct;
        Correct.SetActive(true);
        yield return new WaitForSeconds(delay);
        Correct.SetActive(false);
        if (flag2 == 1)
        {
            Change();
        }
    }

    IEnumerator DelayWrong()
    {
        Calc.sprite = wrong;
        Wrong.SetActive(true);
        yield return new WaitForSeconds(delay);
        Wrong.SetActive(false);
    }
    IEnumerator NextTens()
    {
        yield return new WaitForSeconds(2.0f);
        Enter.text = "How many Ones are there?";
    }
    IEnumerator NextOnes()
    {
        yield return new WaitForSeconds(2.0f);
        Enter.text = "How many Tens are there?";
        Change();
    }
}