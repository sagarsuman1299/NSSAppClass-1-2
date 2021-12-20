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
    public Text showAnswer;
    int wrongCount = 1;

    string ans;

    private void OnEnable()
    {

        tmp.text = "";
    }

    public void check(string str)
    {
        if (str == ((pp.total) + ""))
        {
            tmp.text = "";
            ans = "CORRECT";
            StartCoroutine("showCorrect");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            if (wrongCount == 3)
            {
                showAnswer.text = "Correct Answer is : " + (pp.total) + "";
                wrongCount = 1;
                StartCoroutine("Next");

            }
            else
            {
                wrongCount++;
                tmp.text = "";
                ans = "INCORRECT";
                txt.text = "";
                StartCoroutine("showRes");

            }

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
        wrongCount = 1;
        tmp.text = "";
        txt.text = "";
        pp.OnEnable();
    }
    IEnumerator Next()
    {

        yield return new WaitForSeconds(2);
        tmp.text = "";
        txt.text = "";
        showAnswer.text = "";
        pp.OnEnable();
    }
}
