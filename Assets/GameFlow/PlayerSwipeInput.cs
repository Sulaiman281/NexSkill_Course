using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PlayerSwipeInput : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    public UnityEvent<Vector2> OnSwipe;

    private Vector2 _startPos;
    private bool _isDragging;
    

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Pointer Down");
        _startPos = eventData.position;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("Pointer Up");

        var endPos = eventData.position;

        var direction  = endPos - _startPos;

        if (_isDragging)
        {
            OnSwipe?.Invoke(direction.normalized);
        }

        _isDragging = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
        _isDragging = true;
    }

}