using UnityEngine;

public interface IBallFactory
{
    IBall Create(Vector3 position);
}
