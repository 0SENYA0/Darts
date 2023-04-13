using System.Collections.Generic;
using System.Linq;

public class Score
{
    readonly private ScoreView _scoreView;
    readonly private Dictionary<BallColor, int> _scoreDictionary = new Dictionary<BallColor, int>();

    public Score(ScoreView scoreView, BallsInfoProvider ballsInfoProvider)
    {
        Count = 0;
        _scoreView = scoreView;
        _scoreDictionary = ballsInfoProvider.BallScriptableObjects
            .Select(info => new { Key = info.BallColor, Value = info.Score })
            .Distinct()
            .ToDictionary(item => item.Key, item => item.Value);
        BallObserver.Instance.BallDestroyed += OnBallDestroyed;
    }

    public int Count { get; private set; }

    private void OnBallDestroyed(IBall obj)
    {
        int scoreToAdd = _scoreDictionary[obj.Color];
        Count += scoreToAdd;
        _scoreView.SetNewValue(Count);
    }
}
