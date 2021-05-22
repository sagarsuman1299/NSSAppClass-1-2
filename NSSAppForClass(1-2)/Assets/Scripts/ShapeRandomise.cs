using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using System.IO;

public class ShapeRandomise : MonoBehaviour
{
    int t;
    public GameObject[] Ques;
    public Text HeadingText,BottomText;
    private string temporaryText;
    private string []ShapeTexts=new string[] {"Choose the Circle","Choose the Triangle","Choose the Square","Choose the Rectangle"};
    
    private void Start()
    {
        NumberRandomise();
        HeadingText.text = ShapeTexts[0];
    }
    private void Update()
    {
      //  if(temporaryText==)
    }
    public void Circle()
    {
        temporaryText = ShapeTexts[0];
        if(HeadingText.text==temporaryText)
        {
            BottomText.text = "Correct Now Try The Next One";
            StartCoroutine(WaitForTime());
            NumberRandomise();
        }
        else
        {
            BottomText.text = "Incorrect Please Try Again";
            StartCoroutine(WaitForTime());
        }
    }
    public void Triangle()
    {
        temporaryText = ShapeTexts[1];
        if (HeadingText.text == temporaryText)
        {
            BottomText.text = "Correct Now Try The Next One";
            StartCoroutine(WaitForTime());
            NumberRandomise();
        }
        else
        {
            BottomText.text = "Incorrect Please Try Again";
            StartCoroutine(WaitForTime());
        }
    }
    public void Square()
    {
        temporaryText = ShapeTexts[2];
        if (HeadingText.text == temporaryText)
        {
            BottomText.text = "Correct Now Try The Next One";
            StartCoroutine(WaitForTime());
            NumberRandomise();
        }
        else
        {
            BottomText.text = "Incorrect Please Try Again";
            StartCoroutine(WaitForTime());
        }
    }
    public void Rectangle()
    {
        temporaryText = ShapeTexts[3];
        if (HeadingText.text == temporaryText)
        {
            BottomText.text = "Correct Now Try The Next One";
            StartCoroutine(WaitForTime());
            NumberRandomise();
        }
        else
        {
            BottomText.text = "Incorrect Please Try Again";
            StartCoroutine(WaitForTime());
        }
    }
    public void NumberRandomise()
    {
        t = Random.Range(1, 4);
        if (t==1)
        {
            HeadingText.text = ShapeTexts[Random.Range(0, 3)];
            Ques[0].SetActive(true);
            Ques[1].SetActive(false);
            Ques[2].SetActive(false);
        }
        if (t == 2)
        {
            HeadingText.text = ShapeTexts[Random.Range(0, 3)];
            Ques[0].SetActive(false);
            Ques[1].SetActive(true);
            Ques[2].SetActive(false);
        }
        if (t == 3)
        {
            HeadingText.text = ShapeTexts[Random.Range(0, 3)];
            Ques[0].SetActive(false);
            Ques[1].SetActive(false);
            Ques[2].SetActive(true);
        }
    }
   public IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(2);
        BottomText.text = "_______________";
    }

}
