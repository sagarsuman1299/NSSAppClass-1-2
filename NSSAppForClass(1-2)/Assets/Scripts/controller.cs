using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UIElements;

public class controller : MonoBehaviour
{
    public GameObject Mainmenu, NurserySubjectList, LKGSubjectList, UKGSubjectList;
    public GameObject NEnglish,NMath,NGeneralAwareness,LEnglish,LMath,LGeneralAwareness,UEnglish,UMath,UGeneralAwareness;
    public GameObject NE1,NE2,NE3,NE4,NE5,NM1,NM2,NM3,NM4,NG1,NG2,NG3,NG4,NG5,NG6;
    public GameObject LE1, LE2, LE3, LE4, LM1, LM2, LM3, LM4, LG1, LG2, LG3, LG4, LG5, LG6;
    public GameObject UE1, UE2, UE3, UE4, UE5, UM1, UM2, UM3, UM4,UM5,UM6,UG1,UG2, UG3, UG4, UG5, UG6;
    //public GameObject ActiveScreen, InActiveScreen;
    public GameObject Background;
    private int i;
    //  public GameObject BackButton;

    //Safety Panel
    public GameObject AtHome, AtRoad, AtPlayground;
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
        NurserySubjectList.SetActive(false);
    }
   if(i==2)
    {
        i = 0;
        Mainmenu.SetActive(true);
        LKGSubjectList.SetActive(false);
    }
   if(i==3)
    {
        i = 0;
        Mainmenu.SetActive(true);
        UKGSubjectList.SetActive(false);
    }
    if(i==4)
    {
        i = 1;
        NurserySubjectList.SetActive(true);
        NEnglish.SetActive(false);
    }
    if(i==5)
    {
        i = 1;
        NurserySubjectList.SetActive(true);
        NMath.SetActive(false);
    }
    if(i==6)
    {
        i = 1;
        NurserySubjectList.SetActive(true);
       NGeneralAwareness.SetActive(false);
    }
    if(i==7)
    {
        i = 2;
        LKGSubjectList.SetActive(true);
        LEnglish.SetActive(false);
    }
    if(i==8)
    {
        i = 2;
        LKGSubjectList.SetActive(true);
        LMath.SetActive(false);
    }
    if(i==9)
    {
        i = 2;
        LKGSubjectList.SetActive(true);
        LGeneralAwareness.SetActive(false);
    }
    if(i==10)
    {
        i = 3;
        UKGSubjectList.SetActive(true);
        UEnglish.SetActive(false);
    }
    if(i==11)
    {
        i = 3;
        UKGSubjectList.SetActive(true);
        UMath.SetActive(false);
    }
    if(i==12)
    {
        i = 3;
        UKGSubjectList.SetActive(true);
        UGeneralAwareness.SetActive(false);
    }
    if(i==13)
    {
        i = 4;
        NEnglish.SetActive(true);
        NE1.SetActive(false);
    }
    if(i==14)
    {
        i = 4;
        NEnglish.SetActive(true);
        NE2.SetActive(false);
    }
   if(i==15)
    {
        i = 4;
        NEnglish.SetActive(true);
        NE3.SetActive(false);
    }
    if(i==16)
    {
        i = 4;
        NEnglish.SetActive(true);
        NE4.SetActive(false);
    }
    if(i==17)
    {
        i = 4;
        NEnglish.SetActive(true);
        NE5.SetActive(false);
            Background.SetActive(true);
        }
    if(i==18)
    {
        i = 5;
        NMath.SetActive(true);
        NM1.SetActive(false);
           
        }
    if(i==19)
    {
        i = 5;
        NMath.SetActive(true);
        NM2.SetActive(false);
    }
     if(i==20)
    {
        i = 05;
        NMath.SetActive(true);
        NM3.SetActive(false);
    }
    if(i==21)
    {
        i = 5;
        NMath.SetActive(true);
        NM4.SetActive(false);
    }
    if(i==22)
    {
        i = 6;
        NGeneralAwareness.SetActive(true);
       NG1.SetActive(false);
    }
    if(i==23)
    {
        i = 6;
        NGeneralAwareness.SetActive(true);
        NG2.SetActive(false);
    }
   if(i==24)
    {
        i = 6;
        NGeneralAwareness.SetActive(true);
        NG3.SetActive(false);
    }
    if(i==25)
    {
        i = 6;
        NGeneralAwareness.SetActive(true);
        NG4.SetActive(false);
    }
    if(i==26)
    {
        i = 6;
        NGeneralAwareness.SetActive(true);
        NG5.SetActive(false);
    }
    if(i==27)
    {
        i = 6;
        NGeneralAwareness.SetActive(true);
        NG6.SetActive(false);
         //   Background.SetActive(true);
        }
    if(i==28)
    {
        i = 7;
        LEnglish.SetActive(true);
        LE1.SetActive(false);
    }
    if(i==29)
    {
        i = 7;
        LEnglish.SetActive(true);
        LE2.SetActive(false);
    }
    if(i==30)
    {
        i = 7;
        LEnglish.SetActive(true);
        LE3.SetActive(false);
    }
    if(i==31)
    {
        i = 7;
        LEnglish.SetActive(true);
        LE4.SetActive(false);
    }
   if(i==32)
    {
        i = 8;
        LMath.SetActive(true);
        LM1.SetActive(false);
    }
    if(i==33)
    {
        i = 8;
        LMath.SetActive(true);
        LM2.SetActive(false);
    }
    if(i==34)
    {
        i = 8;
        LMath.SetActive(true);
        LM3.SetActive(false);
    }
    if(i==35)
    {
        i = 8;
        LMath.SetActive(true);
        LM4.SetActive(false);
    }
   if(i==36)
    {
        i = 9;
        LGeneralAwareness.SetActive(true);
        LG1.SetActive(false);
    }
    if(i==37)
    {
        i = 9;
        LGeneralAwareness.SetActive(true);
        LG2.SetActive(false);
    }
    if(i==38)
    {
        i = 9;
        LGeneralAwareness.SetActive(true);
        LG3.SetActive(false);
    }
    if(i==39)
    {
        i = 9;
        LGeneralAwareness.SetActive(true);
        LG4.SetActive(false);
    }
    if(i==40)
    {
        i = 9;
        LGeneralAwareness.SetActive(true);
        LG5.SetActive(false);
    }
    if(i==41)
    {
        i = 9;
        LGeneralAwareness.SetActive(true);
        LG6.SetActive(false);
    }
    if(i==42)
    {
        i = 10;
        UEnglish.SetActive(true);
        UE1.SetActive(false);
    }
    if(i==43)
    {
        i = 10;
        UEnglish.SetActive(true);
        UE2.SetActive(false);
    }
   if(i==44)
    {
        i = 10;
        UEnglish.SetActive(true);
        UE3.SetActive(false);
    }
    if(i==45)
    {
        i = 10;
        UEnglish.SetActive(true);
        UE4.SetActive(false);
    }
    if(i==46)
    {
        i = 10;
        UEnglish.SetActive(true);
        UE5.SetActive(false);
    }
    if(i==47)
    {
        i = 11;
        UMath.SetActive(true);
        UM1.SetActive(false);
    }
    if(i==48)
    {
        i = 11;
        UMath.SetActive(true);
        UM2.SetActive(false);
    }
    if(i==49)
    {
        i = 11;
        UMath.SetActive(true);
        UM3.SetActive(false);
    }
    if(i==50)
    {
        i = 11;
        UMath.SetActive(true);
        UM4.SetActive(false);
    }
     if(i==51)
    {
        i = 11;
        UMath.SetActive(true);
        UM5.SetActive(false);
    }
    if(i==52)
    {
        i = 11;
        UMath.SetActive(true);
        UM6.SetActive(false);
    }
     if(i==53)
    {
        i = 12;
        UGeneralAwareness.SetActive(true);
        UG1.SetActive(false);
    }
     if(i==54)
    {
        i = 12;
        UGeneralAwareness.SetActive(true);
        UG2.SetActive(false);
    }
     if(i==55)
    {
        i = 12;
        UGeneralAwareness.SetActive(true);
        UG3.SetActive(false);
    }
     if(i==56)
    {
        i = 12;
        UGeneralAwareness.SetActive(true);
        UG4.SetActive(false);
    }
     if(i==57)
    {
        i = 12;
        UGeneralAwareness.SetActive(true);
        UG5.SetActive(false);
            Background.SetActive(true);
        }
     if(i==58)
    {
        i = 12;
        UGeneralAwareness.SetActive(true);
        UG6.SetActive(false);
    }
     if(i==59)
        {
            i = 37;
            AtHome.SetActive(false);
            AtRoad.SetActive(false);
            AtPlayground.SetActive(false);
            LG2.SetActive(true);
        }
    }


    public void MainMenu()
    {
        i = 0;
    }
    public void NurseryScreen()
    {
        i = 1;
        Mainmenu.SetActive(false);
        NurserySubjectList.SetActive(true);
    }
    public void LKGScreen()
    {
        i = 2;
        Mainmenu.SetActive(false);
        LKGSubjectList.SetActive(true);
    }
    public void UKGScreen()
    {
        i = 3;
        Mainmenu.SetActive(false);
        UKGSubjectList.SetActive(true);
    }
    public void NurseryEnglish()
    {
        i = 4;
        NurserySubjectList.SetActive(false);
        NEnglish.SetActive(true);
    }
    public void NurseryMath()
    {
        i = 5;
        NurserySubjectList.SetActive(false);
        NMath.SetActive(true);
    }
    public void NurseryGeneralAwareness()
    {
        i = 6;
        NurserySubjectList.SetActive(false);
       NGeneralAwareness.SetActive(true);
    }
    public void LKGEnglish()
    {
        i = 7;
        LKGSubjectList.SetActive(false);
        LEnglish.SetActive(true);
    }
    public void LKGMath()
    {
        i = 8;
        LKGSubjectList.SetActive(false);
        LMath.SetActive(true);
    }
    public void LKGGeneralAwareness()
    {
        i = 9;
        LKGSubjectList.SetActive(false);
        LGeneralAwareness.SetActive(true);
    }
    public void UKGEnglish()
    {
        i = 10;
        UKGSubjectList.SetActive(false);
        UEnglish.SetActive(true);
    }
    public void UKGMath()
    {
        i = 11;
        UKGSubjectList.SetActive(false);
        UMath.SetActive(true);
    }
    public void UKGGeneralAwareness()
    {
        i = 12;
        UKGSubjectList.SetActive(false);
        UGeneralAwareness.SetActive(true);
    }
    public void NurseryE1()
    {
        i = 13;
        NEnglish.SetActive(false);
        NE1.SetActive(true);
    }
    public void NurseryE2()
    {
        i = 14;
        NEnglish.SetActive(false);
        NE2.SetActive(true);
    }
    public void NurseryE3()
    {
        i = 15;
        NEnglish.SetActive(false);
        NE3.SetActive(true);
    }
    public void NurseryE4()
    {
        i = 16;
        NEnglish.SetActive(false);
        NE4.SetActive(true);
    }
    public void NurseryE5()
    {
        i = 17;
        NEnglish.SetActive(false);
        NE5.SetActive(true);
        Background.SetActive(false);
    }
    public void NurseryM1()
    {
        i = 18;
        NMath.SetActive(false);
        NM1.SetActive(true);
    }
    public void NurseryM2()
    {
        i = 19;
        NMath.SetActive(false);
        NM2.SetActive(true);
    }
    public void NurseryM3()
    {
        i = 20;
        NMath.SetActive(false);
        NM3.SetActive(true);
    }
    public void NurseryM4()
    {
        i = 21;
        NMath.SetActive(false);
        NM4.SetActive(true);
    }
    public void NurseryGA1()
    {
        i = 22;
        NGeneralAwareness.SetActive(false);
       NG1.SetActive(true);
    }
    public void NurseryGA2()
    {
        i = 23;
        NGeneralAwareness.SetActive(false);
        NG2.SetActive(true);
    }
    public void NurseryGA3()
    {
        i = 24;
        NGeneralAwareness.SetActive(false);
        NG3.SetActive(true);
    }
    public void NurseryGA4()
    {
        i = 25;
        NGeneralAwareness.SetActive(false);
        NG4.SetActive(true);
    }
    public void NurseryGA5()
    {
        i = 26;
        NGeneralAwareness.SetActive(false);
        NG5.SetActive(true);
    }
    public void NurseryGA6()
    {
        i = 27;
        NGeneralAwareness.SetActive(false);
        NG6.SetActive(true);
      //  Background.SetActive(false);
    }
    public void LKGE1()
    {
        i = 28;
        LEnglish.SetActive(false);
        LE1.SetActive(true);
    }
    public void LKGE2()
    {
        i = 29;
        LEnglish.SetActive(false);
        LE2.SetActive(true);
    }
    public void LKGE3()
    {
        i = 30;
        LEnglish.SetActive(false);
        LE3.SetActive(true);
    }
    public void LKGE4()
    {
        i = 31;
        LEnglish.SetActive(false);
        LE4.SetActive(true);
    }
    public void LKGM1()
    {
        i = 32;
        LMath.SetActive(false);
        LM1.SetActive(true);
    }
    public void LKGM2()
    {
        i = 33;
        LMath.SetActive(false);
        LM2.SetActive(true);
    }
    public void LKGM3()
    {
        i = 34;
        LMath.SetActive(false);
        LM3.SetActive(true);
    }
    public void LKGM4()
    {
        i = 35;
        LMath.SetActive(false);
        LM4.SetActive(true);
    }
    public void LKGGA1()
    {
        i = 36;
        LGeneralAwareness.SetActive(false);
        LG1.SetActive(true);
    }
    public void LKGGA2()
    {
        i = 37;
        LGeneralAwareness.SetActive(false);
        LG2.SetActive(true);
    }

 
    public void LKGGA3()
    {
        i = 38;
        LGeneralAwareness.SetActive(false);
        LG3.SetActive(true);
    }
    public void LKGGA4()
    {
        i = 39;
        LGeneralAwareness.SetActive(false);
        LG4.SetActive(true);
    }
    public void LKGGA5()
    {
        i = 40;
        LGeneralAwareness.SetActive(false);
        LG5.SetActive(true);
    }
    public void LKGGA6()
    {
        i = 41;
        LGeneralAwareness.SetActive(false);
        LG6.SetActive(true);
    }
    public void UKGE1()
    {
        i = 42;
        UEnglish.SetActive(false);
        UE1.SetActive(true);
    }
    public void UKGE2()
    {
        i = 43;
        UEnglish.SetActive(false);
        UE2.SetActive(true);
    }
    public void UKGE3()
    {
        i = 44;
        UEnglish.SetActive(false);
        UE3.SetActive(true);
    }
    public void UKGE4()
    {
        i = 45;
        UEnglish.SetActive(false);
        UE4.SetActive(true);
    }
    public void UKGE5()
    {
        i = 46;
        UEnglish.SetActive(false);
        UE5.SetActive(true);
    }
    public void UKGM1()
    {
        i = 47;
        UMath.SetActive(false);
        UM1.SetActive(true);
    }
    public void UKGM2()
    {
        i = 48;
        UMath.SetActive(false);
        UM2.SetActive(true);
    }
    public void UKGyM3()
    {
        i = 49;
        UMath.SetActive(false);
        UM3.SetActive(true);
    }
    public void UKGM4()
    {
        i = 50;
        UMath.SetActive(false);
        UM4.SetActive(true);
    }
    public void UKGyM5()
    {
        i = 51;
        UMath.SetActive(false);
        UM5.SetActive(true);
    }
    public void UKGM6()
    {
        i = 52;
        UMath.SetActive(false);
        UM6.SetActive(true);
    }
    public void UKGGA1()
    {
        i = 53;
        UGeneralAwareness.SetActive(false);
        UG1.SetActive(true);
    }
    public void UKGGA2()
    {
        i = 54;
        UGeneralAwareness.SetActive(false);
        UG2.SetActive(true);
    }
    public void UKGGA3()
    {
        i = 55;
        UGeneralAwareness.SetActive(false);
        UG3.SetActive(true);
    }
    public void UKGGA4()
    {
        i = 56;
        UGeneralAwareness.SetActive(false);
        UG4.SetActive(true);
    }
    public void UKGGA5()
    {
        i = 57;
        UGeneralAwareness.SetActive(false);
        UG5.SetActive(true);
        Background.SetActive(false);
    }
    public void UKGGA6()
    {
        i = 58;
        UGeneralAwareness.SetActive(false);
        UG6.SetActive(true);
    }
    // .............Safety Section................. 
    public void SafetyAtHome()
    {
        i = 59;
        LG2.SetActive(false);
        AtHome.SetActive(true);
    }
    public void SafetyAtRoad()
    {
        i = 59;
        LG2.SetActive(false);
        AtRoad.SetActive(true);
    }
    public void SafetyAtPlayGround()
    {
        i = 59;
        LG2.SetActive(false);
        AtPlayground.SetActive(true);
    }

    // .............Safety Section Ends................. 


    /*public GameObject Mainmenu, NurserySubjectList, LKGSubjectList, UKGSubjectList;
    public GameObject NEnglish,NMath,NGeneralAwareness,LEnglish,LMath,LGeneralAwareness,UEnglish,UMath,UGeneralAwareness;
    public GameObject NE1,NE2,NE3,NE4,NE5,NM1,NM2,NM3,NM4,NG1,NG2,NG3,NG4,NG5,NG6;
    public GameObject LE1, LE2, LE3, LE4, LM1, LM2, LM3, LM4, LG1, LG2, LG3, LG4, LG5, LG6;
    public GameObject UE1, UE2, UE3, UE4, UE5, UM1, UM2, UM3, UM4,UM5,UM6,UG1,UG2, UG3, UG4, UG5, UG6;*/
}
