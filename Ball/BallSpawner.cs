using System;

public class BallSpawner
{
    private BallFactory _ballFactory;

    public BallSpawner(BallFactory ballFactory) 
    {
        _ballFactory = ballFactory;
        BallObserver.Instance.BallDestroyed += OnBallDestroyed;
    }

    public event Action<IBall> Spawned;

    public void Spawn(IBall ball, BallColor color)
    {
        IBall newBall = _ballFactory.Create(ball.Position, color);
    }

    private void OnBallDestroyed(IBall obj)
    {
        BallColor color = obj.Color;

        switch (obj.Color)
        {
            case BallColor.Blue:
                color = BallColor.Green;
                break;
            case BallColor.Green:
                color = BallColor.Red;
                break;
            default:
                return;
        }

        Spawn(obj, color);
    }
}
