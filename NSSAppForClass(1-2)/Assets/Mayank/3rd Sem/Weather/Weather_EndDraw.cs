
using UnityEngine;

using UnityEngine.EventSystems;


public class Weather_EndDraw : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        GameObject go = eventData.pointerDrag;
        Weather_Line md = go.GetComponent<Weather_Line>();
        md.DragStop(eventData, go, gameObject);
    }
}
