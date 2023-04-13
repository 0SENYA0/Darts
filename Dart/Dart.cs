using System;
using UnityEngine;

public class Dart : MonoBehaviour
{
    [SerializeField] private Vector2 _offset;
    [SerializeField] private float _force;

    private Rigidbody2D _rigidbody2D;
    private float _angle;

    private void Start() =>
        _angle = Mathf.Atan2(_rigidbody2D.velocity.y, _rigidbody2D.velocity.x) * Mathf.Rad2Deg;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _angle = Mathf.Atan2(_rigidbody2D.velocity.y, _rigidbody2D.velocity.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(-_angle, Vector3.forward);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Ball>(out Ball ball))
            ball.Burst();

        if (collision.gameObject.TryGetComponent<Bomb>(out Bomb bomb))
            bomb.Detonate2();
        transform.rotation = Quaternion.AngleAxis(-_angle, Vector3.forward);
        transform.rotation = Quaternion.AngleAxis(180, Vector3.up);
        Push();
    }

    private void Push()
    {
        _rigidbody2D.AddForce(Vector2.up * _force);
    }
}

