using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Animal_sound : MonoBehaviour
{
    ////////////// Variables ////////////////////
    /////////////////////////////////////////////
    public AudioSource Player;                                  //Holds the master audioclip
    public AudioClip[] Sounds;                                  //Array for sounds
    int Selected = 0;                                           //Index of selected option
    /////////////// Variables /////////////////////////
    ///////////////////////////////////////////////////

    public void Cow()
    {
        Selected = 0;
        player();
    }
    public void Dog()
    {
        Selected = 1;
        player();
    }
    public void Cat()
    {
        Selected = 2;
        player();
    }
    public void Lion()
    {
        Selected = 3;
        player();
    }
    public void Goat()
    {
        Selected = 4;
        player();
    }
    public void Elep()
    {
        Selected = 5;
        player();
    }
    public void Pige()
    {
        Selected = 6;
        player();
    }
    public void Crow()
    {
        Selected = 7;
        player();
    }
    public void Cock()
    {
        Selected = 8;
        player();
    }
    public void Peacock()
    {
        Selected = 9;
        player();
    }
    public void Night()
    {
        Selected = 10;
        player();
    }
    public void Cuck()
    {
        Selected = 11;
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
        Player.clip = Sounds[Selected];
        Player.Play();
        Debug.Log("Change2");

        yield return new WaitWhile(() => Player.isPlaying);
    }
}
