using System;
using UnityEngine;

public interface IBall
{
    event Action<IBall> Destroyed;
    void SetColor (BallColor ballColor);
    Vector3 Position { get; }
    BallColor Color { get; }
}
