using UnityEngine;

public class SwordfishSpawner : MonoBehaviour
{
    public GameObject swordfishPrefab; // Assign the Swordfish prefab in the Inspector
    public Transform spawnPoint;      // Set the spawn location in the Inspector
    public float respawnDelay = 2f;   // Time delay before respawning a new Swordfish

    private GameObject currentSwordfish;

    private void Start()
    {
        SpawnSwordfish();
    }

    private void Update()
    {
        // Check if the current Swordfish has been destroyed
        if (currentSwordfish == null)
        {
            // Start the respawn process
            Invoke(nameof(SpawnSwordfish), respawnDelay);
        }
    }

    private void SpawnSwordfish()
    {
        if (currentSwordfish == null)
        {
            currentSwordfish = Instantiate(swordfishPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
