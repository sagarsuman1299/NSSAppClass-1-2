using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragdrop1 : MonoBehaviour
{
    public GameObject mainform;
    private bool moving;
    private bool finish;

    private float startPosX;
    private float startPosY;

    private Vector3 resetposition;

    void Start()
    {
        resetposition = this.transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        if (finish==false)
        {
            if (moving)
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                this.gameObject.transform.position = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.position.z);
            }
        }
        
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.position.x;
            startPosY = mousePos.y - this.transform.position.y;

            moving = true; 
        }
    }

    private void OnMouseUp()
    {
        moving = false;

        if (Mathf.Abs(this.transform.position.x- mainform.transform.position.x)<= 0.5f &&
            Mathf.Abs(this.transform.position.y - mainform.transform.position.y) <= 0.5f)
        {
            this.transform.position = new Vector3(mainform.transform.position.x, mainform.transform.position.y, mainform.transform.position.z);
            finish = true;

            GameObject.Find("Win").GetComponent<victory1>().AddPoints();
        }
        else
        {
            this.transform.position = new Vector3(resetposition.x, resetposition.y, resetposition.z);
        }
    }
}
