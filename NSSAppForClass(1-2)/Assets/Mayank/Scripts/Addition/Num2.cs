using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Num2 : MonoBehaviour
{
    public GameObject[] Panels;
    [HideInInspector] public int rnd;

    public void random()
    {
        rnd = Random.Range(0, 6);
        Panels[rnd].SetActive(true);
    }
    void OnEnable()
    {
        random();
    }

    public void PanelUpdate()
    {
        Panels[rnd].SetActive(false);
        random();
    }
}
