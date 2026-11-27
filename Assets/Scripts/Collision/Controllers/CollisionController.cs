using UnityEngine;

[RequireComponent(typeof(CollisionView))]
public class CollisionController : MonoBehaviour
{
    private CollisionModel _model;
    private CollisionView _view;

    private void Awake()
    {
        _model = new CollisionModel();
        _view = GetComponent<CollisionView>();
    }

    private void OnEnable()
    {
        _view.TriggerEntered += HandleCollision;
    }

    private void OnDisable()
    {
        _view.TriggerEntered -= HandleCollision;
    }

    private void HandleCollision(Collider other)
    {
        if (!other.CompareTag("BloodMark"))
            return;

        if (_model.TryDestroy())
            _view.RemoveFromScene();
    }
}