using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BloodMark"))
        {
            Destroy(gameObject);
        }
    }
}
