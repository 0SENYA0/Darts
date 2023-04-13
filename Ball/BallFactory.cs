using System.Collections.Generic;
using UnityEngine;

public class BallFactory
{
    private Dictionary<BallColor, Ball> _balls = new Dictionary<BallColor, Ball>();
    private Ball _ball;

    private readonly BallsInfoProvider _ballConfigParameter;

    public BallFactory(BallsInfoProvider ballConfigParameter)
    {
        _ballConfigParameter = ballConfigParameter;
        InitializeBalls();
    }

    private void InitializeBalls()
    {
        _ball = Resources.Load<Ball>("Ball");

        foreach (BallScriptableObject ballScriptableObject in _ballConfigParameter.BallScriptableObjects)
        {
            var color = ballScriptableObject.BallColor;
            var ball = GameObject.Instantiate(_ball);
            ball.SetColor(ballScriptableObject.BallColor);
            ball.GetComponent<SpriteRenderer>().sprite = ballScriptableObject.Sprite;
            ball.enabled = false;
            _balls.Add(color, ball);
        }
    }

    public IBall Create(Vector3 position, BallColor color)
    {
        Ball newBall = GameObject.Instantiate(_balls[color], position, Quaternion.identity);
        BallObserver.Instance.Register(newBall);
        //newBall.enabled = true;
        return newBall;
    }
}
