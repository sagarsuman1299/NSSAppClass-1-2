using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class victory1 : MonoBehaviour
{
    public int poitstowin;
    private int currentpoints = 0;
    public GameObject[] arr;
    int n = 0;
    public int NoOfQuestions;
    public GameObject alldone;
    public Text correct;

    void Start()
    {
        arr[n].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentpoints == poitstowin)
        {
            //transform.GetChild(0).gameObject.SetActive(true);
            StartCoroutine(newlevel());
        }

    }
    public void AddPoints()
    {
        currentpoints++;
    }
    IEnumerator newlevel()
    {
        currentpoints = 0;
        correct.text = "CORRECT";
        yield return new WaitForSeconds(1);
        if (n < (NoOfQuestions-1))
        {
            arr[n].SetActive(false);
            n++;
            arr[n].SetActive(true);
        }
        else if(n==(NoOfQuestions-1))
        {
            arr[n].SetActive(false);
            alldone.SetActive(true);
        }
        correct.text = "";
    }
}