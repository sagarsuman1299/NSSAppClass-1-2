using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manage : MonoBehaviour
{
    // Start is called before the first frame update

    
    public GameObject []  questions;
    int prev;
    

    void Start()
    {
        for(int i=0;i<questions.Length;i++)
        {
            questions[i].SetActive(false);
        }
        int rnd = Random.Range(0,questions.Length);
        prev = rnd;
        questions[rnd].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        next();
    }

    public void next()
    {
        if(Click.cor==1)
        {
            Click.cor = 0;

            for(int i=0;i<questions.Length;i++)
            {
                questions[i].SetActive(false);
            }
            int rnd = Random.Range(0,questions.Length);
            while(prev==rnd)
            {
                rnd = Random.Range(0,questions.Length);
                
            }

            prev = rnd;
            questions[rnd].SetActive(true);
        }

        if(Click.wr==1)
        {
            Click.wr = 0;
        }




    }
}
