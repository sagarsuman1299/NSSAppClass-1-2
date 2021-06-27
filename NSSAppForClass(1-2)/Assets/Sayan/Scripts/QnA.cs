using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QnA : MonoBehaviour
{
    public GameObject[] gos;
    int i;

    private void Start()
    {
        i = 0;
        ShowQuestion();
    }

    public void ShowQuestion()
    {
        int pos = i;
        while (pos == i)
        {
            pos = Random.Range(0, gos.Length);
        }

        gos[i].SetActive(false);
        i = pos;
        gos[i].SetActive(true);

    }
}
