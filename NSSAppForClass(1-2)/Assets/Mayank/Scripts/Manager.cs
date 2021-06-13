using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public GameObject Correct;
    public GameObject Wrong;
    [HideInInspector]public int flag = 1;
    [HideInInspector]public int flag1 = 1;

    public void show(int rnd1, int rnd2, int value)
    {
        if (rnd1 + rnd2 == value)
        {
            flag = 1;
            flag1 = 1;
            //Debug.Log(true);
            Correct.SetActive(true);
            Wait();
            Correct.SetActive(false);

        }
        else

        {
            flag = 0;
            flag1 = 0;
            Wrong.SetActive(true);
            Wait();
            Wrong.SetActive(false);

        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5.0f);

        
    }
}
