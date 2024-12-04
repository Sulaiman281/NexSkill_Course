using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class SwipeInput : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    private Vector2 startTouchPosition;
    private Vector2 endTouchPosition;
    private bool isSwiping = false;
    private float _startTime;

    [Header("Events")]
    public UnityEvent<Vector2, float> OnSwipeInput;

    public void OnDrag(PointerEventData eventData)
    {
        isSwiping = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        startTouchPosition = eventData.position;
        _startTime = Time.time;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        endTouchPosition = eventData.position;
        Results();
    }

    private void Results()
    {
        if (!isSwiping) return;

        Vector2 direction = endTouchPosition - startTouchPosition;
        Debug.Log($"Swipe Direction: {direction.normalized}");

        var distance = direction.magnitude;

        distance = Mathf.Clamp(distance, 0, 10);
        
        Debug.Log($"Swipe Distance: {distance}");

        var duration = 1 + Time.time - _startTime;

        var speed = distance / duration;


        OnSwipeInput?.Invoke(direction.normalized, speed);
        isSwiping = false;
    }
}
