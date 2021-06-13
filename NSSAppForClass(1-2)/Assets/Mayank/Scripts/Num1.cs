using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Num1 : MonoBehaviour
{
    public GameObject[] Panels;
    [HideInInspector] public int rnd;
    public Manager script;


    public void random()
    {
        rnd = Random.Range(0, 5);
        Debug.Log(rnd);
        //Debug.Log("Num1" + rnd);
        Panels[rnd].SetActive(true);
    }
    void Start()
    {
        random();
    }
    void Update()
    {
        if (script.flag1 == 1)
        {
            Debug.Log("Flag");
            Panels[rnd].SetActive(false);
            script.flag1 = 0;
            random();

        }
    }

}