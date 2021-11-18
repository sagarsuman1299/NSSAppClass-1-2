using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UIElements;

public class controller : MonoBehaviour
{
    public GameObject Mainmenu, Class1SubjectList, Class2SubjectList;
    public GameObject[] Class1Subject; //3subjects
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
        if (i == 0)
        {
            i = 0;
        }
        if (i == 1)
        {
            i = 0;
            Mainmenu.SetActive(true);
            Class1SubjectList.SetActive(false);
        }
        if (i == 2)
        {
            i = 0;
            Mainmenu.SetActive(true);
            Class2SubjectList.SetActive(false);
        }

        if (i == 3 || i == 4 || i == 5)
        {
            Class1Subject[i - 3].SetActive(false);
            i = 1;
            Class1SubjectList.SetActive(true);

        }
        if (i == 6 || i == 7 || i == 8)
        {
            Class1Subject[i - 6].SetActive(false);
            i = 1;
            Class1SubjectList.SetActive(true);

        }
        if (i == 9 || i == 10 || i == 11 || i == 12 || i == 13 || i == 14 || i == 15 || i == 16 || i == 17 || i == 18 || i == 19 || i == 20 || i == 21 || i == 22 || i == 23 || i == 24 || i == 25 || i == 26
            || i == 27 || i == 28 || i == 29 || i == 30 || i == 31 || i == 32 || i == 33)
        {
            Class1Panels[i - 9].SetActive(false);
            i = 3;
            Class1Subject[0].SetActive(true);
        }

