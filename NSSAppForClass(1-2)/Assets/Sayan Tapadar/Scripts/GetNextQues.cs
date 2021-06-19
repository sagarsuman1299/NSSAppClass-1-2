using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetNextQues : MonoBehaviour
{
    public HashSet<GameObject> que=new HashSet<GameObject>();
    public QnA qa;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hemlooo");
        que.Clear();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(que.Count);
        if (que.Count == 4)
        {
            que.Clear();
            qa.ShowQuestion();
        }
    }
}
