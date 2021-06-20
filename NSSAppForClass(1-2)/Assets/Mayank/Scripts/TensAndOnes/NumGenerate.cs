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
    private float Delay = 0.5f;
    int tens;
    int units;
    public void random()
    {
        rnd = Random.Range(0, 99);
        units = rnd % 10;
        tens = rnd / 10;
        Debug.Log("Tens "+tens);
        Debug.Log("Units"+ units);
        flag = 0;
        flag2 = 0;
        Panel1[tens].SetActive(true);
        Panel2[units].SetActive(true);
        randomnumber.text = "The number is: " + rnd;
        Enter.text = "Enter Tens place";
    }
    // Start is called before the first frame update
    void Start()
    {
        random();
        flag = 0;
        flag2 = 0;
        

    }

    // Update is called once per frame
    void Update()
    {
        if ((flag == 1) && (flag2 ==1))
        {
            Panel1[tens].SetActive(false);
            Panel2[units].SetActive(false);

            random();
        }
    }


    public void fortens(int a)
    {
        if (a == tens)
        {

            Debug.Log("inside tens");
            StartCoroutine(DelayCorrect());
            Enter.text = "Enter Units place";
            flag = 1;
        }
        else
        {
            Debug.Log("Wrong Answer");
            StartCoroutine(DelayWrong());
        }
    }
    public void forunits(int a)
    {
        
        if (a == units)
        {
            flag2 = 1;
            Debug.Log("inside once");

            StartCoroutine(DelayCorrect());
        }
        else
        {
            Debug.Log("Wrong Answer");
            StartCoroutine(DelayWrong());
        }
    }


    IEnumerator DelayCorrect()
    {
        Debug.Log("Inside Delay");

        Correct.SetActive(true);
        yield return new WaitForSeconds(Delay);
        Debug.Log("Inside Delay");
        Correct.SetActive(false);
    }

    IEnumerator DelayWrong()
    {
        Debug.Log("Inside Delay");
        Wrong.SetActive(true);
        yield return new WaitForSeconds(Delay);
        Debug.Log("Inside Delay");
        Wrong.SetActive(false);
    }



}