using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetNextQues : MonoBehaviour
{
    public HashSet<GameObject> que=new HashSet<GameObject>();
    public QnA qa;

    public LineRenderer[] lrs;
    public TextMeshProUGUI tmp;

    // Start is called before the first frame update
    void Start()
    {
        que.Clear();
    }

    // Update is called once per frame
    void Update()
    {
        if (que.Count == 4)
        {
            foreach(LineRenderer lr in lrs)
            {
                lr.SetPosition(0, new Vector3(0, 0, 0));
                lr.SetPosition(1, new Vector3(0, 0, 1));
            }
            tmp.text = "";
            que.Clear();
            qa.ShowQuestion();
        }
    }
}
