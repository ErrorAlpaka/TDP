using UnityEngine;

public class Goal : MonoBehaviour
{
    // Destroy everything that enters the trigger
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}