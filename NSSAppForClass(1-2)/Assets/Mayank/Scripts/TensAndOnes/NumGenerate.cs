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
    public Image Calc;
    public Sprite correct;
    public Sprite wrong;
    //public Image[] obj;
    //public Sprite[] sprite1;
    //public Sprite[] sprite2;

    public void random()
    {
        rnd = Random.Range(1, 100);
        units = rnd % 10;
        tens = rnd / 10;
        Debug.Log("Tens "+tens);
        Debug.Log("Units"+ units);
        flag = 0;
        flag2 = 0;
        //SpriteChanger();
        for (int i =0; i<tens; i++)
            Panel1[i].SetActive(true);
        for (int j = 0; j < units; j++)
            Panel2[j].SetActive(true);
        randomnumber.text = "The number is: " + rnd;
        Enter.text = "How many Tens are there?";
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
            for (int i = 0; i < tens; i++)
                Panel1[i].SetActive(false);
            for (int j = 0; j < units; j++)
                Panel2[j].SetActive(false);
            random();
        }
    }


    public void fortens(int a)
    {
        if (a == tens)
        {

            Debug.Log("inside tens");
            StartCoroutine(DelayCorrect());
            Enter.text = "How many Ones are there?";
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

    /*
    void SpriteChanger()
    {
        int r = Random.Range(0, sprite1.Length);
        for (int i = 0; i<9 ; i++)
        {
            obj[i].sprite = sprite1[r];
            obj[i+9].sprite = sprite2[r];
        }
    }
    */

    IEnumerator DelayCorrect()
    {
        Calc.sprite = correct;

        Correct.SetActive(true);
        yield return new WaitForSeconds(Delay);
        Debug.Log("Inside Delay");
        Correct.SetActive(false);
    }

    IEnumerator DelayWrong()
    {
        Calc.sprite = wrong;
        Wrong.SetActive(true);
        yield return new WaitForSeconds(Delay);
        Debug.Log("Inside Delay");
        Wrong.SetActive(false);
    }



}