public class CollisionModel
{
    public bool IsDestroyed { get; private set; }

    public bool TryDestroy()
    {
        if (IsDestroyed)
            return false;

        IsDestroyed = true;
        return true;
    }
}