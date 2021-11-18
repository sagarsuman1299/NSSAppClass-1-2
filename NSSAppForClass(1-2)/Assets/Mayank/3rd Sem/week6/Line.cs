using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Line : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler
{
    //private Vector2 spriteDim = new Vector2(420.21f, 272.26f);
    
    private Managerr manager;
    public LineRenderer line;
    
    
    

    public void Awake()
    {
        manager = GameObject.Find("Managerr").GetComponent<Managerr>();
        
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

    public void DragStop(PointerEventData eventData, GameObject ans, GameObject qsn)
    {
        Vector2 v = eventData.position;
        
        if (ans.CompareTag(qsn.tag))
        {
            
            if (manager.tags.Contains(qsn.tag))
            {
                line.SetPosition(1, Cam(v));
                manager.Delay_correct();
            }
            else
            {
                manager.tags.Add(qsn.tag);
                //manager.correct_count++;
            
                line.SetPosition(1, Cam(v));
                manager.Delay_correct();
            }
        }
        else if (qsn.tag == "Background")
        {
            line.SetPosition(1, line.GetPosition(0));
            StartCoroutine("stop");
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
