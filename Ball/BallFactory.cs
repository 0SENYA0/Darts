using System.Linq;
using UnityEngine;

public class BallFactory
{
    //private Dictionary<BallColor, Ball> _balls = new Dictionary<BallColor, Ball>();
    //private Ball _ball;

    //private readonly BallsLoader _ballsLoader;

    //public BallFactory(BallsLoader ballLoader)
    //{
    //    _ballsLoader = ballLoader;
    //    //InitializeBalls();
    //}
    //private void InitializeBalls()
    //{
    //    //_ball = (Ball)_ballsLoader.BallPrefab;

    //    foreach (BallScriptableObject ballScriptableObject in _ballsLoader.ScriptableObjects)
    //    {
    //        var color = ballScriptableObject.BallColor;
    //        var ball = GameObject.Instantiate(_ball);
    //        ball.SetColor(ballScriptableObject.BallColor);
    //        ball.GetComponent<SpriteRenderer>().sprite = ballScriptableObject.Sprite;
    //        ball.enabled = false;
    //        _balls.Add(color, ball);
    //    }
    //}

    //public IBall Create(Vector3 position, BallColor color)
    //{
    //    IBall ball = _ballsLoader.Prefabs.Where(x => x.Color == color).FirstOrDefault();
    //    IBall newBall = GameObject.Instantiate((Ball)ball, position, Quaternion.identity);
    //    BallObserver.Instance.Register(newBall);
    //    return newBall;
    //}
}
