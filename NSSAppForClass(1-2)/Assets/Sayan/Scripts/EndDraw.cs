using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EndDraw : MonoBehaviour, IDropHandler
{
    //public MouseDrag md;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(eventData.pointerDrag);
        GameObject go = eventData.pointerDrag;
        MouseDrag md=go.GetComponent<MouseDrag>();
        md.DragStop(eventData,gameObject);
    }

}
