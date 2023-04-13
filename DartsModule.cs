using System.Collections.Generic;
using UnityEngine;

public class DartsModule : MonoBehaviour
{
    [SerializeField] private ScoreView _scoreView;

    private BallsInfoProvider _ballsInfoProvider;
    private BallFactory _ballFactory;
    private BallSpawner _ballSpawner;
    private Score _score;
    
    private void Awake()
    {
        _ballsInfoProvider = new BallsInfoProvider();
        _ballFactory = new BallFactory(_ballsInfoProvider);
        _ballSpawner = new BallSpawner(_ballFactory);
        _score = new Score(_scoreView, _ballsInfoProvider);
        RegisterBalls();
    }

    private void RegisterBalls() =>
        BallObserver.Instance.Register(GetBallsOnScene());

    private IEnumerable<Ball> GetBallsOnScene() =>
         FindObjectsOfType<Ball>();
}
