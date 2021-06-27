using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag_Handler : MonoBehaviour, IDragHandler
{
    public RectTransform pos;
    public Canvas canvas;

    public void OnDrag(PointerEventData eventData)
    {
        pos.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }
}
