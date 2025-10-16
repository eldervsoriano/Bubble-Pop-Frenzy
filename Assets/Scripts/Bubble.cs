


using UnityEngine;

public class Bubble : MonoBehaviour
{
    public string bubbleColor; // The color of the bubble (e.g., "Red", "Blue", "Yellow")
    public int points = 1; // Points awarded for popping
    public float timeBonus = 5f; // Time bonus for popping
    public float moveSpeed = 2f; // Speed of movement
    public float roamRange = 2f; // Range for random movement
    public float destroyAfter = 10f; // Duration before the bubble is automatically destroyed

    private ScoreManager scoreManager;
    private TimerManager timerManager;
    private Vector2 roamDirection; // Direction for roaming
    private float roamTimer = 0f; // Timer to reset roaming direction

    private void Start()
    {
        // Find managers in the scene
        scoreManager = FindObjectOfType<ScoreManager>();
        timerManager = FindObjectOfType<TimerManager>();

        if (scoreManager == null)
        {
            Debug.LogError("ScoreManager not found! Ensure it is in the scene.");
        }

        if (timerManager == null)
        {
            Debug.LogError("TimerManager not found! Ensure it is in the scene.");
        }

        // Set an initial random direction for roaming
        SetRandomRoamDirection();

        // Schedule destruction of the bubble after the specified duration
        Destroy(gameObject, destroyAfter);
    }

    private void Update()
    {
        // Call roaming behavior in every frame
        Roam();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the object colliding is a swordfish
        if (collision.CompareTag("Swordfish"))
        {
            Swordfish swordfish = collision.GetComponent<Swordfish>();

            if (swordfish != null && swordfish.swordfishColor == bubbleColor)
            {
                // Add score and time if colors match
                scoreManager?.AddScore(points);
                timerManager?.AddTime(timeBonus);
                Debug.Log($"Bubble popped! {points} points and {timeBonus} seconds added.");

                Destroy(gameObject); // Destroy the bubble
            }
            else
            {
                Debug.Log($"Colors did not match! Bubble ({bubbleColor}) was not popped.");
            }
        }
        else if (collision.CompareTag("Boundary"))
        {
            // Reverse direction if the bubble hits a boundary
            Debug.Log("Bubble hit a boundary and reversed direction.");

            // Reverse direction based on which side of the wall it hit
            Vector2 normal = collision.GetComponent<Collider2D>().ClosestPoint(transform.position) - (Vector2)transform.position;
            roamDirection = Vector2.Reflect(roamDirection, normal.normalized);
        }
    }

    private void Roam()
    {
        // Move the bubble in the current roam direction
        transform.Translate(roamDirection * moveSpeed * Time.deltaTime);

        // Update the roam direction periodically
        roamTimer -= Time.deltaTime;
        if (roamTimer <= 0f)
        {
            SetRandomRoamDirection();
        }
    }

    private void SetRandomRoamDirection()
    {
        // Set a random direction for roaming
        roamDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;

        // Reset the roam timer to a random value within the range
        roamTimer = Random.Range(1f, roamRange);
    }
}
