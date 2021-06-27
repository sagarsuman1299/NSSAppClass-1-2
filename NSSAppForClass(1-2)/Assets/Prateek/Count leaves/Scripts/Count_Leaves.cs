using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count_Leaves : MonoBehaviour
{
    public GameObject[] branches;
    public GameObject[] leaves1;
    public GameObject[] leaves2;
    public GameObject[] EmptyObjs;

    public GameObject textAr;

    public GameObject winImg;
    public GameObject winTxt;

    int count = 0;

    int Generated;
    // Start is called before the first frame update
    void Start()
    {
        StartFun();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartFun()
    {
        count = 0;
        textAr.GetComponent<UnityEngine.UI.Text>().text = "";
        winTxt.GetComponent<UnityEngine.UI.Text>().text = "";

        Generated = Random.Range(21, 101);
        Debug.Log(Generated);

        BranchEnabler();
        LeafEnabler();
    }

    public void BranchEnabler()
    {
        if(Generated >= 21)
        {
            EmptyObjs[0].SetActive(true);
            branches[2].SetActive(true);
        }
        if(Generated >= 31)
        {
            EmptyObjs[1].SetActive(true);
            branches[3].SetActive(true);
        }
        if(Generated >= 41)
        {
            EmptyObjs[2].SetActive(true);
            branches[4].SetActive(true);
        }
        if(Generated >= 51)
        {
            EmptyObjs[3].SetActive(true);
            branches[5].SetActive(true);
        }
        if(Generated >= 61)
        {
            EmptyObjs[4].SetActive(true);
            branches[6].SetActive(true);
        }
        if(Generated >= 71)
        {
            EmptyObjs[5].SetActive(true);
            branches[7].SetActive(true);
        }
        if(Generated >= 81)
        {
            EmptyObjs[6].SetActive(true);
            branches[8].SetActive(true);
        }
        if(Generated >= 91)
        {
            EmptyObjs[7].SetActive(true);
            branches[9].SetActive(true);
        }
    }

    public void LeafEnabler()
    {
        if(Generated <= 60)
        {
            for(int i = 0; i < (Generated-20); i++)
            {
                leaves1[i].SetActive(true);
            }
        }

        if(Generated > 60)
        {
            for(int i = 0; i < 40; i++)
            {
                leaves1[i].SetActive(true);
            }

            for(int j = 0; j < (Generated-60); j++)
            {
                leaves2[j].SetActive(true);
            }
        }
    }

    public void Press1()
    {
        if(count < 2)
        {
            textAr.GetComponent<UnityEngine.UI.Text>().text = textAr.GetComponent<UnityEngine.UI.Text>().text + 1.ToString();
            count += 1;
        }

        if(count == 2)
        {
            WinCheck();
        }
    }
    public void Press2()
    {
        if(count < 2)
        {
            textAr.GetComponent<UnityEngine.UI.Text>().text = textAr.GetComponent<UnityEngine.UI.Text>().text + 2.ToString();
            count += 1;
        }

        if(count == 2)
        {
            WinCheck();
        }
    }
    public void Press3()
    {
        if(count < 2)
        {
            textAr.GetComponent<UnityEngine.UI.Text>().text = textAr.GetComponent<UnityEngine.UI.Text>().text + 3.ToString();
            count += 1;
        }

        if(count == 2)
        {
            WinCheck();
        }
    }
    public void Press4()
    {
        if(count < 2)
        {
            textAr.GetComponent<UnityEngine.UI.Text>().text = textAr.GetComponent<UnityEngine.UI.Text>().text + 4.ToString();
            count += 1;
        }

        if(count == 2)
        {
            WinCheck();
        }
    }
    public void Press5()
    {
        if(count < 2)
        {
            textAr.GetComponent<UnityEngine.UI.Text>().text = textAr.GetComponent<UnityEngine.UI.Text>().text + 5.ToString();
            count += 1;
        }

        if(count == 2)
        {
            WinCheck();
        }
    }
    public void Press6()
    {
        if(count < 2)
        {
            textAr.GetComponent<UnityEngine.UI.Text>().text = textAr.GetComponent<UnityEngine.UI.Text>().text + 6.ToString();
            count += 1;
        }

        if(count == 2)
        {
            WinCheck();
        }
    }
    public void Press7()
    {
        if(count < 2)
        {
            textAr.GetComponent<UnityEngine.UI.Text>().text = textAr.GetComponent<UnityEngine.UI.Text>().text + 7.ToString();
            count += 1;
        }

        if(count == 2)
        {
            WinCheck();
        }
    }
    public void Press8()
    {
        if(count < 2)
        {
            textAr.GetComponent<UnityEngine.UI.Text>().text = textAr.GetComponent<UnityEngine.UI.Text>().text + 8.ToString();
            count += 1;
        }

        if(count == 2)
        {
            WinCheck();
        }
    }
    public void Press9()
    {
        if(count < 2)
        {
            textAr.GetComponent<UnityEngine.UI.Text>().text = textAr.GetComponent<UnityEngine.UI.Text>().text + 9.ToString();
            count += 1;
        }

        if(count == 2)
        {
            WinCheck();
        }
    }
    public void Press0()
    {
        if(count < 2)
        {
            textAr.GetComponent<UnityEngine.UI.Text>().text = textAr.GetComponent<UnityEngine.UI.Text>().text + 0.ToString();
            count += 1;
        }

        if(count == 2)
        {
            WinCheck();
        }
    }

    public void Erase()
    {
        textAr.GetComponent<UnityEngine.UI.Text>().text = "";
        count = 0;
    }

    public void WinCheck()
    {
        if(int.Parse(textAr.GetComponent<UnityEngine.UI.Text>().text) == Generated)
        {
            winTxt.GetComponent<UnityEngine.UI.Text>().text = "CORRECT";
            StartCoroutine(ResetQues());
        }
        else
        {
            winTxt.GetComponent<UnityEngine.UI.Text>().text = "INCORRECT";
            StartCoroutine(ResetQues());
        }
    }

    IEnumerator ResetQues()
    {
        for(int i = 2; i < 10; i++)
        {
            branches[i].SetActive(false);
        }

        for(int i = 0; i < 8; i++)
        {
            EmptyObjs[i].SetActive(false);
        }

        for(int j = 0; j < 40; j++)
        {
            leaves1[j].SetActive(false);
            leaves2[j].SetActive(false);
        }

        yield return new WaitForSeconds(2);
        StartFun();
    }
}
