using System;
using UnityEngine;

public class CollisionView : MonoBehaviour
{
    public event Action<Collider> TriggerEntered;

    private void OnTriggerEnter(Collider other)
    {
        TriggerEntered?.Invoke(other);
    }

    public void RemoveFromScene()
    {
        Destroy(gameObject);
    }
}