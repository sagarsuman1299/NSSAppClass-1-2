using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Num2 : MonoBehaviour
{
    public GameObject[] Panels;
    [HideInInspector]public int rnd;
    public Manager script2;

    public void random()
    {
        rnd = Random.Range(0, 6);
        //Debug.Log("Num2 " + rnd);
        Panels[rnd].SetActive(true);
    }
    void Start()
    {
        random();
    }

    void Update()
    {
        if (script2.flag == 1)
        {
            Debug.Log("Flag2");
            Panels[rnd].SetActive(false);
            script2.flag = 0;
            random();
        }
    }

}
