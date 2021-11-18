using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    // Start is called before the first frame update
    public static int cor;
    public static int wr;

    public Text remark;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void correct()
    {
        cor = 1;
        remark.text = "Correct, Now solve next!";

    }

    public void wrong()
    {
        wr=1;
        remark.text = "Incorrect, Try again";
    }
}
