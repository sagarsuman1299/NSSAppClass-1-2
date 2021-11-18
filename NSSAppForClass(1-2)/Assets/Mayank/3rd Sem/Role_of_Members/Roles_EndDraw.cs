
using UnityEngine;

using UnityEngine.EventSystems;


public class Roles_EndDraw : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        GameObject go = eventData.pointerDrag;
        Roles_Line md = go.GetComponent<Roles_Line>();
        md.DragStop(eventData, go, gameObject);
    }
}
