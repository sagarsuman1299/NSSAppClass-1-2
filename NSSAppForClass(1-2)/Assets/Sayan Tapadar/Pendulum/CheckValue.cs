using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class CheckValue : MonoBehaviour
{
    public Pendulum pp;
    public TextMeshProUGUI tmp;
    public Text txt;

    string ans;

    private void Start()
    {
        tmp.text = "";
    }

    public void check(string str)
    {
        if (str == ((pp.total) + ""))
        {
            tmp.text = "";
            ans= "CORRECT";
            StartCoroutine("showCorrect");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            tmp.text = "";
            ans= "INCORRECT";
            txt.text = "";
            StartCoroutine("showRes");
        }
    }

    IEnumerator showRes()
    {
        tmp.text = ans;
        yield return new WaitForSeconds(2);
        tmp.text = "";
    }

    IEnumerator showCorrect()
    {
        tmp.text = ans;
        yield return new WaitForSeconds(2);
        tmp.text = "";
        txt.text = "";
        pp.Start();
    }
}
