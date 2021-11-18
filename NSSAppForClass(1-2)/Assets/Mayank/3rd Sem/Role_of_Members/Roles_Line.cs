using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class Roles_Line : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler
{
    //private Vector2 spriteDim = new Vector2(420.21f, 272.26f);

    private Roles_Manager manager;
    public LineRenderer line;

    public void Awake()
    {
        manager = GameObject.Find("Role_Manager").GetComponent<Roles_Manager>();

    }



    public void OnBeginDrag(PointerEventData eventData)
    {
        Vector2 v = eventData.position;
        line.SetPosition(0, Cam(v));
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 v = eventData.position;
        line.SetPosition(1, Cam(v));

    }

    public void DragStop(PointerEventData eventData, GameObject qsn, GameObject ans)
    {
        Vector2 v = eventData.position;
        if (ans.tag == "Background")
        {
            line.SetPosition(1, line.GetPosition(0));
            StartCoroutine("stop");
        }

        else if (qsn.GetComponentInChildren<Text>().text == (ans.GetComponent<Text>().text))
        {

            if (manager.role_texts.Contains(ans.GetComponent<Text>().text))
            {
                line.SetPosition(1, Cam(v));
                manager.Delay_correct();
            }
            else
            {
                manager.role_texts.Add(ans.GetComponent<Text>().text);
                //manager.correct_count++;

                line.SetPosition(1, Cam(v));
                manager.Delay_correct();
            }
        }
        else
        {
            line.SetPosition(1, line.GetPosition(0));
            manager.Delay_wrong();
        }


    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("Pointer Down");
    }

    Vector3 Cam(Vector2 v)
    {
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(new Vector3(v.x, v.y, 0));
        worldPos.z = 0;
        return worldPos;
    }

    IEnumerator stop()
    {
        yield return new WaitForSeconds(1.0f);
    }



}
