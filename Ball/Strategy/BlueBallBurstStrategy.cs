using System.Linq;
using UnityEngine;

public class BlueBallBurstStrategy : IBallBurstStrategy
{
    public void Burst(Vector3 vector)
    {
        IBall ball = BallsLoader.Prefabs.Where(color => color.Color == BallColor.Green).FirstOrDefault();
        GameObject.Instantiate((Ball)ball, vector, Quaternion.identity);
    }
}
