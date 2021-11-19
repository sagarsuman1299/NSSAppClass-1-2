using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum : MonoBehaviour
{
    public Animator anim;
    public int waitTime;
    public int max;
    public int total;


    public void OnEnable()
    {
        anim = gameObject.GetComponent<Animator>();

        total = Random.Range(1, max + 1);
        Debug.Log(total);
        StartCoroutine("waiting");
    }

    public void runAnim()
    {
        anim.SetTrigger("osc");
    }

    IEnumerator waiting()
    {
        yield return new WaitForSeconds(waitTime);
        Debug.Log("First one ends");
        for (int i = 1; i <= total; i++)
        {
            anim.SetTrigger("osc");
            //Debug.Log("Began");
            yield return new WaitForSeconds(waitTime);
            //Debug.Log("End");
        }
    }
}
