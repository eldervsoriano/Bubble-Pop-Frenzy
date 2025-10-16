//using UnityEngine;

//public class Swordfish : MonoBehaviour
//{
//    public string swordfishColor; // The color of this swordfish (e.g., "Red", "Blue", "Yellow")

//    private void OnTriggerEnter2D(Collider2D collision)
//    {
//        // Additional logic for swordfish behavior can go here if needed
//    }
//}


using UnityEngine;

public class Swordfish : MonoBehaviour
{
    public string swordfishColor; // The color of this swordfish (e.g., "Red", "Blue", "Yellow")

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the object collided with is tagged as "Wall"
        if (collision.CompareTag("Wall"))
        {
            // Destroy this Swordfish object
            Destroy(gameObject);
        }
    }
}

