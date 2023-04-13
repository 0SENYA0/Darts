using System;

public interface IBallObserver
{
    event Action<IBall> BallDestroyed;
    void Register(IBall ball);
    void Unregister(IBall ball);
}

