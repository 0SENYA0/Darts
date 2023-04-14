using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BallsInfoProvider
{
    private Dictionary<BallColor, BallScriptableObject> _balls = new Dictionary<BallColor, BallScriptableObject>();

    public IReadOnlyList<BallScriptableObject> BallScriptableObjects => _balls.Values.ToList();

    public BallsInfoProvider() =>
        Initialize();

    private void Initialize()
    {
        var resorces = Resources.LoadAll<BallScriptableObject>(BallConfig.ScriptableObject.TypeBalls).ToList();

        foreach (BallScriptableObject ballScriptableObject in resorces)
        {
            var color = ballScriptableObject.BallColor;
            _balls.Add(color, ballScriptableObject);
        }
    }

    public BallScriptableObject GetInfoByColor(BallColor color) =>
        _balls[color];
}
