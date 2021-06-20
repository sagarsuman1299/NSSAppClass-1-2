using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Submit : MonoBehaviour
{
    public Text txt;
    public CheckValue cv;

    public void submitted()
    {
        cv.check(txt.text);
    }
}
