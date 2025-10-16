using UnityEngine;

public class BubbleSpawner : MonoBehaviour
{
    public GameObject[] bubblePrefabs; // Array to hold different bubble prefabs
    public float spawnInterval = 2f; // Time interval between spawns
    public Vector2 spawnAreaSize = new Vector2(10f, 10f); // Width and height of the spawn area

    private void Start()
    {
        // Start spawning bubbles repeatedly
        InvokeRepeating(nameof(SpawnBubble), 0f, spawnInterval);
    }

    private void SpawnBubble()
    {
        if (bubblePrefabs.Length == 0)
        {
            Debug.LogWarning("No bubble prefabs assigned to the spawner!");
            return;
        }

        // Choose a random bubble prefab
        GameObject bubblePrefab = bubblePrefabs[Random.Range(0, bubblePrefabs.Length)];

        // Generate a random position within the square spawn area
        Vector2 spawnPosition = new Vector2(
            Random.Range(-spawnAreaSize.x / 2f, spawnAreaSize.x / 2f),
            Random.Range(-spawnAreaSize.y / 2f, spawnAreaSize.y / 2f)
        );

        // Adjust the spawn position relative to the spawner's position
        spawnPosition += (Vector2)transform.position;

        // Spawn the bubble
        Instantiate(bubblePrefab, spawnPosition, Quaternion.identity);
    }

    private void OnDrawGizmos()
    {
        // Visualize the spawn area in the editor
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(transform.position, spawnAreaSize);
    }
}
