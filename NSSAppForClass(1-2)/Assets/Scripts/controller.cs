using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UIElements;

public class controller : MonoBehaviour
{
    public GameObject Mainmenu, Class1SubjectList, Class2SubjectList;
    public GameObject []Class1Subject; //3subjects
    public GameObject[] Class2Subject; //3subjects
    public GameObject[] Class1Panels; //list of english,science,maths
    public GameObject[] Class2Panels;//list of english,science,maths
    public GameObject Background;
    private int i;

    void Update()
    {
        
    }

    public void DeActivateAll()
    {
        
     if(i==0)
    {
        i = 0;
    }
   if(i==1)
    {
        i = 0;
        Mainmenu.SetActive(true);
        Class1SubjectList.SetActive(false);
    }
   if(i==2)
    {
        i = 0;
        Mainmenu.SetActive(true);
        Class2SubjectList.SetActive(false);
    }
 
    if(i==3 || i==4 || i==5)
    {
        Class1Subject[i-3].SetActive(false);
        i = 1;
        Class1SubjectList.SetActive(true);
        
    }
        if (i == 6 || i == 7 || i == 8)
        {
            Class1Subject[i - 6].SetActive(false);
            i = 1;
            Class1SubjectList.SetActive(true);
            
        }
        if (i == 9 || i ==10 || i == 11 || i == 12 || i == 13 || i == 14 || i == 15 || i == 16 || i == 17 || i == 18 || i == 19 || i==20 || i==21)
        {
            Class1Panels[i - 9].SetActive(false);
            i = 3;
            Class1Subject[0].SetActive(true);
            
        }
      
    }


    public void MainMenu()
    {
        i = 0;
    }
    public void Class1Screen()
    {
        i = 1;
        Mainmenu.SetActive(false);
        Class1SubjectList.SetActive(true);
    }
    public void Class2Screen()
    {
        i = 2;
        Mainmenu.SetActive(false);
        Class2SubjectList.SetActive(true);
    }
   // class 1 maths,science,english starts
    public void Class1Maths()
    {
        i =3;
        Class1SubjectList.SetActive(false);
        Class1Subject[0].SetActive(true);
    }
    public void Class1Science()
    {
        i = 4;
        Class1SubjectList.SetActive(false);
        Class1Subject[1].SetActive(true);
    }
    public void Class1English()
    {
        i = 5;
        Class1SubjectList.SetActive(false);
        Class1Subject[2].SetActive(true);
    }
    // class 1 maths,science,english ends
    public void Class2Maths()
    {
        i = 6;
        Class2SubjectList.SetActive(false);
        Class2Subject[0].SetActive(true);
    }
    public void Class2Science()
    {
        i = 7;
        Class2SubjectList.SetActive(false);
        Class2Subject[1].SetActive(true);
    }
    public void Class2English()
    {
        i = 8;
        Class2SubjectList.SetActive(false);
        Class2Subject[2].SetActive(true);
    }
   public void Class1Panel1() 
    {
        i = 9;
        Class1Subject[0].SetActive(false);
        Class1Panels[0].SetActive(true);

    }
    public void Class1Panel2()
    {
        i = 10;
        Class1Subject[0].SetActive(false);
        Class1Panels[1].SetActive(true);
    }
    public void Class1Panel3()
    {
        i = 11;
        Class1Subject[0].SetActive(false);
        Class1Panels[2].SetActive(true);

    }
    public void Class1Panel4()
    {
        i = 12;
        Class1Subject[0].SetActive(false);
        Class1Panels[3].SetActive(true);
    }
    public void Class1Panel5()
    {
        i = 13;
        Class1Subject[0].SetActive(false);
        Class1Panels[4].SetActive(true);

    }
    public void Class1Panel6()
    {
        i = 14;
        Class1Subject[0].SetActive(false);
        Class1Panels[5].SetActive(true);
    }
    public void Class1Panel7()
    {
        i = 15;
        Class1Subject[0].SetActive(false);
        Class1Panels[6].SetActive(true);

    }
    public void Class1Panel8()
    {
        i = 16;
        Class1Subject[0].SetActive(false);
        Class1Panels[7].SetActive(true);
    }

    public void Class1Panel9()
    {
        i = 17;
        Class1Subject[0].SetActive(false);
        Class1Panels[8].SetActive(true);
    }
    public void Class1Panel10()
    {
        i = 18;
        Class1Subject[0].SetActive(false);
        Class1Panels[9].SetActive(true);

    }
    public void Class1Panel11()
    {
        i = 19;
        Class1Subject[0].SetActive(false);
        Class1Panels[10].SetActive(true);
    }
    public void Class1Panel12()
    {
        i = 20;
        Class1Subject[0].SetActive(false);
        Class1Panels[11].SetActive(true);

    }
    public void Class1Panel13()
    {
        i = 21;
        Class1Subject[0].SetActive(false);
        Class1Panels[12].SetActive(true);
    }


    // .............Safety Section Ends................. 


    /*public GameObject Mainmenu, Class1SubjectList, Class2SubjectList, UKGSubjectList;
    public GameObject NEnglish,NMath,NGeneralAwareness,LEnglish,LMath,LGeneralAwareness,UEnglish,UMath,UGeneralAwareness;
    public GameObject NE1,NE2,NE3,NE4,NE5,NM1,NM2,NM3,NM4,NG1,NG2,NG3,NG4,NG5,NG6;
    public GameObject LE1, LE2, LE3, LE4, LM1, LM2, LM3, LM4, LG1, LG2, LG3, LG4, LG5, LG6;
    public GameObject UE1, UE2, UE3, UE4, UE5, UM1, UM2, UM3, UM4,UM5,UM6,UG1,UG2, UG3, UG4, UG5, UG6;*/
}
