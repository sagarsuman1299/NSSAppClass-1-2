using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CheckValue : MonoBehaviour
{
    public Pendulum pp;
    public TextMeshProUGUI tmp;

    string ans;

    private void Start()
    {
        tmp.text = "";
    }

    public void check(string str)
    {
        if (str == ((pp.total + 1) + ""))
        {
            Debug.Log("yayy");
            tmp.text = "";
            ans= "CORRECT";
            StartCoroutine("showRes");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            tmp.text = "";
            ans= "INCORRECT";
            StartCoroutine("showRes");
            Debug.Log("no");
        }
    }

    IEnumerator showRes()
    {
        tmp.text = ans;
        yield return new WaitForSeconds(2);
        tmp.text = "";
    }
}
