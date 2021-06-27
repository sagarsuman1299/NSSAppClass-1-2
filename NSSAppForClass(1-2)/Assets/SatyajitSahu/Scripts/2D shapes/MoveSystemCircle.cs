using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystemCircle : MonoBehaviour
{
    public GameObject correctForm;
    private bool moving;
    private bool finish;

    [SerializeField] float xMinDiastance = 2.6f;
    [SerializeField] float yMinDiastance = 2.4f;

    private float startPosX;
    private float startPosY;

    private Vector3 resetPosition;

    PanelChanger p;
    // Start is called before the first frame update
    void Start()
    {
        resetPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (finish == false)
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

        if (Mathf.Abs(this.transform.position.x - correctForm.transform.position.x) <= xMinDiastance &&
            Mathf.Abs(this.transform.position.y - correctForm.transform.position.y) <= yMinDiastance)
        {
            this.transform.position = new Vector3(correctForm.transform.position.x, correctForm.transform.position.y, correctForm.transform.position.z);
            finish = true;
            p = FindObjectOfType<PanelChanger>();
            p.Correct();
            Invoke("Change", 2.0f);
        }
        else
        {
            this.transform.position = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
            p = FindObjectOfType<PanelChanger>();
            p.WrongActive();
            Invoke("WrongEnd", 1.0f);
        }
    }

    public void Change()
    {
        p = FindObjectOfType<PanelChanger>();
        p.Q3();
    }

    public void WrongEnd()
    {
        p = FindObjectOfType<PanelChanger>();
        p.WrongLazy();
    }
}
