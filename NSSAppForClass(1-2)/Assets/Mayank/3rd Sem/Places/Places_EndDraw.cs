using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Places_EndDraw : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        GameObject go = eventData.pointerDrag;
        Places_Line md = go.GetComponent<Places_Line>();
        md.DragStop(eventData, go, gameObject);
    }
}
