//using System;

//public class BallSpawner
//{
//    private BallFactory _ballFactory;

//    public BallSpawner(BallFactory ballFactory)
//    {
//        _ballFactory = ballFactory;
//        BallObserver.Instance.BallDestroyed += OnBallDestroyed;
//    }

//    ~BallSpawner() =>
//        BallObserver.Instance.BallDestroyed -= OnBallDestroyed;
    
//    public event Action<IBall> Spawned;

//    public void Spawn(IBall ball, BallColor color)
//    {
//        _ballFactory.Create(ball.Position, color);
//    }

//    private void OnBallDestroyed(IBall destroedBall)
//    {
//        BallColor color = destroedBall.Color;

//        switch (destroedBall.Color)
//        {
//            case BallColor.Blue:
//                color = BallColor.Green;
//                break;
//            case BallColor.Green:
//                color = BallColor.Red;
//                break;
//        }

//        Spawn(destroedBall, color);
//    }
//}
