using UnityEngine;

public class ActorSwipeControl : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Animator animator;

    public void OnSwipeInput(Vector2 direction, float speed)
    {
        animator.SetFloat("Up", direction.y);
        Invoke(nameof(ResetValues), 0.5f);
    }

    private void ResetValues()
    {
        animator.SetFloat("Up", 0);
    }
}
