using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pollution_effects : MonoBehaviour
{
    ////////////// Variables ////////////////////
    /////////////////////////////////////////////
    public GameObject[] Options;                                //Array to hold the buttons
    public AudioSource Player;                                  //Holds the master audioclip
    public AudioClip[] Voices;                                  //Array for sounds
    int Selected = 0;                                           //Index of selected option
    /////////////// Variables /////////////////////////
    ///////////////////////////////////////////////////

    public void Button()
    {
        for(int i = 0; i < 6; i++)
        {
            if (EventSystem.current.currentSelectedGameObject.name == Options[i].name)
            {
                Selected = i;
                Debug.Log(Selected);
            }
        }

        player();
    }

    private void player()
    {
        Player.Stop();
        Debug.Log("Stopped");

        StartCoroutine(MasterPlay());
    }

    IEnumerator MasterPlay()
    {
        Player.clip = Voices[Voices.Length - 1];
        Player.Play();
        Debug.Log("Change1");

        yield return new WaitWhile(() => Player.isPlaying);

        StartCoroutine(Play2());
    }

    IEnumerator Play2()
    {
        Player.clip = Voices[Selected];
        Player.Play();
        Debug.Log("Change2");

        yield return new WaitWhile(() => Player.isPlaying);
    }
}
