using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Managerr : MonoBehaviour
{
   
    private int randomNumber;
    private int randomNumber1;
    private int randomNumber2;
    private int randomNumber3;
    private int randomNumber4;
    public Sprite[] qsnSprites;
    List<string> mylist;
    public string[] ansText;
    Image img;
    Text text;
    [HideInInspector]public Text qsn_Text;
    public LineRenderer[] lrs;
    GameObject temp;
    public GameObject correct_ans_panel;
    public GameObject wrong_ans_panel;
    public int correct_count = 0;
    
    [HideInInspector]public List<string> tags = new List<string>() { };

    void OnEnable()
    {
        
        mylist = new List<string>() { "AnsText1", "AnsText2", "AnsText3", "AnsText4" };
        qsn_Change();
       
    }
    void Update()
    {
        if (tags.Count == 4)
        {
            correct_count = 0;
            qsn_Change();
            tags.Clear();
        }
    }

    public void qsn_Change()
    {
        
        foreach (LineRenderer line in lrs)
        {
            line.SetPosition(0, new Vector3(0, 0, 0));
            line.SetPosition(1, new Vector3(0, 0, 1));
        }
        qsn_Text.text = "Match the following";
        //For Sprite
        randomNumber1 = Random.Range(0, qsnSprites.Length);
        temp = GameObject.Find("Room1");
        temp.tag = ansText[randomNumber1];
        img = temp.GetComponent<Image>();
        img.sprite = qsnSprites[randomNumber1];

        randomNumber = Random.Range(0, mylist.Count);
        temp = GameObject.Find(mylist[randomNumber]);
        mylist.RemoveAt(randomNumber);


        temp.tag = ansText[randomNumber1];
        text = temp.GetComponent<Text>();
        text.text = ansText[randomNumber1];
        
        
        randomNumber2 = Random.Range(0, qsnSprites.Length);
        while (randomNumber1 == randomNumber2)
        {
            randomNumber2 = Random.Range(0, qsnSprites.Length);
        }
        //For Sprite
        temp = GameObject.Find("Room2");
        temp.tag = ansText[randomNumber2];
        img = temp.GetComponent<Image>();
        img.sprite = qsnSprites[randomNumber2];
        // For text 
        randomNumber = Random.Range(0, mylist.Count);
        temp = GameObject.Find(mylist[randomNumber]);
        mylist.RemoveAt(randomNumber);
        temp.tag = ansText[randomNumber2];
        text = temp.GetComponent<Text>();
        text.text = ansText[randomNumber2];

        randomNumber3 = Random.Range(0, qsnSprites.Length);
        randomNumber4 = Random.Range(0, qsnSprites.Length);
        while (randomNumber1 == randomNumber3 || randomNumber2 == randomNumber3 ||randomNumber1 == randomNumber4 || randomNumber2 == randomNumber4 || randomNumber3 == randomNumber4)
        {
            randomNumber3 = Random.Range(0, qsnSprites.Length);
            randomNumber4 = Random.Range(0, qsnSprites.Length);
        }

        //For Sprite
        temp = GameObject.Find("Room3");
        temp.tag = ansText[randomNumber3];
        img = temp.GetComponent<Image>();
        img.sprite = qsnSprites[randomNumber3];
        // For text 
        randomNumber = Random.Range(0, mylist.Count);
        temp = GameObject.Find(mylist[randomNumber]);
        mylist.RemoveAt(randomNumber);
        temp.tag = ansText[randomNumber3];
        text = temp.GetComponent<Text>();
        text.text = ansText[randomNumber3];


        //For Sprite
        temp = GameObject.Find("Room4");
        temp.tag = ansText[randomNumber4];
        img = temp.GetComponent<Image>();
        img.sprite = qsnSprites[randomNumber4];
        // For text 
        randomNumber = Random.Range(0, mylist.Count);
        temp = GameObject.Find(mylist[randomNumber]);
        mylist.RemoveAt(randomNumber);
        temp.tag = ansText[randomNumber4];
        text = temp.GetComponent<Text>();
        text.text = ansText[randomNumber4];


        mylist = new List<string>() { "AnsText1", "AnsText2", "AnsText3", "AnsText4" };

    }
    public void Delay_correct()
    {
        StartCoroutine(DelayCorrect());
    }

    public void Delay_wrong()
    {
        StartCoroutine(DelayWrong());
    }

    IEnumerator DelayCorrect()
    {
        qsn_Text.text = "";
        correct_ans_panel.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        qsn_Text.text = "Match the following";
        correct_ans_panel.SetActive(false);

    }

    IEnumerator DelayWrong()
    {
        qsn_Text.text = "";
        wrong_ans_panel.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        qsn_Text.text = "Match the following";
        wrong_ans_panel.SetActive(false);

    }

}