        if (i == 34 || i == 35 || i == 35 || i == 36 || i == 37 || i == 38 || i == 39 || i == 40 || i == 41 || i == 42 || i == 43 || i == 44 || i == 45 || i == 46 || i == 47 || i == 48 || i == 49 || i == 50
            || i == 51 || i == 52 || i == 53 || i == 54 || i == 55 || i == 56 || i == 57 || i == 58 || i == 59 || i == 60 || i == 61)
        {
            Class1Panels[i - 9].SetActive(false);
            i = 4;
            Class1Subject[1].SetActive(true);
        }
    }

    //Class and sub selection

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

    // Class 1 sub selection

    public void Class1Maths()
    {
        i = 3;
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

    // Class 2 sub selection

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

    ///////////////////////////
    /// Class 1 Maths panels
    ///////////////////////////

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
    public void Class1Panel14()
    {
        i = 22;
        Class1Subject[0].SetActive(false);
        Class1Panels[13].SetActive(true);
    }
    public void Class1Panel15()
    {
        i = 23;
        Class1Subject[0].SetActive(false);
        Class1Panels[14].SetActive(true);
    }
    public void Class1Panel16()
    {
        i = 24;
        Class1Subject[0].SetActive(false);
        Class1Panels[15].SetActive(true);
    }
    public void Class1Panel17()
    {
        i = 25;
        Class1Subject[0].SetActive(false);
        Class1Panels[16].SetActive(true);
    }
    public void Class1Panel18()
    {
        i = 26;
        Class1Subject[0].SetActive(false);
        Class1Panels[17].SetActive(true);
    }
    public void Class1Panel19()
    {
        i = 27;
        Class1Subject[0].SetActive(false);
        Class1Panels[18].SetActive(true);
    }
    public void Class1Panel20()
    {
        i = 28;
        Class1Subject[0].SetActive(false);
        Class1Panels[19].SetActive(true);
    }
    public void Class1Panel21()
    {
        i = 29;
        Class1Subject[0].SetActive(false);
        Class1Panels[20].SetActive(true);
    }
    public void Class1Panel22()
    {
        i = 30;
        Class1Subject[0].SetActive(false);
        Class1Panels[21].SetActive(true);
    }
    public void Class1Panel23()
    {
        i = 31;
        Class1Subject[0].SetActive(false);
        Class1Panels[22].SetActive(true);
    }
    public void Class1Panel24()
    {
        i = 32;
        Class1Subject[0].SetActive(false);
        Class1Panels[23].SetActive(true);
    }
    public void Class1Panel25()
    {
        i = 33;
        Class1Subject[0].SetActive(false);
        Class1Panels[24].SetActive(true);
    }

    ///////////////////////////
    /// Class 1 Science panels
    ///////////////////////////

    public void Class1Panel26()
    {
        i = 34;
        Class1Subject[1].SetActive(false);
        Class1Panels[25].SetActive(true);
    }
    public void Class1Panel27()
    {
        i = 35;
        Class1Subject[1].SetActive(false);
        Class1Panels[26].SetActive(true);
    }
    public void Class1Panel28()
    {
        i = 36;
        Class1Subject[1].SetActive(false);
        Class1Panels[27].SetActive(true);
    }
    public void Class1Panel29()
    {
        i = 37;
        Class1Subject[1].SetActive(false);
        Class1Panels[28].SetActive(true);
    }
    public void Class1Panel30()
    {
        i = 38;
        Class1Subject[1].SetActive(false);
        Class1Panels[29].SetActive(true);
    }
    public void Class1Panel31()
    {
        i = 39;
        Class1Subject[1].SetActive(false);
        Class1Panels[30].SetActive(true);
    }
    public void Class1Panel32()
    {
        i = 40;
        Class1Subject[1].SetActive(false);
        Class1Panels[31].SetActive(true);
    }
    public void Class1Panel33()
    {
        i = 41;
        Class1Subject[1].SetActive(false);
        Class1Panels[32].SetActive(true);
    }
    public void Class1Panel34()
    {
        i = 42;
        Class1Subject[1].SetActive(false);
        Class1Panels[33].SetActive(true);
    }
    public void Class1Panel35()
    {
        i = 43;
        Class1Subject[1].SetActive(false);
        Class1Panels[34].SetActive(true);
    }
    public void Class1Panel36()
    {
        i = 44;
        Class1Subject[1].SetActive(false);
        Class1Panels[35].SetActive(true);
    }
    public void Class1Panel37()
    {
        i = 45;
        Class1Subject[1].SetActive(false);
        Class1Panels[36].SetActive(true);
    }
    public void Class1Panel38()
    {
        i = 46;
        Class1Subject[1].SetActive(false);
        Class1Panels[37].SetActive(true);
    }
    public void Class1Panel39()
    {
        i = 47;
        Class1Subject[1].SetActive(false);
        Class1Panels[38].SetActive(true);
    }
    public void Class1Panel40()
    {
        i = 48;
        Class1Subject[1].SetActive(false);
        Class1Panels[39].SetActive(true);
    }
    public void Class1Panel41()
    {
        i = 49;
        Class1Subject[1].SetActive(false);
        Class1Panels[40].SetActive(true);
    }
    public void Class1Panel42()
    {
        i = 50;
        Class1Subject[1].SetActive(false);
        Class1Panels[41].SetActive(true);
    }
    public void Class1Panel43()
    {
        i = 51;
        Class1Subject[1].SetActive(false);
        Class1Panels[42].SetActive(true);
    }
    public void Class1Panel44()
    {
        i = 52;
        Class1Subject[1].SetActive(false);
        Class1Panels[43].SetActive(true);
    }
    public void Class1Panel45()
    {
        i = 53;
        Class1Subject[1].SetActive(false);
        Class1Panels[44].SetActive(true);
    }
    public void Class1Panel46()
    {
        i = 54;
        Class1Subject[1].SetActive(false);
        Class1Panels[45].SetActive(true);
    }
    public void Class1Panel47()
    {
        i = 55;
        Class1Subject[1].SetActive(false);
        Class1Panels[46].SetActive(true);
    }
    public void Class1Panel48()
    {
        i = 56;
        Class1Subject[1].SetActive(false);
        Class1Panels[47].SetActive(true);
    }
    public void Class1Panel49()
    {
        i = 57;
        Class1Subject[1].SetActive(false);
        Class1Panels[48].SetActive(true);
    }
    public void Class1Panel50()
    {
        i = 58;
        Class1Subject[1].SetActive(false);
        Class1Panels[49].SetActive(true);
    }
    public void Class1Panel51()
    {
        i = 59;
        Class1Subject[1].SetActive(false);
        Class1Panels[50].SetActive(true);
    }
    public void Class1Panel52()
    {
        i = 60;
        Class1Subject[1].SetActive(false);
        Class1Panels[51].SetActive(true);
    }
    public void Class1Panel53()
    {
        i = 61;
        Class1Subject[1].SetActive(false);
        Class1Panels[52].SetActive(true);
    }


    // .............Safety Section Ends................. 


    /*public GameObject Mainmenu, Class1SubjectList, Class2SubjectList, UKGSubjectList;
    public GameObject NEnglish,NMath,NGeneralAwareness,LEnglish,LMath,LGeneralAwareness,UEnglish,UMath,UGeneralAwareness;
    public GameObject NE1,NE2,NE3,NE4,NE5,NM1,NM2,NM3,NM4,NG1,NG2,NG3,NG4,NG5,NG6;
    public GameObject LE1, LE2, LE3, LE4, LM1, LM2, LM3, LM4, LG1, LG2, LG3, LG4, LG5, LG6;
    public GameObject UE1, UE2, UE3, UE4, UE5, UM1, UM2, UM3, UM4,UM5,UM6,UG1,UG2, UG3, UG4, UG5, UG6;*/
}
