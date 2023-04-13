using System;
public interface IBomb
{
    event Action<IBomb> Detonated;
    void Detonate(float radius);
}
