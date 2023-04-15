using UnityEngine;

public class RedBallBurstStrategy : IBallBurstStrategy
{
    public void Burst(Vector3 position)
    {
        Debug.Log("Все шарики уничтожены");
    }
}
