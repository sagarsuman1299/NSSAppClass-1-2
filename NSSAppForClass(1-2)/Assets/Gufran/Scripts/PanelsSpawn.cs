using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelsSpawn: MonoBehaviour
{
    public GameObject[] Panels;
    public int rnd;
    int i;

    public Manager mm;
    public Image []image;

    public Sprite []images;
    public int randomimageindex;
    public void random()
    {
        rnd = Random.Range(1, 10);
       // Debug.Log("Spawn");
        //Debug.Log(rnd);
        for ( i=0; i<rnd; i++)
        {
            Panels[i].SetActive(true);
        }
        
    }

    public void spritechanger()
    {
        randomimageindex = Random.Range(0,images.Length);
        for(int i=0;i<9;i++)
        {
            image[i].sprite = images[randomimageindex];
        }
        
        
    }
    void Update()
    {
        if(mm.flag==1&&mm.click==1)
        {
            spritechanger();

            for ( i=0; i<9; i++)
            {
                Panels[i].SetActive(false);
                
            }
            random();
            mm.click = 0;

        }
        
    }

    
}