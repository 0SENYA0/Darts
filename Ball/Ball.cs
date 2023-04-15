using System;
using UnityEngine;

public class Ball : MonoBehaviour, IBall
{
    [SerializeField] private BallColor _color;
    
    private const long CooldownTime = 250;
    
    private BallBurstStrategy _ballBurstStrategy;
    
    private long currentTime = CooldownTime + DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

    public bool CanExplode() =>
         currentTime <= DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

    private void Start()
    {
        switch (_color)
        {
            case BallColor.Blue:
                _ballBurstStrategy = new BallBurstStrategy(new BlueBallBurstStrategy());
                break;
            case BallColor.Green:
                _ballBurstStrategy = new BallBurstStrategy(new GreenBallBurstStrategy());
                break;
            case BallColor.Red:
                _ballBurstStrategy = new BallBurstStrategy(new RedBallBurstStrategy());
                break;
        }
    }

    public event Action<IBall> Destroyed;

    public BallColor Color => _color;
    //{ 
        //get => _color; 
        //private set => _color = value; 
    //}
    
    public Vector3 Position => transform.position;

    public void SetColor(BallColor ballColor) =>
        _color = ballColor;

    public void Explode()
    {
        _ballBurstStrategy.Burst(transform.position);
        Destroyed?.Invoke(this);
        BallObserver.Instance.Unregister(this);
        Destroy(gameObject);
    }
}