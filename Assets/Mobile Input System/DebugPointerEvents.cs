using UnityEngine;
using UnityEngine.EventSystems;

public class DebugPointerEvents : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler, IDragHandler, IPointerUpHandler, IPointerMoveHandler
{
    [Header("Debug Pointer Events")]
    [SerializeField] private bool debugClick = false;
    [SerializeField] private bool debugDown = false;
    [SerializeField] private bool debugEnter = false;
    [SerializeField] private bool debugExit = false;
    [SerializeField] private bool debugDrag = false;
    [SerializeField] private bool debugUp = false;
    [SerializeField] private bool debugMove = false;

    public void OnPointerClick(PointerEventData eventData)
    {   
        if (debugClick)
        {
            Debug.Log($"OnPointerClick: {eventData.position}");
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (debugDown)
        {
            Debug.Log($"OnPointerDown: {eventData.position}");
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (debugEnter)
        {
            Debug.Log($"OnPointerEnter: {eventData.position}");
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (debugExit)
        {
            Debug.Log($"OnPointerExit: {eventData.position}");
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (debugDrag)
        {
            Debug.Log($"OnDrag: {eventData.position}");
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (debugUp)
        {
            Debug.Log($"OnPointerUp: {eventData.position}");
        }
    }

    public void OnPointerMove(PointerEventData eventData)
    {
        if (debugMove)
        {
            Debug.Log($"OnPointerMove: {eventData.position}");
        }
    }

}
