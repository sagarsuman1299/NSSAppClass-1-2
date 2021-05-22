using System.Collections;
using UnityEngine;
public class Wait : MonoBehaviour
{
    public GameObject MainMenu,video,button;
    public float wait_time = 5f;
    void Start()
    {
        StartCoroutine(wait2());
        
        StartCoroutine(wait());
       
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(wait_time);
        MainMenu.SetActive(true);
        button.SetActive(true);
        video.SetActive(false);
        //SceneManager.LoadScene(0);
    }
    IEnumerator wait2()
    {
        yield return new WaitForSeconds(0);
        video.SetActive(true);
    }
}
