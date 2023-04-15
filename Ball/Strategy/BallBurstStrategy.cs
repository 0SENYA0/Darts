using UnityEngine;

public class BallBurstStrategy
{
    private IBallBurstStrategy _ballBurstStrategy;

    public BallBurstStrategy(IBallBurstStrategy ballBurstStrategy)
    {
        _ballBurstStrategy = ballBurstStrategy;
    }

    public void Burst(Vector3 position) =>
        _ballBurstStrategy.Burst(position);
}
