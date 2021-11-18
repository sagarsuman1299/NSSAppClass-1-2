using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Touch : MonoBehaviour
{
    ////////////// Variables ////////////////////
    /////////////////////////////////////////////
    public GameObject[] OK_options;                             //Array to hold the buttons labelled OK
    public GameObject Good_option;                              //Array to hold the button labelled good
    public GameObject[] Bad_options;                            //Array to hold the buttons labelled bad
    public AudioSource Player;                                  //Holds the master audioclip
    public AudioClip[] OK_sounds;                               //Array for sounds labelled ok
    public AudioClip[] Good_sounds;                             //Array for sounds labelled good
    public AudioClip[] Bad_sounds;                              //Array for sounds labelled bad
    int Selected = 0;                                           //Index of selected option
    int Type = 0;                                               //Index for ok/good/bad

    public GameObject boy;
    public GameObject girl;

    public GameObject[] head;
    public GameObject[] face;
    public GameObject[] mouth;
    public GameObject[] neck;
    public GameObject[] chest;
    public GameObject[] stomach;
    public GameObject[] hands;
    public GameObject[] butt;
    public GameObject[] thighs;
    public GameObject[] legs;
    /////////////// Variables /////////////////////////
    ///////////////////////////////////////////////////

    public void Button()
    {
        for (int i = 0; i < 6; i++)
        {
            if (EventSystem.current.currentSelectedGameObject.name == OK_options[i].name)
            {
                Type = 1;
                Selected = i;
            }
        }

        if (EventSystem.current.currentSelectedGameObject.name == Good_option.name)
        {
            Type = 2;
            Selected = 1;
        }

        for (int i = 0; i < 3; i++)
        {
            if (EventSystem.current.currentSelectedGameObject.name == Bad_options[i].name)
            {
                Type = 3;
                Selected = i;
            }
        }
        
        player();
    }

    private void player()
    {
        for (int i = 0; i < boy.transform.childCount; i++)
        {
            var child = boy.transform.GetChild(i).gameObject;
            if (child != null)
                child.SetActive(false);
        }

        for (int i = 0; i < girl.transform.childCount; i++)
        {
            var child = girl.transform.GetChild(i).gameObject;
            if (child != null)
                child.SetActive(false);
        }


        if (Type == 1 && Selected == 0)
        {
            for(int i = 0; i < head.Length; i++)
            {
                head[i].SetActive(true);
            }
        }
        else if (Type == 1 && Selected == 1)
        {
            for (int i = 0; i < face.Length; i++)
            {
                face[i].SetActive(true);
            }
        }
        else if (Type == 1 && Selected == 2)
        {
            for (int i = 0; i < neck.Length; i++)
            {
                neck[i].SetActive(true);
            }
        }
        else if (Type == 1 && Selected == 3)
        {
            for (int i = 0; i < stomach.Length; i++)
            {
                stomach[i].SetActive(true);
            }
        }
        else if (Type == 1 && Selected == 4)
        {
            for (int i = 0; i < thighs.Length; i++)
            {
                thighs[i].SetActive(true);
            }
        }
        else if (Type == 1 && Selected == 5)
        {
            for (int i = 0; i < legs.Length; i++)
            {
                legs[i].SetActive(true);
            }
        }

        else if (Type == 2)
        {
            for (int i = 0; i < hands.Length; i++)
            {
                hands[i].SetActive(true);
            }
        }

        else if (Type == 3 && Selected == 0)
        {
            for (int i = 0; i < mouth.Length; i++)
            {
                mouth[i].SetActive(true);
            }
        }
        else if (Type == 3 && Selected == 1)
        {
            for (int i = 0; i < chest.Length; i++)
            {
                chest[i].SetActive(true);
            }
        }
        else if (Type == 3 && Selected == 2)
        {
            for (int i = 0; i < butt.Length; i++)
            {
                butt[i].SetActive(true);
            }
        }

        Player.Stop();
        Debug.Log("Stopped");

        StartCoroutine(MasterPlay());
    }

    IEnumerator MasterPlay()
    {
        if(Type == 1)
        {
            Player.clip = OK_sounds[OK_sounds.Length - 1];
        }
        else if (Type == 2)
        {
            Player.clip = Good_sounds[1];
        }
        else if (Type == 3)
        {
            Player.clip = Bad_sounds[Bad_sounds.Length - 1];
        }

        Player.Play();
        Debug.Log("Change1");

        yield return new WaitWhile(() => Player.isPlaying);

        StartCoroutine(Play2());
    }

    IEnumerator Play2()
    {
        if (Type == 1)
        {
            Player.clip = OK_sounds[Selected];
        }
        else if (Type == 2)
        {
            Player.clip = Good_sounds[0];
        }
        else if (Type == 3)
        {
            Player.clip = Bad_sounds[Selected];
        }

        Player.Play();
        Debug.Log("Change2");

        yield return new WaitWhile(() => Player.isPlaying);

        for (int i = 0; i < boy.transform.childCount; i++)
        {
            var child = boy.transform.GetChild(i).gameObject;
            if (child != null)
                child.SetActive(false);
        }

        for (int i = 0; i < girl.transform.childCount; i++)
        {
            var child = girl.transform.GetChild(i).gameObject;
            if (child != null)
                child.SetActive(false);
        }
    }
}
