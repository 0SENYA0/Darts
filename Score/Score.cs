using System.Linq;

public class Score
{
    private readonly ScoreView _scoreView;
    //private readonly BallsLoader _ballsInfoProvider;

    public Score(ScoreView scoreView)
    {
        Count = 0;
        _scoreView = scoreView;
        BallObserver.Instance.BallDestroyed += OnBallDestroyed;
    }

    ~Score() =>
        BallObserver.Instance.BallDestroyed -= OnBallDestroyed;

    public int Count { get; private set; }

    private void OnBallDestroyed(IBall obj)
    {
        int scoreToAdd = BallsLoader.ScriptableObjects.Where(x => x.BallColor == obj.Color).Select(x => x.Score).FirstOrDefault();
        Count += scoreToAdd;
        _scoreView.SetNewValue(Count);
    }
}
