using System;
using System.Collections.Generic;

public class BallObserver : IBallObserver
{
    // TMP_PRO текст - очки которые летят после уничтожения шара
    // TMP_PRO текст - основные очки 
    // AudioSource - звук уничтожения 
    // Animation - анимация уничтожения

    private static readonly BallObserver _instance = new BallObserver();

    private BallObserver() { }

    public static BallObserver Instance => _instance;

    public event Action<IBall> BallDestroyed;

    public void Register(IBall ball) =>
        ball.Destroyed += Notify;

    public void Register(IEnumerable<IBall> balls)
    {
        foreach (IBall ball in balls)
            ball.Destroyed += Notify;
    }

    public void Unregister(IBall ball) =>
        ball.Destroyed -= Notify;

    private void Notify(IBall ball)
    {
        BallDestroyed?.Invoke(ball);
    }
}
