using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class BombRadius : MonoBehaviour
{
    private CircleCollider2D _radius;

    private void Start() =>
        _radius = GetComponent<CircleCollider2D>();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Ball>(out Ball ball))
            ball.Burst();
    }
}
