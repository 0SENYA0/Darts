using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class BallsLoader 
{
    private readonly static Dictionary<BallColor, BallScriptableObject> _scriptableObjects = new Dictionary<BallColor, BallScriptableObject>();
    private readonly static Dictionary<BallColor, IBall> _prefabs = new Dictionary<BallColor, IBall>();

    static BallsLoader()
    {
        LoadBallsScriptableObject();
        LoadBallsPrefab();
    }

    public static IReadOnlyList<BallScriptableObject> ScriptableObjects => _scriptableObjects.Values.ToList();
    public static IReadOnlyList<IBall> Prefabs => _prefabs.Values.ToList();

    private static void LoadBallsPrefab()
    {
        List<Ball> resorces = Resources.LoadAll<Ball>(BallConfig.Prefabs).ToList();

        foreach (Ball item in resorces)
            _prefabs.Add(item.Color, item);
    }

    private static void LoadBallsScriptableObject()
    {
        List<BallScriptableObject> resorces = Resources.LoadAll<BallScriptableObject>(BallConfig.ScriptableObject.TypeBalls).ToList();
        
        foreach (BallScriptableObject ballScriptableObject in resorces)
            _scriptableObjects.Add(ballScriptableObject.BallColor, ballScriptableObject);
    }
}