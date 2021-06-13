using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelsSpawn: MonoBehaviour
{
    public GameObject[] Panels;
    public int rnd;
    int i;
    public void random()
    {
        rnd = Random.Range(1, 10);
       // Debug.Log("Spawn");
        //Debug.Log(rnd);
        for ( i=0; i<rnd; i++)
        {
            Panels[i].SetActive(true);
        }
        
    }
    void Start()
    {
        random();
    }

    
}