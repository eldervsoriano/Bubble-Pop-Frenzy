using UnityEngine;

public class SwipeThrow : MonoBehaviour
{
    private Vector2 startTouchPosition;
    private Vector2 endTouchPosition;
    private Vector2 swipeDirection;
    private bool isTouched = false;
    private bool isMoving = false;

    [SerializeField] private float throwSpeed = 5f; // Speed of the projectile

    private Vector2 currentVelocity;

    void Update()
    {
        // Detect touch input
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                // Check if the object is touched
                Collider2D hitCollider = Physics2D.OverlapPoint(touchPosition);
                if (hitCollider != null && hitCollider.gameObject == gameObject)
                {
                    isTouched = true;
                    isMoving = false; // Stop current movement
                    startTouchPosition = touchPosition; // Store the start position
                }
            }
            else if (touch.phase == TouchPhase.Ended && isTouched)
            {
                isTouched = false;
                endTouchPosition = touchPosition; // Store the end position

                // Calculate swipe direction and normalize
                swipeDirection = endTouchPosition - startTouchPosition;
                currentVelocity = swipeDirection.normalized * throwSpeed; // Maintain constant speed
                isMoving = true;
            }
        }

        // Move the object if it is in motion
        if (isMoving)
        {
            // Update position at a constant speed
            transform.position += (Vector3)currentVelocity * Time.deltaTime;

            // Rotate the object to face the direction of movement
            float angle = Mathf.Atan2(currentVelocity.y, currentVelocity.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, angle - 90);
        }
    }
}
