using System;
using UnityEngine;

public interface IBall
{
    event Action<IBall> Destroyed;
    Vector3 Position { get; }
    BallColor Color { get; }
}
