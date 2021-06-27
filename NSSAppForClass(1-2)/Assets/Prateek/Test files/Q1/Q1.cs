using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q1 : MonoBehaviour
{
    public GameObject[] Ans_space;                                                              //Array to hold the boxes where the answers have to be dragged
    public GameObject[] ques;                                                                   //Array to hold the text boxes containing questions

    public GameObject win;
    public GameObject current;
    public GameObject next;

    private void Update()
    {
        if((ques[0].transform.position.x - Ans_space[1].transform.position.x) <= 0.1 && (ques[1].transform.position.x - Ans_space[0].transform.position.x) <= 0.1)
        {
            win.SetActive(true);

            if(Input.GetMouseButtonDown(0))
            {
                next.SetActive(true);
                current.SetActive(false);
            }
        }
    }
}
