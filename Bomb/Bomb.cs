using System;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private float _radius = 3f;
    public event Action Detonated;
    
    public void Detonate2()
    {
        Physics2D.CircleCast(transform.position, _radius, transform.position);
        Detonated?.Invoke();
        Destroy(gameObject);
    }
}
