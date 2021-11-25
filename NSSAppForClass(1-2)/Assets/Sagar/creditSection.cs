using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creditSection : MonoBehaviour
{
    public GameObject CreditWindow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
  public void ActivateCreditSection()
    {
        CreditWindow.SetActive(true);
    }
    public void DeActivateCreditSection()
    {
        CreditWindow.SetActive(false);
    }
}
