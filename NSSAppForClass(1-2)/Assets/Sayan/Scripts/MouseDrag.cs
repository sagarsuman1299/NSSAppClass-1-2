using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class MouseDrag : MonoBehaviour, IPointerDownHandler,IBeginDragHandler,IDragHandler
{
    public TextMeshProUGUI tmp;
    public GameObject answer;
    public GetNextQues gnq;

    private Vector2 spriteDim = new Vector2(420.21f, 272.26f);

    public LineRenderer lr;

    private void Awake()
    {
        Debug.Log("I Awake");
        //rt = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Vector2 v = eventData.position;
        lr.SetPosition(0, Correct(v));
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 v = eventData.position;
        lr.SetPosition(1, Correct(v));
        
    }

    public void DragStop(PointerEventData eventData,GameObject go)
    {
        Vector2 v = eventData.position;
        Debug.Log(go);
        if (go == answer)
        {
            lr.SetPosition(1, Correct(v));
            tmp.text = "Correct";
            Debug.Log(tmp.text);
            gnq.que.Add(gameObject);
            Debug.Log("Hemlo");
            //Debug.Log(gnq.que.Count);
            StartCoroutine("stop");
        }
        else
        {
            lr.SetPosition(1, lr.GetPosition(0));
            tmp.text = "Incorrect";
            StartCoroutine("stop");
        }

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Pointer Down");
    }

    Vector3 Correct(Vector2 v)
    {
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(new Vector3(v.x, v.y, 0));
        worldPos.z = 0;
        //Debug.Log("WorldPos:" + worldPos);
        return worldPos;
    }

    IEnumerator stop()
    {
        yield return new WaitForSeconds(1.0f);
        tmp.text = "";
    }
}
