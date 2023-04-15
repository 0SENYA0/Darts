using System.Linq;
using UnityEngine;

public class GreenBallBurstStrategy : IBallBurstStrategy
{
    public void Burst(Vector3 position)
    {
        IBall ball = BallsLoader.Prefabs.Where(color => color.Color == BallColor.Red).FirstOrDefault();
        GameObject.Instantiate((Ball)ball, position, Quaternion.identity);
    }
}
