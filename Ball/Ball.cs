using System;
using UnityEngine;

public class Ball : MonoBehaviour, IBall
{
    [SerializeField] private BallColor _color;

    public event Action<IBall> Destroyed;
    
    public BallColor Color 
    { 
        get => _color; 
        private set => _color = value; 
    }
    
    public Vector3 Position => transform.position;

    public void SetColor(BallColor ballColor) =>
        Color = ballColor;

    public void Burst()
    {
        Destroyed?.Invoke(this);
        BallObserver.Instance.Unregister(this);
        Destroy(gameObject);
    }
}