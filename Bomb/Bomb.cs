using System;
using UnityEngine;

public class Bomb : MonoBehaviour, IBomb
{
    public event Action<IBomb> Detonated;
    BombRadius _bombRadius;

    private void Start() 
    {
        _bombRadius = transform.GetChild(0).GetComponent<BombRadius>();
        _bombRadius.enabled = false;
    } 
    
    public void Detonate(float radius)
    {
        //Detonated?.Invoke(this);
        //_bombRadius.enabled = true;
        //Destroy(gameObject);
    }

    public void Detonate2()
    {
        Detonated?.Invoke(this);
        _bombRadius.enabled = true;
        Destroy(gameObject);
    }
}
