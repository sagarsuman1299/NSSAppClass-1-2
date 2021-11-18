using UnityEngine;
using UnityEngine.EventSystems;


public class EndDrawM : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        GameObject go = eventData.pointerDrag;
        //Debug.Log(go.tag);

        Line md = go.GetComponent<Line>();
        md.DragStop(eventData, go, gameObject);
    }


}
