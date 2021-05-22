using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Button))]
public class buttonClick : MonoBehaviour
{
    int i = 1;

    public AudioClip sound;
 //   public AudioClip sound,R1,R2,R3,R4,R5;
    private Button button { get { return GetComponent<Button>(); } }
    private AudioSource source { get { return GetComponent<AudioSource>(); } }


    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        source.clip = sound;
        source.playOnAwake = false;

        button.onClick.AddListener(() => PlaySound());
    }
    public void PlaySound()
    {
        source.PlayOneShot(sound);
        i = 0;
    }
   /* public void Rhy1()
    {
        i = 1;
        if (i == 1)
    source.PlayOneShot(R1);
    }
    public void Rhy2()
    {
        i = 2;
        if (i == 2)
            source.PlayOneShot(R2);
    }
    public void Rhy3()
    {
        i = 3;
        if (i == 3)
            source.PlayOneShot(R3);
    }
    public void Rhy4()
    {
        i = 4;
        if (i == 4)
            source.PlayOneShot(R4);
    }
    public void Rhy5()
    {
        i = 5;
        if (i == 5)
            source.PlayOneShot(R5);
    }
    */
}